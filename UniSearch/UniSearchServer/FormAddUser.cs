using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniSearchServer
{
    public partial class FormAddUser : Form
    {
        public string Username = "";
        public string Password = "";

        public FormAddUser()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Username = textBoxUserName.Text;
                Password = textBoxPassword.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                MessageBox.Show("Enter a username");
                textBoxUserName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Enter a password");
                textBoxPassword.Focus();
                return false;
            }
            return true;
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
