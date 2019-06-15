namespace TestFirebaseDatabase
{
    partial class FormEditPort
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_updatePort = new System.Windows.Forms.Button();
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
            this.btn_deletePort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_language = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Port number";
            // 
            // btn_updatePort
            // 
            this.btn_updatePort.Location = new System.Drawing.Point(108, 184);
            this.btn_updatePort.Name = "btn_updatePort";
            this.btn_updatePort.Size = new System.Drawing.Size(75, 23);
            this.btn_updatePort.TabIndex = 16;
            this.btn_updatePort.Text = "Update";
            this.btn_updatePort.UseVisualStyleBackColor = true;
            this.btn_updatePort.Click += new System.EventHandler(this.btn_updatePort_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_port_true);
            this.groupBox5.Controls.Add(this.rb_port_false);
            this.groupBox5.Location = new System.Drawing.Point(198, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 43);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Port";
            // 
            // rb_port_true
            // 
            this.rb_port_true.AutoSize = true;
            this.rb_port_true.Location = new System.Drawing.Point(6, 19);
            this.rb_port_true.Name = "rb_port_true";
            this.rb_port_true.Size = new System.Drawing.Size(47, 17);
            this.rb_port_true.TabIndex = 3;
            this.rb_port_true.Text = "True";
            this.rb_port_true.UseVisualStyleBackColor = true;
            // 
            // rb_port_false
            // 
            this.rb_port_false.AutoSize = true;
            this.rb_port_false.Checked = true;
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
            this.groupBox4.Location = new System.Drawing.Point(198, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 43);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // rb_data_true
            // 
            this.rb_data_true.AutoSize = true;
            this.rb_data_true.Location = new System.Drawing.Point(6, 19);
            this.rb_data_true.Name = "rb_data_true";
            this.rb_data_true.Size = new System.Drawing.Size(47, 17);
            this.rb_data_true.TabIndex = 3;
            this.rb_data_true.Text = "True";
            this.rb_data_true.UseVisualStyleBackColor = true;
            // 
            // rb_data_false
            // 
            this.rb_data_false.AutoSize = true;
            this.rb_data_false.Checked = true;
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
            this.groupBox3.Location = new System.Drawing.Point(12, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 43);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Die";
            // 
            // rb_die_true
            // 
            this.rb_die_true.AutoSize = true;
            this.rb_die_true.Location = new System.Drawing.Point(6, 19);
            this.rb_die_true.Name = "rb_die_true";
            this.rb_die_true.Size = new System.Drawing.Size(47, 17);
            this.rb_die_true.TabIndex = 3;
            this.rb_die_true.Text = "True";
            this.rb_die_true.UseVisualStyleBackColor = true;
            // 
            // rb_die_false
            // 
            this.rb_die_false.AutoSize = true;
            this.rb_die_false.Checked = true;
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
            this.groupBox2.Location = new System.Drawing.Point(12, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 43);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active";
            // 
            // rb_active_true
            // 
            this.rb_active_true.AutoSize = true;
            this.rb_active_true.Location = new System.Drawing.Point(6, 19);
            this.rb_active_true.Name = "rb_active_true";
            this.rb_active_true.Size = new System.Drawing.Size(47, 17);
            this.rb_active_true.TabIndex = 3;
            this.rb_active_true.Text = "True";
            this.rb_active_true.UseVisualStyleBackColor = true;
            // 
            // rb_active_false
            // 
            this.rb_active_false.AutoSize = true;
            this.rb_active_false.Checked = true;
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
            this.txt_portNumber.Location = new System.Drawing.Point(12, 24);
            this.txt_portNumber.Name = "txt_portNumber";
            this.txt_portNumber.Size = new System.Drawing.Size(366, 20);
            this.txt_portNumber.TabIndex = 15;
            // 
            // btn_deletePort
            // 
            this.btn_deletePort.Location = new System.Drawing.Point(204, 184);
            this.btn_deletePort.Name = "btn_deletePort";
            this.btn_deletePort.Size = new System.Drawing.Size(75, 23);
            this.btn_deletePort.TabIndex = 17;
            this.btn_deletePort.Text = "Delete";
            this.btn_deletePort.UseVisualStyleBackColor = true;
            this.btn_deletePort.Click += new System.EventHandler(this.btn_deletePort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Language";
            // 
            // txt_language
            // 
            this.txt_language.Location = new System.Drawing.Point(12, 161);
            this.txt_language.Name = "txt_language";
            this.txt_language.Size = new System.Drawing.Size(366, 20);
            this.txt_language.TabIndex = 19;
            this.txt_language.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_language_KeyPress);
            // 
            // FormEditPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_language);
            this.Controls.Add(this.btn_deletePort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_updatePort);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_portNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditPort";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "192.168.1.1/80";
            this.Load += new System.EventHandler(this.FormEditPort_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_updatePort;
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
        private System.Windows.Forms.Button btn_deletePort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_language;
    }
}