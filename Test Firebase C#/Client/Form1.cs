using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFirebaseDatabase.Connections;
using TestFirebaseDatabase.Models;

namespace Client
{
    public partial class Form1 : Form
    {
        IPConnection ipConn = new IPConnection();
        IP ip = null;
        string previousPortNumber = "";
        bool stop = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_ip.Focus();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void txt_ip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8
                 && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lv_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lv_port.SelectedItems.Count == 0 || ip == null)
                return;

            string portNumber = this.lv_port.SelectedItems[0].SubItems[1].Text;
            loadLink(portNumber, -1);
        }

        private void loadPort(string portNumberSelected)
        {
            lv_port.Items.Clear();
            lv_link.Items.Clear();

            if (ip == null) return;

            PortConnection portConn = new PortConnection(ip.ipAddress);
            Dictionary<string, Port> lst = new Dictionary<string, Port>();
            lst = Task.Run(() => portConn.GetAll()).Result;

            foreach (Port port in lst.Values)
            {
                ListViewItem item = new ListViewItem(ip.ipAddress.Replace("_", "."));
                item.SubItems.Add(port.portNumber);
                item.SubItems.Add(port.active.ToString());
                item.SubItems.Add(port.data.ToString());
                item.SubItems.Add(port.die.ToString());
                item.SubItems.Add(port.port.ToString());

                if (portNumberSelected != null && port.portNumber == portNumberSelected) item.BackColor = Color.Blue;
                lv_port.Items.Add(item);
            }
        }

        private void loadLink(string portNumber, int index)
        {
            lv_link.Items.Clear();
            PortConnection portConn = new PortConnection(ip.ipAddress);
            Port PortSelected = Task.Run(() => portConn.GetWithKey(portNumber)).Result;

            if (ip == null || PortSelected == null) return;

            LinkConnection linkConn = new LinkConnection(ip.ipAddress, PortSelected.portNumber);
            Dictionary<string, Link> lst = new Dictionary<string, Link>();
            lst = Task.Run(() => linkConn.GetAll()).Result;

            int i = 0;
            foreach (Link link in lst.Values)
            {
                ListViewItem item = new ListViewItem(PortSelected.portNumber);
                item.SubItems.Add(link.key == null ? "" : link.key);
                item.SubItems.Add(link.link == null ? "" : link.link);
                item.SubItems.Add(link.linkThumbnail == null ? "" : link.linkThumbnail);
                item.SubItems.Add(link.title == null ? "" : link.title);
                item.SubItems.Add(link.description == null ? "" : link.description);
                item.SubItems.Add(link.type == null ? "" : link.type + "");

                if (index != -1 && index == i) item.BackColor = Color.Blue;
                i++;
                lv_link.Items.Add(item);
            }
        }

        private void setControl(bool enable)
        {
            txt_ip.Enabled = enable;
            lv_port.Enabled = enable;
            lv_link.Enabled = enable;
            btn_find.Enabled = enable;
            btn_start.Enabled = enable;
        }

        private void addLog(bool hasTime, string ipAddress, string portNumber, string log)
        {
            string time = "[" + DateTime.Now.ToString("HH:mm:ss") +"]";
            if (!hasTime) time = "";
            string ip = (ipAddress == null ? "" : "[" + ipAddress.Replace("_", ".") + "]");
            string port = (portNumber == null ? "" : "[" + portNumber + "]");
            log = (time + " " + ip + " " + port).Trim() + "\t " + log;

            lb_log.Items.Add(log);
            lb_log.SelectedItem = log;
        }

        public void SaveLog()
        {
            try
            {
                // Bước 1: tạo biến để lưu thư mục cần tạo. Tên thư mục đặt theo ngày tháng năm (6-7-2017)
                string directoryPath = Properties.Settings.Default.DataFolder + @"\Logs\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
                // Bước 2: kiểm tra nếu thư mục chưa tồn tại thì tạo mới
                if (!System.IO.Directory.Exists(directoryPath))
                    System.IO.Directory.CreateDirectory(directoryPath);

                // Bước 4: tạo tập tin
                string filePath = directoryPath + @"\["
                    + (DateTime.Now.Hour > 9 ? DateTime.Now.Hour.ToString() : ("0" + DateTime.Now.Hour))
                    + (DateTime.Now.Minute > 9 ? DateTime.Now.Minute.ToString() : ("0" + DateTime.Now.Minute))
                    + (DateTime.Now.Second > 9 ? DateTime.Now.Second.ToString() : ("0" + DateTime.Now.Second)) + "] "
                    + "ahihi.txt";

                // Bước 5: ghi
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var item in lb_log.Items)
                    {
                        sw.WriteLine(item.ToString() + "\n");
                    }

                    sw.Close();
                }
                MessageBox.Show("Save log successfully!");
            }
            catch (Exception)
            {
                MessageBox.Show("Can't save log!");
            }
        }

        private bool checkIpFormat()
        {
            return txt_ip.Text.Trim().Length == 0 ? false : true;
        }

        private async Task Run()
        {
            PortConnection portConn = new PortConnection(ip.ipAddress);
            Port port = Task.Run(() => portConn.GetNextPort(previousPortNumber)).Result;

            if (port == null)
            {
                addLog(true, ip.ipAddress, null, "not found next port!");
                return;
            }

            loadPort(port.portNumber);
            if (port.links != null && port.links.Count > 0) loadLink(port.portNumber, 0);

            //Set để chạy port kế tiếp khi làm xong
            previousPortNumber = port.portNumber;
            //Chạy port
            string ipAddress = ip.ipAddress, portNumber = port.portNumber;
            addLog(true, ipAddress, portNumber, "run port!");

            if (!port.active || !port.data || !port.die || !port.port)
            {
                addLog(true, ipAddress, portNumber, "port not active!");
                return;
            }

            //Lay link dau tien cua port
            LinkConnection linkConn = new LinkConnection(ipAddress, portNumber);
            Link link = Task.Run(() => linkConn.GetFirstElement()).Result;

            addLog(true, ipAddress, portNumber, "run link: " + link.link);
            addLog(true, ipAddress, portNumber, "\tdelete link on database!");

            //Xoa link
            await linkConn.Delete(link.key);
            //Update port
            link = Task.Run(() => linkConn.GetFirstElement()).Result;
            if (link == null)
            {
                port = Task.Run(() => portConn.GetWithKey(portNumber)).Result;
                port.data = false;
                port.active = false;
                //update port
                await portConn.Update(port);
            }

            //Thit
            //.....
            addLog(true, ipAddress, portNumber, "\tstep 1!");
            addLog(true, ipAddress, portNumber, "\tstep 2!");
            addLog(true, ipAddress, portNumber, "\tstep ...!");
            addLog(true, ipAddress, portNumber, "\tstep n!");
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            lv_port.Items.Clear();
            lv_link.Items.Clear();

            if (!checkIpFormat())
            {
                MessageBox.Show("IP khong hop le!");
                return;
            }

            ipConn = new IPConnection();
            ip = Task.Run(() => ipConn.GetWithKey(txt_ip.Text.Replace(".", "_"))).Result;

            if (ip == null)
            {
                MessageBox.Show("Khong tim thay IP!");
                return;
            }

            if (ip.ports == null || ip.ports.Count == 0)
            {
                MessageBox.Show("IP chua co port!");
                return;
            }

            loadPort(null);
            previousPortNumber = ip.ports.Last().Value.portNumber;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lb_log.Items.Clear();

            btn_find.PerformClick();

            Thread thr = new Thread(async () =>
            {
                stop = false;
                setControl(false);
                addLog(false, null, null, "[" + DateTime.Now.ToString() + "]");
                addLog(false, null, null, "================ Start: " + ip.ipAddress.Replace("_", ".") + " =================");
                while (true)
                {
                    await Run();
                    if (stop) break;
                }
                setControl(true);
                addLog(false, null, null, "================ Stop: " + ip.ipAddress.Replace("_", ".") + " =================");
                addLog(false, null, null, "[" + DateTime.Now.ToString() + "]");
                SaveLog();
            });
            thr.IsBackground = true;
            thr.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void btn_setLogFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Properties.Settings.Default.DataFolder = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void btn_openLogFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Properties.Settings.Default.DataFolder);
        }
    }
}
