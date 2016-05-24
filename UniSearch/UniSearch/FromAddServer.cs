using System;
using System.Security.Policy;
using System.Windows.Forms;
using UniSearch.IndexServiceReference;
using System.ServiceModel;
using System.ServiceModel.Security;
using Pcis.common;


namespace UniSearch
{
    public partial class FromAddServer : Form
    {
        public Server NewServer = new Server();
        public FromAddServer()
        {
            InitializeComponent();
        }

        public FromAddServer(Server server) : this()
        {
            NewServer = server;
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ConnectToServer();
            }
        }

        private void ConnectToServer()
        {
            //default ports
            string NETport = "808";
            

            if (!string.IsNullOrEmpty(textBoxNetTcpPort.Text))
            {
                NETport = textBoxNetTcpPort.Text;
            }

            IndexServiceClient proxy = new IndexServiceClient();

            proxy.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                X509CertificateValidationMode.None;
            proxy.ClientCredentials.UserName.UserName = textBoxUserName.Text;
            proxy.ClientCredentials.UserName.Password = textBoxPassword.Text;

            string NETUrl = "net.tcp://" + textBoxURL.Text + ":" + NETport + "/IndexService";

            string dnsIdentity = null; // use localhost for test certificate 
            if (!string.IsNullOrEmpty(textBoxCertDomain.Text))
            {
                dnsIdentity = textBoxCertDomain.Text;
            }
            else
            {
                dnsIdentity = textBoxURL.Text;
            }

            EndpointIdentity identity = EndpointIdentity.CreateDnsIdentity(dnsIdentity);
            proxy.Endpoint.Address = new EndpointAddress(new Uri(NETUrl), identity);

            try
            {
                proxy.Open();
                proxy.GetIndexStatus();
                MessageBox.Show("Connection OK.");
                proxy.Close();

            }
            catch (Exception e)
            {
                if (e.InnerException != null)
                {
                    MessageBox.Show(e.InnerException.Message + Environment.NewLine + e.Message);
                }
                else
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(textBoxServerName.Text))
            {
                toolTip1.Show("This can't be empty " + Environment.NewLine + "Enter server name", textBoxServerName, 1500);
                textBoxServerName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxURL.Text))
            {
                toolTip1.Show("This can't be empty " + Environment.NewLine + "Enter server name", textBoxURL, 1500);
                textBoxURL.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                toolTip1.Show("This can't be empty " + Environment.NewLine + "Enter server name", textBoxUserName, 1500);
                textBoxUserName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                toolTip1.Show("This can't be empty " + Environment.NewLine + "Enter server name", textBoxPassword, 1500);
                textBoxPassword.Focus();
                return false;
            }
            return true; 
        }

        private void textBoxCertDomain_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter domain name or computer name  " + Environment.NewLine + "in server certificate", textBoxCertDomain, 3000);
        }

        private void buttonSaveServer_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                NewServer = new Server
                {
                    name = textBoxServerName.Text,
                    url = textBoxURL.Text, 
                    userName = textBoxUserName.Text
                };
                if (!string.IsNullOrEmpty(textBoxCertDomain.Text))
                {
                    NewServer.dnsItentity = textBoxCertDomain.Text;
                }
                else
                {
                    NewServer.dnsItentity = NewServer.url;
                }
                if (!string.IsNullOrEmpty(textBoxNetTcpPort.Text))
                {
                    NewServer.port = textBoxNetTcpPort.Text;
                }
                if (checkBoxLocal.Checked)
                {
                    NewServer.localserver = true;
                }
                if (checkBoxSavePassWord.Checked)
                {
                    NewServer.passWord = textBoxPassword.Text; 
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
