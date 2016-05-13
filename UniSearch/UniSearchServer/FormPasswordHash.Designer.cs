namespace UniSearchServer
{
    partial class FormPasswordHash
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordHAsh = new System.Windows.Forms.TextBox();
            this.labelPasswordHash = new System.Windows.Forms.Label();
            this.buttonGenerateHash = new System.Windows.Forms.Button();
            this.buttonClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(13, 13);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 33);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(320, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxPasswordHAsh
            // 
            this.textBoxPasswordHAsh.Location = new System.Drawing.Point(12, 79);
            this.textBoxPasswordHAsh.Name = "textBoxPasswordHAsh";
            this.textBoxPasswordHAsh.Size = new System.Drawing.Size(320, 22);
            this.textBoxPasswordHAsh.TabIndex = 2;
            // 
            // labelPasswordHash
            // 
            this.labelPasswordHash.AutoSize = true;
            this.labelPasswordHash.Location = new System.Drawing.Point(13, 59);
            this.labelPasswordHash.Name = "labelPasswordHash";
            this.labelPasswordHash.Size = new System.Drawing.Size(41, 17);
            this.labelPasswordHash.TabIndex = 3;
            this.labelPasswordHash.Text = "Hash";
            // 
            // buttonGenerateHash
            // 
            this.buttonGenerateHash.Location = new System.Drawing.Point(16, 120);
            this.buttonGenerateHash.Name = "buttonGenerateHash";
            this.buttonGenerateHash.Size = new System.Drawing.Size(113, 27);
            this.buttonGenerateHash.TabIndex = 4;
            this.buttonGenerateHash.Text = "Generate hash";
            this.buttonGenerateHash.UseVisualStyleBackColor = true;
            this.buttonGenerateHash.Click += new System.EventHandler(this.buttonGenerateHash_Click);
            // 
            // buttonClipboard
            // 
            this.buttonClipboard.Location = new System.Drawing.Point(201, 120);
            this.buttonClipboard.Name = "buttonClipboard";
            this.buttonClipboard.Size = new System.Drawing.Size(131, 27);
            this.buttonClipboard.TabIndex = 5;
            this.buttonClipboard.Text = "Copy to Clipboard";
            this.buttonClipboard.UseVisualStyleBackColor = true;
            this.buttonClipboard.Click += new System.EventHandler(this.buttonClipboard_Click);
            // 
            // FormPasswordHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 172);
            this.Controls.Add(this.buttonClipboard);
            this.Controls.Add(this.buttonGenerateHash);
            this.Controls.Add(this.labelPasswordHash);
            this.Controls.Add(this.textBoxPasswordHAsh);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Name = "FormPasswordHash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password hash generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPasswordHAsh;
        private System.Windows.Forms.Label labelPasswordHash;
        private System.Windows.Forms.Button buttonGenerateHash;
        private System.Windows.Forms.Button buttonClipboard;
    }
}