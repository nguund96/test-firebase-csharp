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
    public partial class FormEditLink : Form
    {
        LinkConnection linkConn = null;
        Link link = null;
        private string ipAddress = "";
        private string portNumber = "";
        private string key = "";

        public FormEditLink()
        {
            InitializeComponent();
        }

        public FormEditLink(string ipAddress, string portNumber, string key)
        {
            this.ipAddress = ipAddress;
            this.portNumber = portNumber;
            this.key = key;
            linkConn = new LinkConnection(ipAddress.Replace(".", "_"), portNumber);
            link = Task.Run(() => linkConn.GetWithKey(key)).Result;

            InitializeComponent();
        }

        private void FormEditLink_Load(object sender, EventArgs e)
        {
            if (link == null)
            {
                MessageBox.Show("Không tìm thấy link!");
                this.Close();
            }

            this.Text = ipAddress + "/" + portNumber;

            txt_link.Text = link.link;
            txt_linkThumbnail.Text = link.linkThumbnail;
            txt_title.Text = link.title;
            txt_tag.Text = link.tag;
            txt_description.Text = link.description;
            txt_linkAff.Text = link.linkAff;
            txt_type.Text = link.type + "";
        }

        private async void btn_updateLink_Click(object sender, EventArgs e)
        {
            link.link = txt_link.Text;
            link.linkThumbnail = txt_linkThumbnail.Text;
            link.title = txt_title.Text;
            link.tag = txt_tag.Text;
            link.description = txt_description.Text;
            link.linkAff = txt_linkAff.Text;
            link.type = Int32.Parse(txt_type.Text);

            this.Enabled = false;
            bool success = false;
            int loop = 0;
            do
            {
                if (loop == 10) break;
                try
                {
                    await linkConn.Update(link);
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

        private async void btn_deleteLink_Click(object sender, EventArgs e)
        {
            bool success = false;
            int loop = 0;
            do
            {
                if (loop == 10) break;
                try
                {
                    await linkConn.Delete(link.key);
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
