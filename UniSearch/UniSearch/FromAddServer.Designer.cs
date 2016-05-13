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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxSavePassWord = new System.Windows.Forms.CheckBox();
            this.buttonSaveServer = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(98, 17);
            this.textBoxServerName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(197, 22);
            this.textBoxServerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ip or Domain:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(98, 51);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(197, 22);
            this.textBoxURL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(98, 86);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(197, 22);
            this.textBoxPort.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "User name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(98, 121);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(197, 22);
            this.textBoxUserName.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(98, 157);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(197, 22);
            this.textBoxPassword.TabIndex = 10;
            // 
            // checkBoxSavePassWord
            // 
            this.checkBoxSavePassWord.AutoSize = true;
            this.checkBoxSavePassWord.Location = new System.Drawing.Point(98, 184);
            this.checkBoxSavePassWord.Name = "checkBoxSavePassWord";
            this.checkBoxSavePassWord.Size = new System.Drawing.Size(126, 21);
            this.checkBoxSavePassWord.TabIndex = 11;
            this.checkBoxSavePassWord.Text = "Save password";
            this.checkBoxSavePassWord.UseVisualStyleBackColor = true;
            // 
            // buttonSaveServer
            // 
            this.buttonSaveServer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveServer.Location = new System.Drawing.Point(98, 290);
            this.buttonSaveServer.Name = "buttonSaveServer";
            this.buttonSaveServer.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveServer.TabIndex = 12;
            this.buttonSaveServer.Text = "Save";
            this.buttonSaveServer.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(220, 290);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(98, 211);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(197, 23);
            this.buttonTestConnection.TabIndex = 14;
            this.buttonTestConnection.Text = "Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // FromAddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 325);
            this.ControlBox = false;
            this.Controls.Add(this.buttonTestConnection);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveServer);
            this.Controls.Add(this.checkBoxSavePassWord);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxServerName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxSavePassWord;
        private System.Windows.Forms.Button buttonSaveServer;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}