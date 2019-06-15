using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFirebaseDatabase.Connections;
using TestFirebaseDatabase.Models;
using System.Management;
using System.Threading;

namespace TestFirebaseDatabase
{
    public partial class Form1 : Form
    {
        IP IPSelected = null;
        Port PortSelected = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            loadIPWithWaitForm();
        }

        private bool checkIP(IP ip)
        {
            if (ip.ports == null) return true;
            foreach (Port port in ip.ports.Values)
            {
                if (!port.active || !port.data || !port.die || !port.port) return false;
            }
            return true;
        }

        #region Load data

        private void loadIP()
        {
            bool success = false;
            int loop = 0;
            do
            {
                if (loop == 10) break;
                try
                {
                    lv_ip.Items.Clear();
                    lv_port.Items.Clear();
                    lv_link.Items.Clear();
                    lbl_ipSelected.Text = "IP Selected: ";
                    lbl_portSelected.Text = "Port Selected: ";

                    IPConnection ipConn = new IPConnection();
                    Dictionary<string, IP> ips = new Dictionary<string, IP>();
                    ips = Task.Run(() => ipConn.GetAll()).Result;

                    foreach (IP ip in ips.Values)
                    {
                        ListViewItem item = new ListViewItem(ip.ipAddress.Replace("_", "."));
                        item.SubItems.Add(ip.availability.ToString());
                        if (!checkIP(ip)) item.BackColor = Color.Red;
                        lv_ip.Items.Add(item);
                    }
                    success = true;
                }
                catch
                {
                    loop++;
                    Thread.Sleep(1000);
                }
            } while (!success);

            if (!success)
            {
                MessageBox.Show("Đã thử load " + loop + " lần mà *** đc :))");
            }
        }

        private void loadIPWithWaitForm()
        {
            using (frmWaitForm frm = new frmWaitForm("Loading IP...", loadIP))
            {
                frm.ShowDialog(this);
            }
        }

        private void loadPort()
        {
            bool success = false;
            int loop = 0;
            do
            {
                if (loop == 10) break;
                try
                {
                    lv_port.Items.Clear();
                    lv_link.Items.Clear();
                    lbl_portSelected.Text = "Port Selected: ";

                    if (IPSelected == null) return;

                    PortConnection portConn = new PortConnection(IPSelected.ipAddress);
                    Dictionary<string, Port> lst = new Dictionary<string, Port>();
                    lst = Task.Run(() => portConn.GetAll()).Result;

                    foreach (Port port in lst.Values)
                    {
                        ListViewItem item = new ListViewItem(IPSelected.ipAddress.Replace("_", "."));
                        item.SubItems.Add(port.portNumber);
                        item.SubItems.Add(port.active.ToString());
                        item.SubItems.Add(port.data.ToString());
                        item.SubItems.Add(port.die.ToString());
                        item.SubItems.Add(port.port.ToString());
                        item.SubItems.Add(port.language.ToString());

                        lv_port.Items.Add(item);
                    }
                    success = true;
                }
                catch
                {
                    loop++;
                    Thread.Sleep(1000);
                }
            } while (!success);

            if (!success)
            {
                MessageBox.Show("Đã thử load " + loop + " lần mà *** đc :))");
            }
        }

        private void loadPortWithWaitForm()
        {
            using (frmWaitForm frm = new frmWaitForm("Loading port...", loadPort))
            {
                frm.ShowDialog(this);
            }
        }

        private void loadLink()
        {
            bool success = false;
            int loop = 0;
            do
            {
                if (loop == 10) break;
                try
                {
                    lv_link.Items.Clear();
                    if (IPSelected == null || PortSelected == null) return;

                    LinkConnection linkConn = new LinkConnection(IPSelected.ipAddress, PortSelected.portNumber);
                    Dictionary<string, Link> lst = new Dictionary<string, Link>();
                    lst = Task.Run(() => linkConn.GetAll()).Result;

                    foreach (Link link in lst.Values)
                    {
                        ListViewItem item = new ListViewItem(PortSelected.portNumber);
                        item.SubItems.Add(link.key == null ? "" : link.key);
                        item.SubItems.Add(link.link == null ? "" : link.link);
                        item.SubItems.Add(link.linkThumbnail == null ? "" : link.linkThumbnail);
                        item.SubItems.Add(link.title == null ? "" : link.title);
                        item.SubItems.Add(link.tag == null ? "" : link.tag);
                        item.SubItems.Add(link.description == null ? "" : link.description);
                        item.SubItems.Add(link.linkAff == null ? "" : link.linkAff);
                        item.SubItems.Add(link.type + "");

                        lv_link.Items.Add(item);
                    }
                    success = true;
                }
                catch
                {
                    loop++;
                    Thread.Sleep(1000);
                }
            } while (!success);

            if (!success)
            {
                MessageBox.Show("Đã thử load " + loop + " lần mà *** đc :))");
            }
        }

        private void loadLinkWithWaitForm()
        {
            using (frmWaitForm frm = new frmWaitForm("Loading link...", loadLink))
            {
                frm.ShowDialog(this);
            }
        }

        #endregion

        #region Selected change
        private void lv_ip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lv_ip.SelectedItems.Count == 0)
                return;

            string ipAddress = this.lv_ip.SelectedItems[0].SubItems[0].Text;
            IPConnection ipConn = new IPConnection();
            IPSelected = Task.Run(() => ipConn.GetWithKey(ipAddress.Replace(".", "_"))).Result;

            if (IPSelected == null)
            {
                lv_port.Items.Clear();
                lv_link.Items.Clear();
                return;
            }
            lbl_ipSelected.Text = "IP Selected: " + ipAddress;
            lbl_portSelected.Text = "Port Selected: ";


            loadPortWithWaitForm();
        }

        private void lv_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lv_port.SelectedItems.Count == 0 || IPSelected == null)
                return;

            string portNumber = this.lv_port.SelectedItems[0].SubItems[1].Text;
            PortConnection portConn = new PortConnection(IPSelected.ipAddress);
            PortSelected = Task.Run(() => portConn.GetWithKey(portNumber)).Result;

            if (PortSelected == null) return;
            lbl_portSelected.Text = "Port Selected: " + portNumber;

            loadLinkWithWaitForm();
        }

        #endregion

        #region Add data
        private async void btn_addIP_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            bool success = false;
            int loop = 0;
            do
            {
                if (loop == 10) break;
                try
                {
                    IPConnection ipConn = new IPConnection();
                    IP ip = new IP();
                    ip.ipAddress = txt_ip.Text.Replace(".", "_");
                    ip.availability = rb_availability_true.Checked;

                    await ipConn.Insert(ip);

                    success = true;

                    loadIPWithWaitForm();
                    resetInputIP();
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
        }

        private async void btn_addPort_Click(object sender, EventArgs e)
        {
            if (IPSelected == null)
            {
                MessageBox.Show("Chưa chọn IP!");
                return;
            }
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
                    Port port = new Port();
                    port.portNumber = txt_portNumber.Text;
                    port.active = rb_active_true.Checked;
                    port.data = rb_data_true.Checked;
                    port.die = rb_die_true.Checked;
                    port.port = rb_port_true.Checked;
                    port.language = Int32.Parse(txt_language.Text);

                    PortConnection portConn = new PortConnection(IPSelected.ipAddress);
                    await portConn.Insert(port);

                    success = true;

                    loadPortWithWaitForm();
                    resetInputPort();
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
        }

        private async void btn_addLink_Click(object sender, EventArgs e)
        {
            if (PortSelected == null)
            {
                MessageBox.Show("Chua chon Port!");
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
                    Link link = new Link();
                    link.link = txt_link.Text;
                    link.linkThumbnail = txt_linkThumbnail.Text;
                    link.title = txt_title.Text;
                    link.tag = txt_tag.Text;
                    link.description = txt_description.Text;
                    link.linkAff = txt_linkAff.Text;
                    link.type = Int32.Parse(txt_type.Text);

                    LinkConnection linkConn = new LinkConnection(IPSelected.ipAddress, PortSelected.portNumber);
                    await linkConn.Insert(link);

                    //Update port.data
                    PortConnection portConn = new PortConnection(IPSelected.ipAddress);
                    PortSelected = Task.Run(() => portConn.GetWithKey(PortSelected.portNumber)).Result;
                    if (PortSelected.links != null && PortSelected.links.Count > 0 && !PortSelected.data)
                    {
                        PortSelected.data = true;
                        await portConn.Delete(PortSelected.portNumber);
                        await portConn.Insert(PortSelected);
                        loadPort();
                    }

                    success = true;

                    loadLinkWithWaitForm();
                    resetInputLink();
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
        }

        #endregion

        #region Edit data
        private void lv_ip_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.lv_ip.SelectedItems.Count == 0)
                return;

            string ipAddress = this.lv_ip.SelectedItems[0].SubItems[0].Text;
            FormEditIP frm = new FormEditIP(ipAddress);
            frm.ShowDialog();

            loadIPWithWaitForm();
        }

        private void lv_port_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.lv_port.SelectedItems.Count == 0)
                return;

            string ipAddress = this.lv_port.SelectedItems[0].SubItems[0].Text;
            string portNumber = this.lv_port.SelectedItems[0].SubItems[1].Text;
            FormEditPort frm = new FormEditPort(ipAddress, portNumber);
            frm.ShowDialog();

            loadPortWithWaitForm();
        }

        private void lv_link_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.lv_link.SelectedItems.Count == 0)
                return;

            string key = this.lv_link.SelectedItems[0].SubItems[1].Text;
            FormEditLink frm = new FormEditLink(IPSelected.ipAddress, PortSelected.portNumber, key);
            frm.ShowDialog();

            loadLinkWithWaitForm();
        }

        private void lv_link_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.lv_link.SelectedItems[0].SubItems[2].Text);
        }

        #endregion

        #region Reset input
        private void resetInputIP()
        {
            txt_ip.Text = "";
            rb_availability_true.Checked = true;
            txt_ip.Focus();
        }

        private void resetInputPort()
        {
            txt_portNumber.Text = "";
            rb_active_true.Checked = true;
            rb_data_true.Checked = true;
            rb_die_true.Checked = true;
            rb_port_true.Checked = true;
            txt_language.Text = "";
            txt_portNumber.Focus();
        }

        private void resetInputLink()
        {
            txt_link.Text = "";
            txt_linkThumbnail.Text = "";
            txt_title.Text = "";
            txt_tag.Text = "";
            txt_description.Text = "";
            txt_linkAff.Text = "";
            txt_type.Text = "";
            txt_link.Focus();
        }

        #endregion

        #region KeyPress
        private void txt_ip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8
                 && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_language_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Reload data
        private void btn_reloadIP_Click(object sender, EventArgs e)
        {
            loadIPWithWaitForm();
        }

        private void btn_reloadPort_Click(object sender, EventArgs e)
        {
            if (IPSelected == null)
            {
                MessageBox.Show("Chưa chọn IP!");
            }
            loadPortWithWaitForm();
        }

        private void btn_reloadLink_Click(object sender, EventArgs e)
        {
            if (PortSelected == null)
            {
                MessageBox.Show("Chưa chọn port!");
            }
            loadLinkWithWaitForm();
        }
        #endregion
    }
}
