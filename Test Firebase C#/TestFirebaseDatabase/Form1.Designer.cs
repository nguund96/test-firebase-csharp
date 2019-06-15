namespace TestFirebaseDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.btn_addIP = new System.Windows.Forms.Button();
            this.rb_availability_true = new System.Windows.Forms.RadioButton();
            this.rb_availability_false = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reload = new System.Windows.Forms.Button();
            this.lv_ip = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_language = new System.Windows.Forms.TextBox();
            this.btn_reloadPort = new System.Windows.Forms.Button();
            this.lv_port = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addPort = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_port_true = new System.Windows.Forms.RadioButton();
            this.rb_port_false = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_data_true = new System.Windows.Forms.RadioButton();
            this.rb_data_false = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_die_true = new System.Windows.Forms.RadioButton();
            this.rb_die_false = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_active_true = new System.Windows.Forms.RadioButton();
            this.rb_active_false = new System.Windows.Forms.RadioButton();
            this.txt_portNumber = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tag = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_linkAff = new System.Windows.Forms.TextBox();
            this.btn_reloadLink = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lv_link = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addLink = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_linkThumbnail = new System.Windows.Forms.TextBox();
            this.lbl_ipSelected = new System.Windows.Forms.Label();
            this.lbl_portSelected = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(10, 22);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(180, 20);
            this.txt_ip.TabIndex = 0;
            this.txt_ip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ip_KeyPress);
            // 
            // btn_addIP
            // 
            this.btn_addIP.Location = new System.Drawing.Point(62, 97);
            this.btn_addIP.Name = "btn_addIP";
            this.btn_addIP.Size = new System.Drawing.Size(75, 23);
            this.btn_addIP.TabIndex = 2;
            this.btn_addIP.Text = "Add";
            this.btn_addIP.UseVisualStyleBackColor = true;
            this.btn_addIP.Click += new System.EventHandler(this.btn_addIP_Click);
            // 
            // rb_availability_true
            // 
            this.rb_availability_true.AutoSize = true;
            this.rb_availability_true.Location = new System.Drawing.Point(6, 19);
            this.rb_availability_true.Name = "rb_availability_true";
            this.rb_availability_true.Size = new System.Drawing.Size(47, 17);
            this.rb_availability_true.TabIndex = 3;
            this.rb_availability_true.TabStop = true;
            this.rb_availability_true.Text = "True";
            this.rb_availability_true.UseVisualStyleBackColor = true;
            // 
            // rb_availability_false
            // 
            this.rb_availability_false.AutoSize = true;
            this.rb_availability_false.Checked = true;
            this.rb_availability_false.Location = new System.Drawing.Point(121, 19);
            this.rb_availability_false.Name = "rb_availability_false";
            this.rb_availability_false.Size = new System.Drawing.Size(50, 17);
            this.rb_availability_false.TabIndex = 4;
            this.rb_availability_false.TabStop = true;
            this.rb_availability_false.Text = "False";
            this.rb_availability_false.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_availability_true);
            this.groupBox1.Controls.Add(this.rb_availability_false);
            this.groupBox1.Location = new System.Drawing.Point(10, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 43);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Availability";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Controls.Add(this.lv_ip);
            this.panel1.Controls.Add(this.txt_ip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_addIP);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 489);
            this.panel1.TabIndex = 7;
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(165, 97);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(25, 23);
            this.btn_reload.TabIndex = 8;
            this.btn_reload.Text = "R";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reloadIP_Click);
            // 
            // lv_ip
            // 
            this.lv_ip.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_ip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv_ip.FullRowSelect = true;
            this.lv_ip.GridLines = true;
            this.lv_ip.Location = new System.Drawing.Point(0, 126);
            this.lv_ip.Name = "lv_ip";
            this.lv_ip.Size = new System.Drawing.Size(201, 359);
            this.lv_ip.TabIndex = 7;
            this.lv_ip.UseCompatibleStateImageBehavior = false;
            this.lv_ip.View = System.Windows.Forms.View.Details;
            this.lv_ip.SelectedIndexChanged += new System.EventHandler(this.lv_ip_SelectedIndexChanged);
            this.lv_ip.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_ip_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Availability";
            this.columnHeader2.Width = 62;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_language);
            this.panel2.Controls.Add(this.btn_reloadPort);
            this.panel2.Controls.Add(this.lv_port);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_addPort);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.txt_portNumber);
            this.panel2.Location = new System.Drawing.Point(210, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 489);
            this.panel2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Language";
            // 
            // txt_language
            // 
            this.txt_language.Location = new System.Drawing.Point(3, 159);
            this.txt_language.Name = "txt_language";
            this.txt_language.Size = new System.Drawing.Size(366, 20);
            this.txt_language.TabIndex = 11;
            this.txt_language.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_language_KeyPress);
            // 
            // btn_reloadPort
            // 
            this.btn_reloadPort.Location = new System.Drawing.Point(344, 182);
            this.btn_reloadPort.Name = "btn_reloadPort";
            this.btn_reloadPort.Size = new System.Drawing.Size(25, 23);
            this.btn_reloadPort.TabIndex = 9;
            this.btn_reloadPort.Text = "R";
            this.btn_reloadPort.UseVisualStyleBackColor = true;
            this.btn_reloadPort.Click += new System.EventHandler(this.btn_reloadPort_Click);
            // 
            // lv_port
            // 
            this.lv_port.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader13});
            this.lv_port.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv_port.FullRowSelect = true;
            this.lv_port.GridLines = true;
            this.lv_port.Location = new System.Drawing.Point(0, 209);
            this.lv_port.Name = "lv_port";
            this.lv_port.Size = new System.Drawing.Size(374, 276);
            this.lv_port.TabIndex = 8;
            this.lv_port.UseCompatibleStateImageBehavior = false;
            this.lv_port.View = System.Windows.Forms.View.Details;
            this.lv_port.SelectedIndexChanged += new System.EventHandler(this.lv_port_SelectedIndexChanged);
            this.lv_port.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_port_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Port Number";
            this.columnHeader5.Width = 72;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Active";
            this.columnHeader6.Width = 43;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Data";
            this.columnHeader7.Width = 41;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Die";
            this.columnHeader8.Width = 39;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Port";
            this.columnHeader9.Width = 47;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Language";
            this.columnHeader13.Width = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port number";
            // 
            // btn_addPort
            // 
            this.btn_addPort.Location = new System.Drawing.Point(152, 182);
            this.btn_addPort.Name = "btn_addPort";
            this.btn_addPort.Size = new System.Drawing.Size(75, 23);
            this.btn_addPort.TabIndex = 9;
            this.btn_addPort.Text = "Add";
            this.btn_addPort.UseVisualStyleBackColor = true;
            this.btn_addPort.Click += new System.EventHandler(this.btn_addPort_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_port_true);
            this.groupBox5.Controls.Add(this.rb_port_false);
            this.groupBox5.Location = new System.Drawing.Point(189, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 43);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Port";
            // 
            // rb_port_true
            // 
            this.rb_port_true.AutoSize = true;
            this.rb_port_true.Checked = true;
            this.rb_port_true.Location = new System.Drawing.Point(6, 19);
            this.rb_port_true.Name = "rb_port_true";
            this.rb_port_true.Size = new System.Drawing.Size(47, 17);
            this.rb_port_true.TabIndex = 3;
            this.rb_port_true.TabStop = true;
            this.rb_port_true.Text = "True";
            this.rb_port_true.UseVisualStyleBackColor = true;
            // 
            // rb_port_false
            // 
            this.rb_port_false.AutoSize = true;
            this.rb_port_false.Location = new System.Drawing.Point(121, 19);
            this.rb_port_false.Name = "rb_port_false";
            this.rb_port_false.Size = new System.Drawing.Size(50, 17);
            this.rb_port_false.TabIndex = 4;
            this.rb_port_false.TabStop = true;
            this.rb_port_false.Text = "False";
            this.rb_port_false.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_data_true);
            this.groupBox4.Controls.Add(this.rb_data_false);
            this.groupBox4.Location = new System.Drawing.Point(189, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 43);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // rb_data_true
            // 
            this.rb_data_true.AutoSize = true;
            this.rb_data_true.Checked = true;
            this.rb_data_true.Location = new System.Drawing.Point(6, 19);
            this.rb_data_true.Name = "rb_data_true";
            this.rb_data_true.Size = new System.Drawing.Size(47, 17);
            this.rb_data_true.TabIndex = 3;
            this.rb_data_true.TabStop = true;
            this.rb_data_true.Text = "True";
            this.rb_data_true.UseVisualStyleBackColor = true;
            // 
            // rb_data_false
            // 
            this.rb_data_false.AutoSize = true;
            this.rb_data_false.Location = new System.Drawing.Point(121, 19);
            this.rb_data_false.Name = "rb_data_false";
            this.rb_data_false.Size = new System.Drawing.Size(50, 17);
            this.rb_data_false.TabIndex = 4;
            this.rb_data_false.TabStop = true;
            this.rb_data_false.Text = "False";
            this.rb_data_false.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_die_true);
            this.groupBox3.Controls.Add(this.rb_die_false);
            this.groupBox3.Location = new System.Drawing.Point(3, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 43);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Die";
            // 
            // rb_die_true
            // 
            this.rb_die_true.AutoSize = true;
            this.rb_die_true.Checked = true;
            this.rb_die_true.Location = new System.Drawing.Point(6, 19);
            this.rb_die_true.Name = "rb_die_true";
            this.rb_die_true.Size = new System.Drawing.Size(47, 17);
            this.rb_die_true.TabIndex = 3;
            this.rb_die_true.TabStop = true;
            this.rb_die_true.Text = "True";
            this.rb_die_true.UseVisualStyleBackColor = true;
            // 
            // rb_die_false
            // 
            this.rb_die_false.AutoSize = true;
            this.rb_die_false.Location = new System.Drawing.Point(121, 19);
            this.rb_die_false.Name = "rb_die_false";
            this.rb_die_false.Size = new System.Drawing.Size(50, 17);
            this.rb_die_false.TabIndex = 4;
            this.rb_die_false.TabStop = true;
            this.rb_die_false.Text = "False";
            this.rb_die_false.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_active_true);
            this.groupBox2.Controls.Add(this.rb_active_false);
            this.groupBox2.Location = new System.Drawing.Point(3, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 43);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active";
            // 
            // rb_active_true
            // 
            this.rb_active_true.AutoSize = true;
            this.rb_active_true.Checked = true;
            this.rb_active_true.Location = new System.Drawing.Point(6, 19);
            this.rb_active_true.Name = "rb_active_true";
            this.rb_active_true.Size = new System.Drawing.Size(47, 17);
            this.rb_active_true.TabIndex = 3;
            this.rb_active_true.TabStop = true;
            this.rb_active_true.Text = "True";
            this.rb_active_true.UseVisualStyleBackColor = true;
            // 
            // rb_active_false
            // 
            this.rb_active_false.AutoSize = true;
            this.rb_active_false.Location = new System.Drawing.Point(121, 19);
            this.rb_active_false.Name = "rb_active_false";
            this.rb_active_false.Size = new System.Drawing.Size(50, 17);
            this.rb_active_false.TabIndex = 4;
            this.rb_active_false.TabStop = true;
            this.rb_active_false.Text = "False";
            this.rb_active_false.UseVisualStyleBackColor = true;
            // 
            // txt_portNumber
            // 
            this.txt_portNumber.Location = new System.Drawing.Point(3, 22);
            this.txt_portNumber.Name = "txt_portNumber";
            this.txt_portNumber.Size = new System.Drawing.Size(366, 20);
            this.txt_portNumber.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_tag);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_linkAff);
            this.panel3.Controls.Add(this.btn_reloadLink);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_link);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_type);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_description);
            this.panel3.Controls.Add(this.lv_link);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btn_addLink);
            this.panel3.Controls.Add(this.txt_title);
            this.panel3.Controls.Add(this.txt_linkThumbnail);
            this.panel3.Location = new System.Drawing.Point(594, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 489);
            this.panel3.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tag";
            // 
            // txt_tag
            // 
            this.txt_tag.Location = new System.Drawing.Point(3, 139);
            this.txt_tag.Name = "txt_tag";
            this.txt_tag.Size = new System.Drawing.Size(618, 20);
            this.txt_tag.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Description 2";
            // 
            // txt_linkAff
            // 
            this.txt_linkAff.Location = new System.Drawing.Point(3, 252);
            this.txt_linkAff.Multiline = true;
            this.txt_linkAff.Name = "txt_linkAff";
            this.txt_linkAff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_linkAff.Size = new System.Drawing.Size(618, 48);
            this.txt_linkAff.TabIndex = 16;
            // 
            // btn_reloadLink
            // 
            this.btn_reloadLink.Location = new System.Drawing.Point(596, 342);
            this.btn_reloadLink.Name = "btn_reloadLink";
            this.btn_reloadLink.Size = new System.Drawing.Size(25, 23);
            this.btn_reloadLink.TabIndex = 10;
            this.btn_reloadLink.Text = "R";
            this.btn_reloadLink.UseVisualStyleBackColor = true;
            this.btn_reloadLink.Click += new System.EventHandler(this.btn_reloadLink_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Link";
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(3, 22);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(618, 20);
            this.txt_link.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(3, 319);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(618, 20);
            this.txt_type.TabIndex = 12;
            this.txt_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_type_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(3, 182);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_description.Size = new System.Drawing.Size(618, 48);
            this.txt_description.TabIndex = 10;
            // 
            // lv_link
            // 
            this.lv_link.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader12,
            this.columnHeader11,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader4,
            this.columnHeader14,
            this.columnHeader10});
            this.lv_link.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv_link.FullRowSelect = true;
            this.lv_link.GridLines = true;
            this.lv_link.Location = new System.Drawing.Point(0, 371);
            this.lv_link.Name = "lv_link";
            this.lv_link.Size = new System.Drawing.Size(624, 114);
            this.lv_link.TabIndex = 9;
            this.lv_link.UseCompatibleStateImageBehavior = false;
            this.lv_link.View = System.Windows.Forms.View.Details;
            this.lv_link.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_link_MouseClick);
            this.lv_link.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_link_MouseDoubleClick);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Port Number";
            this.columnHeader15.Width = 76;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Key";
            this.columnHeader12.Width = 32;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Link";
            this.columnHeader11.Width = 84;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Link thumbnail";
            this.columnHeader16.Width = 106;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Title";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Tag";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Description 2";
            this.columnHeader14.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Link thumbnail";
            // 
            // btn_addLink
            // 
            this.btn_addLink.Location = new System.Drawing.Point(288, 345);
            this.btn_addLink.Name = "btn_addLink";
            this.btn_addLink.Size = new System.Drawing.Size(75, 23);
            this.btn_addLink.TabIndex = 2;
            this.btn_addLink.Text = "Add";
            this.btn_addLink.UseVisualStyleBackColor = true;
            this.btn_addLink.Click += new System.EventHandler(this.btn_addLink_Click);
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(3, 100);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(618, 20);
            this.txt_title.TabIndex = 1;
            // 
            // txt_linkThumbnail
            // 
            this.txt_linkThumbnail.Location = new System.Drawing.Point(3, 61);
            this.txt_linkThumbnail.Name = "txt_linkThumbnail";
            this.txt_linkThumbnail.Size = new System.Drawing.Size(618, 20);
            this.txt_linkThumbnail.TabIndex = 0;
            // 
            // lbl_ipSelected
            // 
            this.lbl_ipSelected.AutoSize = true;
            this.lbl_ipSelected.Location = new System.Drawing.Point(8, 491);
            this.lbl_ipSelected.Name = "lbl_ipSelected";
            this.lbl_ipSelected.Size = new System.Drawing.Size(62, 13);
            this.lbl_ipSelected.TabIndex = 10;
            this.lbl_ipSelected.Text = "IP Selected";
            // 
            // lbl_portSelected
            // 
            this.lbl_portSelected.AutoSize = true;
            this.lbl_portSelected.Location = new System.Drawing.Point(212, 491);
            this.lbl_portSelected.Name = "lbl_portSelected";
            this.lbl_portSelected.Size = new System.Drawing.Size(71, 13);
            this.lbl_portSelected.TabIndex = 11;
            this.lbl_portSelected.Text = "Port Selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 508);
            this.Controls.Add(this.lbl_portSelected);
            this.Controls.Add(this.lbl_ipSelected);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tam giác vuông tròn tam giác vuông";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button btn_addIP;
        private System.Windows.Forms.RadioButton rb_availability_true;
        private System.Windows.Forms.RadioButton rb_availability_false;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_ip;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lv_port;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addPort;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_port_true;
        private System.Windows.Forms.RadioButton rb_port_false;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_data_true;
        private System.Windows.Forms.RadioButton rb_data_false;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_die_true;
        private System.Windows.Forms.RadioButton rb_die_false;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_active_true;
        private System.Windows.Forms.RadioButton rb_active_false;
        private System.Windows.Forms.TextBox txt_portNumber;
        private System.Windows.Forms.ListView lv_link;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addLink;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_linkThumbnail;
        private System.Windows.Forms.Label lbl_ipSelected;
        private System.Windows.Forms.Label lbl_portSelected;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btn_reloadPort;
        private System.Windows.Forms.Button btn_reloadLink;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_language;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_linkAff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tag;
        private System.Windows.Forms.ColumnHeader columnHeader18;
    }
}

