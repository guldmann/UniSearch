namespace UniSearch
{
    partial class FromAddServer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxSavePassWord = new System.Windows.Forms.CheckBox();
            this.buttonSaveServer = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxNetTcpPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCertDomain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(147, 27);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(294, 31);
            this.textBoxServerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ip or Domain:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(147, 73);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(294, 31);
            this.textBoxURL.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "User name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(147, 208);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(294, 31);
            this.textBoxUserName.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(147, 254);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(294, 31);
            this.textBoxPassword.TabIndex = 10;
            // 
            // checkBoxSavePassWord
            // 
            this.checkBoxSavePassWord.AutoSize = true;
            this.checkBoxSavePassWord.Location = new System.Drawing.Point(147, 297);
            this.checkBoxSavePassWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSavePassWord.Name = "checkBoxSavePassWord";
            this.checkBoxSavePassWord.Size = new System.Drawing.Size(191, 29);
            this.checkBoxSavePassWord.TabIndex = 11;
            this.checkBoxSavePassWord.Text = "Save password";
            this.checkBoxSavePassWord.UseVisualStyleBackColor = true;
            // 
            // buttonSaveServer
            // 
            this.buttonSaveServer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveServer.Location = new System.Drawing.Point(147, 453);
            this.buttonSaveServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveServer.Name = "buttonSaveServer";
            this.buttonSaveServer.Size = new System.Drawing.Size(112, 36);
            this.buttonSaveServer.TabIndex = 12;
            this.buttonSaveServer.Text = "Save";
            this.buttonSaveServer.UseVisualStyleBackColor = true;
            this.buttonSaveServer.Click += new System.EventHandler(this.buttonSaveServer_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(330, 453);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 36);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(147, 381);
            this.buttonTestConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(296, 36);
            this.buttonTestConnection.TabIndex = 14;
            this.buttonTestConnection.Text = "Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // textBoxNetTcpPort
            // 
            this.textBoxNetTcpPort.Location = new System.Drawing.Point(148, 162);
            this.textBoxNetTcpPort.Name = "textBoxNetTcpPort";
            this.textBoxNetTcpPort.Size = new System.Drawing.Size(294, 31);
            this.textBoxNetTcpPort.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Net TCP Port:";
            // 
            // textBoxCertDomain
            // 
            this.textBoxCertDomain.Location = new System.Drawing.Point(146, 118);
            this.textBoxCertDomain.Name = "textBoxCertDomain";
            this.textBoxCertDomain.Size = new System.Drawing.Size(294, 31);
            this.textBoxCertDomain.TabIndex = 18;
            this.textBoxCertDomain.MouseHover += new System.EventHandler(this.textBoxCertDomain_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cert domain:";
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.AutoSize = true;
            this.checkBoxLocal.Location = new System.Drawing.Point(148, 334);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.Size = new System.Drawing.Size(245, 29);
            this.checkBoxLocal.TabIndex = 19;
            this.checkBoxLocal.Text = "Server is on local PC";
            this.checkBoxLocal.UseVisualStyleBackColor = true;
            // 
            // FromAddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 508);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxLocal);
            this.Controls.Add(this.textBoxCertDomain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNetTcpPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonTestConnection);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveServer);
            this.Controls.Add(this.checkBoxSavePassWord);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxServerName);
            this.Controls.Add(this.label1);
            this.Name = "FromAddServer";
            this.Text = "Add/Edit server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxSavePassWord;
        private System.Windows.Forms.Button buttonSaveServer;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxNetTcpPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCertDomain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxLocal;
    }
}