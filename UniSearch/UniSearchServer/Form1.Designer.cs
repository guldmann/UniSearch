namespace UniSearchServer
{
    partial class UniSearchServer
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
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelIndexStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelIndexStatusValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadLogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 44);
            this.richTextBoxLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(1454, 978);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelIndexStatus,
            this.toolStripStatusLabelIndexStatusValue});
            this.statusStrip2.Location = new System.Drawing.Point(0, 1022);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip2.Size = new System.Drawing.Size(1454, 37);
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 32);
            this.toolStripStatusLabel1.Text = "Stopped";
            // 
            // toolStripStatusLabelIndexStatus
            // 
            this.toolStripStatusLabelIndexStatus.Name = "toolStripStatusLabelIndexStatus";
            this.toolStripStatusLabelIndexStatus.Size = new System.Drawing.Size(156, 32);
            this.toolStripStatusLabelIndexStatus.Text = "Index Status: ";
            // 
            // toolStripStatusLabelIndexStatusValue
            // 
            this.toolStripStatusLabelIndexStatusValue.Name = "toolStripStatusLabelIndexStatusValue";
            this.toolStripStatusLabelIndexStatusValue.Size = new System.Drawing.Size(112, 32);
            this.toolStripStatusLabelIndexStatusValue.Text = "No index";
            this.toolStripStatusLabelIndexStatusValue.TextChanged += new System.EventHandler(this.toolStripStatusLabelIndexStatusValue_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.logToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1454, 44);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServerToolStripMenuItem,
            this.stopServerToolStripMenuItem,
            this.restartToolStripMenuItem1,
            this.generatePasswordToolStripMenuItem,
            this.rebuildIndexToolStripMenuItem,
            this.settingsToolStripMenuItem1});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(103, 38);
            this.startToolStripMenuItem.Text = "System";
            // 
            // startServerToolStripMenuItem
            // 
            this.startServerToolStripMenuItem.Name = "startServerToolStripMenuItem";
            this.startServerToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.startServerToolStripMenuItem.Text = "Start server";
            this.startServerToolStripMenuItem.Click += new System.EventHandler(this.startServerToolStripMenuItem_Click);
            // 
            // stopServerToolStripMenuItem
            // 
            this.stopServerToolStripMenuItem.Name = "stopServerToolStripMenuItem";
            this.stopServerToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.stopServerToolStripMenuItem.Text = "Stop Server";
            this.stopServerToolStripMenuItem.Click += new System.EventHandler(this.stopServerToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem1
            // 
            this.restartToolStripMenuItem1.Name = "restartToolStripMenuItem1";
            this.restartToolStripMenuItem1.Size = new System.Drawing.Size(272, 38);
            this.restartToolStripMenuItem1.Text = "Restart server";
            this.restartToolStripMenuItem1.Click += new System.EventHandler(this.restartToolStripMenuItem1_Click);
            // 
            // generatePasswordToolStripMenuItem
            // 
            this.generatePasswordToolStripMenuItem.Name = "generatePasswordToolStripMenuItem";
            this.generatePasswordToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.generatePasswordToolStripMenuItem.Text = "Password Hash";
            // 
            // rebuildIndexToolStripMenuItem
            // 
            this.rebuildIndexToolStripMenuItem.Name = "rebuildIndexToolStripMenuItem";
            this.rebuildIndexToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.rebuildIndexToolStripMenuItem.Text = "Rebuild index";
            this.rebuildIndexToolStripMenuItem.Click += new System.EventHandler(this.rebuildIndexToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(272, 38);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadLogToolStripMenuItem1,
            this.clearLogScreenToolStripMenuItem,
            this.clearLogToolStripMenuItem1});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(66, 38);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // reloadLogToolStripMenuItem1
            // 
            this.reloadLogToolStripMenuItem1.Name = "reloadLogToolStripMenuItem1";
            this.reloadLogToolStripMenuItem1.Size = new System.Drawing.Size(286, 38);
            this.reloadLogToolStripMenuItem1.Text = "Reload Log";
            this.reloadLogToolStripMenuItem1.Click += new System.EventHandler(this.reloadLogToolStripMenuItem1_Click);
            // 
            // clearLogScreenToolStripMenuItem
            // 
            this.clearLogScreenToolStripMenuItem.Name = "clearLogScreenToolStripMenuItem";
            this.clearLogScreenToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.clearLogScreenToolStripMenuItem.Text = "Clear log screen";
            this.clearLogScreenToolStripMenuItem.Click += new System.EventHandler(this.clearLogScreenToolStripMenuItem_Click);
            // 
            // clearLogToolStripMenuItem1
            // 
            this.clearLogToolStripMenuItem1.Name = "clearLogToolStripMenuItem1";
            this.clearLogToolStripMenuItem1.Size = new System.Drawing.Size(286, 38);
            this.clearLogToolStripMenuItem1.Text = "Clear log";
            this.clearLogToolStripMenuItem1.Click += new System.EventHandler(this.clearLogToolStripMenuItem1_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.passwordHashToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(84, 38);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // passwordHashToolStripMenuItem
            // 
            this.passwordHashToolStripMenuItem.Name = "passwordHashToolStripMenuItem";
            this.passwordHashToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.passwordHashToolStripMenuItem.Text = "Password hash";
            this.passwordHashToolStripMenuItem.Click += new System.EventHandler(this.passwordHashToolStripMenuItem_Click);
            // 
            // UniSearchServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 1059);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UniSearchServer";
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelIndexStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelIndexStatusValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebuildIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadLogToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearLogScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordHashToolStripMenuItem;
    }
}

