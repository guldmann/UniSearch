using System.Windows.Forms;

namespace UniSearchServer
{
    partial class FormSettings
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
            this.checkedListBoxDrives = new System.Windows.Forms.CheckedListBox();
            this.groupBoxDrives = new System.Windows.Forms.GroupBox();
            this.checkBoxIndexnetdrives = new System.Windows.Forms.CheckBox();
            this.checkBoxLogIndexing = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxindexFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIndexFilePath = new System.Windows.Forms.TextBox();
            this.numericUpDownTokenGenNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxFileHasch = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxFolderFilter = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddFilter = new System.Windows.Forms.Button();
            this.textBoxAddFilter = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxDrives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTokenGenNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBoxDrives
            // 
            this.checkedListBoxDrives.CheckOnClick = true;
            this.checkedListBoxDrives.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBoxDrives.FormattingEnabled = true;
            this.checkedListBoxDrives.Location = new System.Drawing.Point(3, 27);
            this.checkedListBoxDrives.Name = "checkedListBoxDrives";
            this.checkedListBoxDrives.Size = new System.Drawing.Size(415, 498);
            this.checkedListBoxDrives.TabIndex = 0;
            this.checkedListBoxDrives.SelectedValueChanged += new System.EventHandler(this.checkedListBoxDrives_SelectedValueChanged);
            // 
            // groupBoxDrives
            // 
            this.groupBoxDrives.Controls.Add(this.checkBoxIndexnetdrives);
            this.groupBoxDrives.Controls.Add(this.checkedListBoxDrives);
            this.groupBoxDrives.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDrives.Name = "groupBoxDrives";
            this.groupBoxDrives.Size = new System.Drawing.Size(421, 603);
            this.groupBoxDrives.TabIndex = 1;
            this.groupBoxDrives.TabStop = false;
            this.groupBoxDrives.Text = "Drives";
            // 
            // checkBoxIndexnetdrives
            // 
            this.checkBoxIndexnetdrives.AutoSize = true;
            this.checkBoxIndexnetdrives.Location = new System.Drawing.Point(6, 543);
            this.checkBoxIndexnetdrives.Name = "checkBoxIndexnetdrives";
            this.checkBoxIndexnetdrives.Size = new System.Drawing.Size(193, 29);
            this.checkBoxIndexnetdrives.TabIndex = 3;
            this.checkBoxIndexnetdrives.Text = "Index Netdrives";
            this.checkBoxIndexnetdrives.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogIndexing
            // 
            this.checkBoxLogIndexing.AutoSize = true;
            this.checkBoxLogIndexing.Location = new System.Drawing.Point(455, 39);
            this.checkBoxLogIndexing.Name = "checkBoxLogIndexing";
            this.checkBoxLogIndexing.Size = new System.Drawing.Size(439, 29);
            this.checkBoxLogIndexing.TabIndex = 2;
            this.checkBoxLogIndexing.Text = "Log indexing  (slow, memory exspensive)";
            this.checkBoxLogIndexing.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Index file names:";
            // 
            // textBoxindexFileName
            // 
            this.textBoxindexFileName.Location = new System.Drawing.Point(459, 117);
            this.textBoxindexFileName.Name = "textBoxindexFileName";
            this.textBoxindexFileName.Size = new System.Drawing.Size(325, 31);
            this.textBoxindexFileName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Index file path:  (approot)";
            // 
            // textBoxIndexFilePath
            // 
            this.textBoxIndexFilePath.Location = new System.Drawing.Point(459, 190);
            this.textBoxIndexFilePath.Name = "textBoxIndexFilePath";
            this.textBoxIndexFilePath.Size = new System.Drawing.Size(329, 31);
            this.textBoxIndexFilePath.TabIndex = 6;
            // 
            // numericUpDownTokenGenNum
            // 
            this.numericUpDownTokenGenNum.Location = new System.Drawing.Point(459, 263);
            this.numericUpDownTokenGenNum.Name = "numericUpDownTokenGenNum";
            this.numericUpDownTokenGenNum.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownTokenGenNum.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Token generator num seed chars";
            // 
            // checkBoxFileHasch
            // 
            this.checkBoxFileHasch.AutoSize = true;
            this.checkBoxFileHasch.Location = new System.Drawing.Point(455, 317);
            this.checkBoxFileHasch.Name = "checkBoxFileHasch";
            this.checkBoxFileHasch.Size = new System.Drawing.Size(277, 29);
            this.checkBoxFileHasch.TabIndex = 9;
            this.checkBoxFileHasch.Text = "Use Index file checksum";
            this.checkBoxFileHasch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxFolderFilter);
            this.groupBox1.Controls.Add(this.buttonAddFilter);
            this.groupBox1.Controls.Add(this.textBoxAddFilter);
            this.groupBox1.Location = new System.Drawing.Point(455, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 263);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder index filter";
            // 
            // listBoxFolderFilter
            // 
            this.listBoxFolderFilter.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxFolderFilter.FormattingEnabled = true;
            this.listBoxFolderFilter.ItemHeight = 25;
            this.listBoxFolderFilter.Location = new System.Drawing.Point(7, 88);
            this.listBoxFolderFilter.Name = "listBoxFolderFilter";
            this.listBoxFolderFilter.Size = new System.Drawing.Size(395, 154);
            this.listBoxFolderFilter.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 42);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(185, 38);
            this.toolStripMenuItemDelete.Text = "Delete";
            // 
            // buttonAddFilter
            // 
            this.buttonAddFilter.Location = new System.Drawing.Point(318, 31);
            this.buttonAddFilter.Name = "buttonAddFilter";
            this.buttonAddFilter.Size = new System.Drawing.Size(75, 37);
            this.buttonAddFilter.TabIndex = 1;
            this.buttonAddFilter.Text = "Add";
            this.buttonAddFilter.UseVisualStyleBackColor = true;
            this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
            // 
            // textBoxAddFilter
            // 
            this.textBoxAddFilter.Location = new System.Drawing.Point(7, 31);
            this.textBoxAddFilter.Name = "textBoxAddFilter";
            this.textBoxAddFilter.Size = new System.Drawing.Size(305, 31);
            this.textBoxAddFilter.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(462, 650);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(144, 58);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(644, 650);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(144, 58);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxFileHasch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownTokenGenNum);
            this.Controls.Add(this.textBoxIndexFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxindexFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxLogIndexing);
            this.Controls.Add(this.groupBoxDrives);
            this.Name = "FormSettings";
            this.Text = "Server Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBoxDrives.ResumeLayout(false);
            this.groupBoxDrives.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTokenGenNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxDrives;
        private System.Windows.Forms.GroupBox groupBoxDrives;
        private System.Windows.Forms.CheckBox checkBoxLogIndexing;
        private System.Windows.Forms.CheckBox checkBoxIndexnetdrives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxindexFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIndexFilePath;
        private System.Windows.Forms.NumericUpDown numericUpDownTokenGenNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxFileHasch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxFolderFilter;
        private System.Windows.Forms.Button buttonAddFilter;
        private System.Windows.Forms.TextBox textBoxAddFilter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
    }
}