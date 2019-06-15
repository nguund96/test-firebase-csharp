using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFirebaseDatabase.Models;
using TestFirebaseDatabase.Connections;
using System.Threading;

namespace TestFirebaseDatabase
{
    public partial class FormEditPort : Form
    {
        private PortConnection portConn = null;
        private string ipAddress = "";
        private string portNumber = "";
        private Port port = null;
        public FormEditPort()
        {
            InitializeComponent();
        }

        public FormEditPort(string ipAddress, string portNumber)
        {
            this.ipAddress = ipAddress;
            this.portNumber = portNumber;
            portConn = new PortConnection(ipAddress.Replace(".", "_"));
            port = Task.Run(() => portConn.GetWithKey(portNumber)).Result;

            InitializeComponent();
        }

        private void FormEditPort_Load(object sender, EventArgs e)
        {
            if (port == null)
            {
                MessageBox.Show("Không tìm thấy port!");
                this.Close();
            }

            this.Text = ipAddress + "/" + portNumber;

            txt_portNumber.Text = port.portNumber;
            rb_active_true.Checked = port.active;
            rb_data_true.Checked = port.data;
            rb_die_true.Checked = port.die;
            rb_port_true.Checked = port.port;
            txt_language.Text = port.language.ToString();
        }

        private async void btn_updatePort_Click(object sender, EventArgs e)
        {
            if (txt_portNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập port!");
                return;
            }
            if (txt_language.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập language!");
                return;
            }

            this.Enabled = false;
            bool success = false;
            int loop = 0;
            do
            {
                if (loop == 10) break;
                try
                {
                    //Xóa cái cũ
                    await portConn.Delete(port.portNumber);
                    //Thêm cái mới
                    port.portNumber = txt_portNumber.Text;
                    port.active = rb_active_true.Checked;
                    port.data = rb_data_true.Checked;
                    port.die = rb_die_true.Checked;
                    port.port = rb_port_true.Checked;
                    port.language = Int32.Parse(txt_language.Text);

                    await portConn.Insert(port);
                    success = true;
                }
                catch
                {
                    loop++;
                    Thread.Sleep(2000);
                }
            } while (!success);

            if (!success)
            {
                MessageBox.Show("Đã thử " + loop + " lần mà *** đc :))");
                this.Enabled = true;
            }
            this.Enabled = true;
            this.Close();
        }

        private async void btn_deletePort_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dữ liệu thuộc về Port này cũng sẽ bị xóa hết. Có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool success = false;
                int loop = 0;
                do
                {
                    if (loop == 10) break;
                    try
                    {
                        await portConn.Delete(port.portNumber);
                        success = true;
                    }
                    catch
                    {
                        loop++;
                        Thread.Sleep(2000);
                    }
                } while (!success);

                if (!success)
                {
                    MessageBox.Show("Đã thử " + loop + " lần mà *** đc :))");
                }
                this.Close();
            }
        }

        private void txt_language_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
