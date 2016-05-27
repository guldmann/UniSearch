namespace UniSearch
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSearchTimeValue = new System.Windows.Forms.Label();
            this.labelSearchTime = new System.Windows.Forms.Label();
            this.labelFilesValue = new System.Windows.Forms.Label();
            this.labelFiles = new System.Windows.Forms.Label();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vbnmvbmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxServerList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNewServer = new System.Windows.Forms.Button();
            this.buttonEditServer = new System.Windows.Forms.Button();
            this.buttonServerListDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 880);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1266, 563);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(14, 39);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(445, 31);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_KeyUpEnter);
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(466, 39);
            this.textBoxExtension.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(133, 31);
            this.textBoxExtension.TabIndex = 5;
            this.textBoxExtension.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_KeyUpEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSearchTimeValue);
            this.groupBox1.Controls.Add(this.labelSearchTime);
            this.groupBox1.Controls.Add(this.labelFilesValue);
            this.groupBox1.Controls.Add(this.labelFiles);
            this.groupBox1.Location = new System.Drawing.Point(728, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(592, 122);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index";
            // 
            // labelSearchTimeValue
            // 
            this.labelSearchTimeValue.AutoSize = true;
            this.labelSearchTimeValue.Location = new System.Drawing.Point(272, 78);
            this.labelSearchTimeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchTimeValue.Name = "labelSearchTimeValue";
            this.labelSearchTimeValue.Size = new System.Drawing.Size(24, 25);
            this.labelSearchTimeValue.TabIndex = 3;
            this.labelSearchTimeValue.Text = "0";
            // 
            // labelSearchTime
            // 
            this.labelSearchTime.AutoSize = true;
            this.labelSearchTime.Location = new System.Drawing.Point(124, 78);
            this.labelSearchTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchTime.Name = "labelSearchTime";
            this.labelSearchTime.Size = new System.Drawing.Size(139, 25);
            this.labelSearchTime.TabIndex = 2;
            this.labelSearchTime.Text = "Search Time:";
            // 
            // labelFilesValue
            // 
            this.labelFilesValue.AutoSize = true;
            this.labelFilesValue.Location = new System.Drawing.Point(272, 34);
            this.labelFilesValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilesValue.Name = "labelFilesValue";
            this.labelFilesValue.Size = new System.Drawing.Size(24, 25);
            this.labelFilesValue.TabIndex = 1;
            this.labelFilesValue.Text = "0";
            // 
            // labelFiles
            // 
            this.labelFiles.AutoSize = true;
            this.labelFiles.Location = new System.Drawing.Point(62, 34);
            this.labelFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(204, 25);
            this.labelFiles.TabIndex = 0;
            this.labelFiles.Text = "Search found Files: ";
            // 
            // listViewResult
            // 
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.path,
            this.name,
            this.extension});
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.GridLines = true;
            this.listViewResult.HoverSelection = true;
            this.listViewResult.Location = new System.Drawing.Point(-11, 284);
            this.listViewResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewResult.MultiSelect = false;
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(1306, 716);
            this.listViewResult.TabIndex = 10;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            this.listViewResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewResult_KeyDown);
            this.listViewResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_KeyUpEnter);
            this.listViewResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewResult_MouseDoubleClick);
            // 
            // path
            // 
            this.path.Text = "Path";
            this.path.Width = 96;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 87;
            // 
            // extension
            // 
            this.extension.Text = "Extension";
            this.extension.Width = 95;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.vbnmvbmToolStripMenuItem});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(224, 80);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(223, 38);
            this.testToolStripMenuItem.Text = "test";
            // 
            // vbnmvbmToolStripMenuItem
            // 
            this.vbnmvbmToolStripMenuItem.Name = "vbnmvbmToolStripMenuItem";
            this.vbnmvbmToolStripMenuItem.Size = new System.Drawing.Size(223, 38);
            this.vbnmvbmToolStripMenuItem.Text = "vbnmvbm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "File name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Extension:";
            // 
            // listBoxServerList
            // 
            this.listBoxServerList.FormattingEnabled = true;
            this.listBoxServerList.ItemHeight = 25;
            this.listBoxServerList.Location = new System.Drawing.Point(14, 103);
            this.listBoxServerList.Name = "listBoxServerList";
            this.listBoxServerList.Size = new System.Drawing.Size(318, 54);
            this.listBoxServerList.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Index Server";
            // 
            // buttonNewServer
            // 
            this.buttonNewServer.Location = new System.Drawing.Point(339, 116);
            this.buttonNewServer.Name = "buttonNewServer";
            this.buttonNewServer.Size = new System.Drawing.Size(75, 42);
            this.buttonNewServer.TabIndex = 16;
            this.buttonNewServer.Text = "New";
            this.buttonNewServer.UseVisualStyleBackColor = true;
            this.buttonNewServer.Click += new System.EventHandler(this.buttonNewServer_Click);
            // 
            // buttonEditServer
            // 
            this.buttonEditServer.Location = new System.Drawing.Point(420, 116);
            this.buttonEditServer.Name = "buttonEditServer";
            this.buttonEditServer.Size = new System.Drawing.Size(75, 42);
            this.buttonEditServer.TabIndex = 17;
            this.buttonEditServer.Text = "Edit";
            this.buttonEditServer.UseVisualStyleBackColor = true;
            // 
            // buttonServerListDelete
            // 
            this.buttonServerListDelete.Location = new System.Drawing.Point(516, 116);
            this.buttonServerListDelete.Name = "buttonServerListDelete";
            this.buttonServerListDelete.Size = new System.Drawing.Size(75, 40);
            this.buttonServerListDelete.TabIndex = 18;
            this.buttonServerListDelete.Text = "Delete";
            this.buttonServerListDelete.UseVisualStyleBackColor = true;
            this.buttonServerListDelete.Click += new System.EventHandler(this.buttonServerListDelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 1431);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonServerListDelete);
            this.Controls.Add(this.buttonEditServer);
            this.Controls.Add(this.buttonNewServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxServerList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "UniSearch";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSearchTimeValue;
        private System.Windows.Forms.Label labelSearchTime;
        private System.Windows.Forms.Label labelFilesValue;
        private System.Windows.Forms.Label labelFiles;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader extension;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vbnmvbmToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxServerList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNewServer;
        private System.Windows.Forms.Button buttonEditServer;
        private System.Windows.Forms.Button buttonServerListDelete;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

