namespace Skills_International
{
    partial class Student_Registration
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
            this.Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.parent_name_txt = new System.Windows.Forms.TextBox();
            this.contact_no_txt = new System.Windows.Forms.TextBox();
            this.nic_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tele_txt = new System.Windows.Forms.TextBox();
            this.mobile_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.dob_picker = new System.Windows.Forms.DateTimePicker();
            this.last_name_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.first_name_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegNo_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logout_link = new System.Windows.Forms.LinkLabel();
            this.exit_link = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(237, 17);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(231, 33);
            this.Title.TabIndex = 0;
            this.Title.Text = "Skills International";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.register_btn);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.RegNo_combo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(694, 827);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(506, 788);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(74, 25);
            this.clear_btn.TabIndex = 4;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(592, 788);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(74, 25);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(120, 788);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(74, 25);
            this.update_btn.TabIndex = 4;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(33, 788);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(74, 25);
            this.register_btn.TabIndex = 4;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.parent_name_txt);
            this.groupBox4.Controls.Add(this.contact_no_txt);
            this.groupBox4.Controls.Add(this.nic_txt);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(33, 575);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(633, 201);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parent Details";
            // 
            // parent_name_txt
            // 
            this.parent_name_txt.Location = new System.Drawing.Point(201, 43);
            this.parent_name_txt.Name = "parent_name_txt";
            this.parent_name_txt.Size = new System.Drawing.Size(361, 26);
            this.parent_name_txt.TabIndex = 1;
            // 
            // contact_no_txt
            // 
            this.contact_no_txt.Location = new System.Drawing.Point(201, 144);
            this.contact_no_txt.Name = "contact_no_txt";
            this.contact_no_txt.Size = new System.Drawing.Size(127, 26);
            this.contact_no_txt.TabIndex = 1;
            // 
            // nic_txt
            // 
            this.nic_txt.Location = new System.Drawing.Point(201, 95);
            this.nic_txt.Name = "nic_txt";
            this.nic_txt.Size = new System.Drawing.Size(127, 26);
            this.nic_txt.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(83, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Contact Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Parent Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "NIC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tele_txt);
            this.groupBox3.Controls.Add(this.mobile_txt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.email_txt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.address_text);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(33, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 245);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // tele_txt
            // 
            this.tele_txt.Location = new System.Drawing.Point(431, 177);
            this.tele_txt.Name = "tele_txt";
            this.tele_txt.Size = new System.Drawing.Size(131, 26);
            this.tele_txt.TabIndex = 1;
            // 
            // mobile_txt
            // 
            this.mobile_txt.Location = new System.Drawing.Point(201, 177);
            this.mobile_txt.Name = "mobile_txt";
            this.mobile_txt.Size = new System.Drawing.Size(114, 26);
            this.mobile_txt.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Home Phone";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(201, 127);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(361, 26);
            this.email_txt.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mobile Phone";
            // 
            // address_text
            // 
            this.address_text.Location = new System.Drawing.Point(201, 48);
            this.address_text.Multiline = true;
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(361, 57);
            this.address_text.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_female);
            this.groupBox2.Controls.Add(this.radio_male);
            this.groupBox2.Controls.Add(this.dob_picker);
            this.groupBox2.Controls.Add(this.last_name_txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.first_name_txt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(33, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Details";
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Location = new System.Drawing.Point(318, 189);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(71, 23);
            this.radio_female.TabIndex = 3;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Female";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Location = new System.Drawing.Point(201, 189);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(58, 23);
            this.radio_male.TabIndex = 3;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Male";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // dob_picker
            // 
            this.dob_picker.Location = new System.Drawing.Point(201, 140);
            this.dob_picker.Name = "dob_picker";
            this.dob_picker.Size = new System.Drawing.Size(265, 26);
            this.dob_picker.TabIndex = 2;
            // 
            // last_name_txt
            // 
            this.last_name_txt.Location = new System.Drawing.Point(201, 88);
            this.last_name_txt.Name = "last_name_txt";
            this.last_name_txt.Size = new System.Drawing.Size(361, 26);
            this.last_name_txt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Last Name";
            // 
            // first_name_txt
            // 
            this.first_name_txt.Location = new System.Drawing.Point(201, 38);
            this.first_name_txt.Name = "first_name_txt";
            this.first_name_txt.Size = new System.Drawing.Size(361, 26);
            this.first_name_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // RegNo_combo
            // 
            this.RegNo_combo.FormattingEnabled = true;
            this.RegNo_combo.Location = new System.Drawing.Point(172, 33);
            this.RegNo_combo.Name = "RegNo_combo";
            this.RegNo_combo.Size = new System.Drawing.Size(149, 27);
            this.RegNo_combo.TabIndex = 2;
            this.RegNo_combo.SelectionChangeCommitted += new System.EventHandler(this.RegNo_combo_SelectionChangeCommitted);
            this.RegNo_combo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegNo_combo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reg No";
            // 
            // logout_link
            // 
            this.logout_link.AutoSize = true;
            this.logout_link.Location = new System.Drawing.Point(12, 9);
            this.logout_link.Name = "logout_link";
            this.logout_link.Size = new System.Drawing.Size(52, 19);
            this.logout_link.TabIndex = 2;
            this.logout_link.TabStop = true;
            this.logout_link.Text = "Logout";
            this.logout_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_link_LinkClicked);
            // 
            // exit_link
            // 
            this.exit_link.AutoSize = true;
            this.exit_link.Location = new System.Drawing.Point(676, 888);
            this.exit_link.Name = "exit_link";
            this.exit_link.Size = new System.Drawing.Size(32, 19);
            this.exit_link.TabIndex = 3;
            this.exit_link.TabStop = true;
            this.exit_link.Text = "Exit";
            this.exit_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exit_link_LinkClicked);
            // 
            // Student_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 916);
            this.Controls.Add(this.exit_link);
            this.Controls.Add(this.logout_link);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student_Registration";
            this.Text = "Student Registration - Skills International";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox parent_name_txt;
        private System.Windows.Forms.TextBox contact_no_txt;
        private System.Windows.Forms.TextBox nic_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tele_txt;
        private System.Windows.Forms.TextBox mobile_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.DateTimePicker dob_picker;
        private System.Windows.Forms.TextBox last_name_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox first_name_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RegNo_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel logout_link;
        private System.Windows.Forms.LinkLabel exit_link;
    }
}