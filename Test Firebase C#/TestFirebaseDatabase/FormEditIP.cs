using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFirebaseDatabase.Connections;
using TestFirebaseDatabase.Models;

namespace TestFirebaseDatabase
{
    public partial class FormEditIP : Form
    {
        private IPConnection ipConn = null;
        private string ipAddress = "";
        private IP ip = null;
        public FormEditIP()
        {
            InitializeComponent();
        }

        public FormEditIP(string ipAddress)
        {
            this.ipAddress = ipAddress;
            ipConn = new IPConnection();
            ip = Task.Run(() => ipConn.GetWithKey(ipAddress.Replace(".", "_"))).Result;
            InitializeComponent();
        }

        private void FormPort_Load(object sender, EventArgs e)
        {
            this.Text = ipAddress;
            if (ip == null)
            {
                MessageBox.Show("Không tìm thấy IP!");
                return;
            }
            else
            {
                txt_ip.Text = ip.ipAddress.Replace("_", ".");
            }
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            //chưa sửa
            if (txt_ip.Text.Replace(".", "_") == ip.ipAddress) this.Close();

            //check
            IP ipCheck = Task.Run(() => ipConn.GetWithKey(txt_ip.Text.Replace(".", "_"))).Result;
            if (ipCheck != null)
            {
                MessageBox.Show("IP đã tồn tại!");
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
                    await ipConn.Delete(ip.ipAddress);
                    //Thêm cái mới
                    ip.ipAddress = txt_ip.Text.Replace(".", "_");
                    await ipConn.Insert(ip);
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

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dữ liệu thuộc về IP này cũng sẽ bị xóa hết. Có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool success = false;
                int loop = 0;
                do
                {
                    if (loop == 10) break;
                    try
                    {
                        await ipConn.Delete(ip.ipAddress);
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
    }
}
