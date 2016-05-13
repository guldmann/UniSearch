using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pcis.common;

namespace UniSearchServer
{
    public partial class FormPasswordHash : Form
    {
        public FormPasswordHash()
        {
            InitializeComponent();
        }

        private void buttonGenerateHash_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPasswordHAsh.Text = SHA256Hash.GetHashString(textBoxPassword.Text);
            }
        }

        private void buttonClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxPasswordHAsh.Text);
        }
    }
}
