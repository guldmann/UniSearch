using System;
using System.Security.Policy;
using System.Windows.Forms;
using UniSearch.IndexServiceReference;
using System.ServiceModel;
using System.ServiceModel.Security;


namespace UniSearch
{
    public partial class FromAddServer : Form
    {
        public Server NewServer;
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
                //TODO try to start server here 
                // and find out if we can connect 
                // if we fail return message to user 
                ConnectToServer(); 




            }
            
        }

        private void ConnectToServer()
        {
            IndexServiceClient proxy = new IndexServiceClient();

            proxy.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                X509CertificateValidationMode.None;
            proxy.ClientCredentials.UserName.UserName = textBoxUserName.Text;
            proxy.ClientCredentials.UserName.Password = textBoxPassword.Text;

            String url = "net.tcp://" + textBoxURL.Text;
            if (!string.IsNullOrEmpty(textBoxPort.Text))
            {
                url += ":" + textBoxPort + "/IndexService";
            }
            else
                url += "/IndexService";
            proxy.Endpoint.Address = new EndpointAddress(new Uri(url));

            try
            {
                proxy.Open();
                proxy.GetIndexStatus();
                MessageBox.Show("Connection OK");
                proxy.Close();

            }
            catch (MessageSecurityException e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); 
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
    }
}
