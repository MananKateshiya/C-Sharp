namespace MyApp
{
    partial class LanChat
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
            this.local2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.remotePort = new System.Windows.Forms.TextBox();
            this.remoteIP = new System.Windows.Forms.TextBox();
            this.local = new System.Windows.Forms.GroupBox();
            this.localPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.localIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.listMsg = new System.Windows.Forms.ListBox();
            this.local2.SuspendLayout();
            this.local.SuspendLayout();
            this.SuspendLayout();
            // 
            // local2
            // 
            this.local2.Controls.Add(this.remotePort);
            this.local2.Controls.Add(this.label3);
            this.local2.Controls.Add(this.remoteIP);
            this.local2.Controls.Add(this.label4);
            this.local2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.local2.ForeColor = System.Drawing.Color.White;
            this.local2.Location = new System.Drawing.Point(370, 18);
            this.local2.Name = "local2";
            this.local2.Size = new System.Drawing.Size(296, 144);
            this.local2.TabIndex = 1;
            this.local2.TabStop = false;
            this.local2.Text = "Friend";
            this.local2.Enter += new System.EventHandler(this.local2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(25, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP:";
            // 
            // remotePort
            // 
            this.remotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.remotePort.Location = new System.Drawing.Point(93, 87);
            this.remotePort.Name = "remotePort";
            this.remotePort.Size = new System.Drawing.Size(177, 30);
            this.remotePort.TabIndex = 5;
            // 
            // remoteIP
            // 
            this.remoteIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.remoteIP.Location = new System.Drawing.Point(93, 27);
            this.remoteIP.Name = "remoteIP";
            this.remoteIP.Size = new System.Drawing.Size(177, 30);
            this.remoteIP.TabIndex = 4;
            // 
            // local
            // 
            this.local.Controls.Add(this.localPort);
            this.local.Controls.Add(this.label1);
            this.local.Controls.Add(this.localIP);
            this.local.Controls.Add(this.label2);
            this.local.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.local.ForeColor = System.Drawing.Color.White;
            this.local.Location = new System.Drawing.Point(24, 18);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(296, 144);
            this.local.TabIndex = 6;
            this.local.TabStop = false;
            this.local.Text = "User";
            // 
            // localPort
            // 
            this.localPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.localPort.Location = new System.Drawing.Point(93, 87);
            this.localPort.Name = "localPort";
            this.localPort.Size = new System.Drawing.Size(177, 30);
            this.localPort.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(28, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port:";
            // 
            // localIP
            // 
            this.localIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.localIP.Location = new System.Drawing.Point(93, 27);
            this.localIP.Name = "localIP";
            this.localIP.Size = new System.Drawing.Size(177, 30);
            this.localIP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP:";
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.message.Location = new System.Drawing.Point(24, 579);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(490, 30);
            this.message.TabIndex = 6;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Image = global::MyApp.Properties.Resources.send_32;
            this.send.Location = new System.Drawing.Point(523, 568);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(143, 52);
            this.send.TabIndex = 10;
            this.send.Text = "Send";
            this.send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.LimeGreen;
            this.connect.FlatAppearance.BorderSize = 0;
            this.connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.connect.ForeColor = System.Drawing.Color.White;
            this.connect.Image = global::MyApp.Properties.Resources.connect_32;
            this.connect.Location = new System.Drawing.Point(263, 177);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(167, 39);
            this.connect.TabIndex = 9;
            this.connect.Text = "Connect";
            this.connect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // listMsg
            // 
            this.listMsg.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMsg.FormattingEnabled = true;
            this.listMsg.ItemHeight = 27;
            this.listMsg.Location = new System.Drawing.Point(24, 233);
            this.listMsg.Name = "listMsg";
            this.listMsg.Size = new System.Drawing.Size(642, 301);
            this.listMsg.TabIndex = 11;
            // 
            // LanChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.listMsg);
            this.Controls.Add(this.send);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.message);
            this.Controls.Add(this.local);
            this.Controls.Add(this.local2);
            this.Name = "LanChat";
            this.Size = new System.Drawing.Size(698, 634);
            this.Load += new System.EventHandler(this.LanChat_Load);
            this.local2.ResumeLayout(false);
            this.local2.PerformLayout();
            this.local.ResumeLayout(false);
            this.local.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox local2;
        private System.Windows.Forms.TextBox remotePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remoteIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox local;
        private System.Windows.Forms.TextBox localPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox localIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ListBox listMsg;
    }
}
