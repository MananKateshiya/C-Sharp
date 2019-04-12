namespace MyApp
{
    partial class Email
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.message = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.send = new System.Windows.Forms.Button();
            this.ssl = new System.Windows.Forms.CheckBox();
            this.port = new System.Windows.Forms.TextBox();
            this.smtp = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.MaskedTextBox();
            this.uname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.message);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.subject);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.to);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 482);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(119, 182);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(529, 290);
            this.message.TabIndex = 15;
            this.message.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(22, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Message:";
            // 
            // subject
            // 
            this.subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.subject.Location = new System.Drawing.Point(119, 119);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(529, 26);
            this.subject.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Subject:";
            // 
            // cc
            // 
            this.cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cc.Location = new System.Drawing.Point(119, 79);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(529, 26);
            this.cc.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "CC:";
            // 
            // to
            // 
            this.to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.to.Location = new System.Drawing.Point(119, 40);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(529, 26);
            this.to.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "To:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.send);
            this.groupBox2.Controls.Add(this.ssl);
            this.groupBox2.Controls.Add(this.port);
            this.groupBox2.Controls.Add(this.smtp);
            this.groupBox2.Controls.Add(this.passwd);
            this.groupBox2.Controls.Add(this.uname);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 143);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Image = global::MyApp.Properties.Resources.send_32;
            this.send.Location = new System.Drawing.Point(514, 68);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(143, 65);
            this.send.TabIndex = 9;
            this.send.Text = "Send";
            this.send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // ssl
            // 
            this.ssl.AutoSize = true;
            this.ssl.Location = new System.Drawing.Point(434, 106);
            this.ssl.Name = "ssl";
            this.ssl.Size = new System.Drawing.Size(73, 29);
            this.ssl.TabIndex = 8;
            this.ssl.Text = "SSL";
            this.ssl.UseVisualStyleBackColor = true;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(434, 70);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(64, 30);
            this.port.TabIndex = 7;
            this.port.Text = "587";
            // 
            // smtp
            // 
            this.smtp.Location = new System.Drawing.Point(434, 23);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(223, 30);
            this.smtp.TabIndex = 6;
            this.smtp.Text = "smtp.gmail.com";
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(135, 85);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(223, 30);
            this.passwd.TabIndex = 5;
            this.passwd.UseSystemPasswordChar = true;
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(135, 23);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(223, 30);
            this.uname.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Smtp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username:";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Email";
            this.Size = new System.Drawing.Size(698, 634);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox smtp;
        private System.Windows.Forms.MaskedTextBox passwd;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ssl;
        private System.Windows.Forms.Button send;
    }
}
