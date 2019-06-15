namespace Client
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
            this.lv_port = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_link = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_stop = new System.Windows.Forms.Button();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.lb_log = new System.Windows.Forms.ListBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_setLogFolder = new System.Windows.Forms.Button();
            this.btn_openLogFolder = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_port
            // 
            this.lv_port.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lv_port.FullRowSelect = true;
            this.lv_port.GridLines = true;
            this.lv_port.Location = new System.Drawing.Point(2, 123);
            this.lv_port.Name = "lv_port";
            this.lv_port.Size = new System.Drawing.Size(381, 361);
            this.lv_port.TabIndex = 9;
            this.lv_port.UseCompatibleStateImageBehavior = false;
            this.lv_port.View = System.Windows.Forms.View.Details;
            this.lv_port.SelectedIndexChanged += new System.EventHandler(this.lv_port_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP";
            this.columnHeader3.Width = 126;
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
            this.columnHeader9.Width = 39;
            // 
            // lv_link
            // 
            this.lv_link.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader12,
            this.columnHeader11,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader4,
            this.columnHeader10});
            this.lv_link.FullRowSelect = true;
            this.lv_link.GridLines = true;
            this.lv_link.Location = new System.Drawing.Point(389, 194);
            this.lv_link.Name = "lv_link";
            this.lv_link.Size = new System.Drawing.Size(581, 290);
            this.lv_link.TabIndex = 10;
            this.lv_link.UseCompatibleStateImageBehavior = false;
            this.lv_link.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Port Number";
            this.columnHeader15.Width = 76;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Key";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Link";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Link thumbnail";
            this.columnHeader16.Width = 207;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Title";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Type";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_openLogFolder);
            this.panel2.Controls.Add(this.btn_setLogFolder);
            this.panel2.Controls.Add(this.btn_start);
            this.panel2.Controls.Add(this.btn_stop);
            this.panel2.Controls.Add(this.txt_ip);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_find);
            this.panel2.Location = new System.Drawing.Point(2, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 110);
            this.panel2.TabIndex = 15;
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stop.Location = new System.Drawing.Point(253, 49);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(121, 23);
            this.btn_stop.TabIndex = 17;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(4, 23);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(370, 20);
            this.txt_ip.TabIndex = 0;
            this.txt_ip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ip_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "IP";
            // 
            // btn_find
            // 
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_find.Location = new System.Drawing.Point(4, 49);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(121, 23);
            this.btn_find.TabIndex = 1;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // lb_log
            // 
            this.lb_log.BackColor = System.Drawing.SystemColors.Window;
            this.lb_log.FormattingEnabled = true;
            this.lb_log.Location = new System.Drawing.Point(389, 7);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(581, 173);
            this.lb_log.TabIndex = 17;
            // 
            // btn_start
            // 
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.Location = new System.Drawing.Point(129, 49);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(121, 23);
            this.btn_start.TabIndex = 18;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_setLogFolder
            // 
            this.btn_setLogFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_setLogFolder.Location = new System.Drawing.Point(195, 78);
            this.btn_setLogFolder.Name = "btn_setLogFolder";
            this.btn_setLogFolder.Size = new System.Drawing.Size(179, 23);
            this.btn_setLogFolder.TabIndex = 19;
            this.btn_setLogFolder.Text = "Set log folder";
            this.btn_setLogFolder.UseVisualStyleBackColor = true;
            this.btn_setLogFolder.Click += new System.EventHandler(this.btn_setLogFolder_Click);
            // 
            // btn_openLogFolder
            // 
            this.btn_openLogFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_openLogFolder.Location = new System.Drawing.Point(4, 78);
            this.btn_openLogFolder.Name = "btn_openLogFolder";
            this.btn_openLogFolder.Size = new System.Drawing.Size(179, 23);
            this.btn_openLogFolder.TabIndex = 20;
            this.btn_openLogFolder.Text = "Open log folder";
            this.btn_openLogFolder.UseVisualStyleBackColor = true;
            this.btn_openLogFolder.Click += new System.EventHandler(this.btn_openLogFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 484);
            this.Controls.Add(this.lb_log);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lv_link);
            this.Controls.Add(this.lv_port);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_port;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lv_link;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ListBox lb_log;
        private System.Windows.Forms.Button btn_setLogFolder;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_openLogFolder;

    }
}

