using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Windows.Forms;
using System.Threading;
using UniSearch.IndexServiceReference;
using System.Runtime.Serialization.Formatters.Binary;
using IFormatter = System.Runtime.Serialization.IFormatter;
using Pcis.common;
using System.Runtime.Serialization;

namespace UniSearch
{
    public partial class Form1 : Form
    {
        private List<Server> ServerList = new List<Server>();

        public Form1()
        {
            InitializeComponent();

            //TODO save user (server) passwords in a password protected cryptated file ? 
            OpenServerList();
            UpdateGuiServerList();


        }

        

        private void UpdateGuiServerList()
        {
            //comboBox1.Items.Clear();
            comboBox1.DataSource = ServerList;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";


            listBoxServerList.Items.Clear();
            if (ServerList.Count < 1)
            {
                listBoxServerList.Items.Add("Add a Server");
                listBoxServerList.Text = "Add a server ";
            }
            if (ServerList.Count > 1)
            {
                listBoxServerList.Items.Add("All servers");
            }
            if (ServerList.Count >= 1)
            {
                foreach (var server in ServerList)
                {
                    listBoxServerList.Items.Add(server.name);
                }
            }
        }

        private bool OpenServerList()
        {
            //TODO Add function to password protect file 
            //And function to use password to open file 
            string ServerFile = "serverFile.bin";
            if (File.Exists(ServerFile))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(ServerFile, FileMode.Open, FileAccess.Read, FileShare.Read);
                ServerList.AddRange((List<Server>) formatter.Deserialize(stream));
                stream.Close();
                return true;
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Search_KeyUpEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (textBoxName.Focused || textBoxExtension.Focused || button1.Focused)
                {
                    button1_Click(null, null);
                }
            }
            if (e.KeyData == Keys.Down)
            {
                listViewResult.Focus();
            }
            if (e.KeyData == Keys.Up)
            {
                if (listViewResult.FocusedItem.Index == 0)
                {
                    textBoxName.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO :  add this to a list 
            Server server = new Server
            {
                name = "localhost",
                port = "808",
                userName = "admin",
                passWord = "somepass",
                url = "net.tcp://localhost/IndexService" /// dela upp denna strängen 
            };

            IndexServiceClient proxy = new IndexServiceClient();

            proxy.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                X509CertificateValidationMode.None;
            proxy.ClientCredentials.UserName.UserName = server.userName;
            proxy.ClientCredentials.UserName.Password = server.passWord;

            proxy.Endpoint.Address = new EndpointAddress(new Uri(server.url));
            try
            {
                proxy.Open();
                if (!proxy.GetIndexStatus())
                {
                    MessageBox.Show("Server is not ready");
                }
                else
                {
                    var startTime = DateTime.Now;
                    var result = proxy.Search(textBoxName.Text, textBoxExtension.Text);
                    List<IndexServiceReference.IndexFile> lst =
                        result.OfType<IndexServiceReference.IndexFile>().ToList();
                    var resultTime = (DateTime.Now - startTime);
                    labelSearchTimeValue.Text = resultTime.TotalMilliseconds + "millisec";
                    PopulateListView(lst);
                    labelFilesValue.Text = lst.Count.ToString();
                }

                proxy.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        private void PopulateListView(List<IndexServiceReference.IndexFile> resultList)
        {
            InitListView();
            foreach (var indexFile in resultList)
            {
                listViewResult.UseWaitCursor = true;
                listViewResult.BeginUpdate();
                var item =
                    new ListViewItem(new string[]
                    {
                        "", indexFile.Folderk__BackingField, indexFile.Namek__BackingField,
                        indexFile.Extensionk__BackingField
                    });
                listViewResult.Items.Add(item);
                listViewResult.EndUpdate();

                listViewResult.UseWaitCursor = false;
            }
        }

    private void InitListView()
        {
            listViewResult.Clear();
            listViewResult.View = View.Details;
            listViewResult.GridLines = true;
            listViewResult.FullRowSelect = true;
            //listViewResult.ListViewItemSorter = null; 

            //Add columns 
            listViewResult.Columns.Add("icon", 50);
            listViewResult.Columns.Add("path", 150);
            listViewResult.Columns.Add("Name", 150);
            listViewResult.Columns.Add("Extension", 70);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBoxName.Focus();
        }

        private void listViewResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Process.Start(listViewResult.SelectedItems[0].SubItems[1].Text + "\\" + listViewResult.SelectedItems[0].SubItems[2].Text);
            }
        }

        private void listViewResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start(listViewResult.SelectedItems[0].SubItems[1].Text + "\\" + listViewResult.SelectedItems[0].SubItems[2].Text);
        }

        private bool SaveServerList()
        {
            string ServerFile = "serverFile.bin";
            if (File.Exists(ServerFile))
            {
                File.Delete(ServerFile);
            }
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(ServerFile, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, ServerList);
                stream.Close();
                return true;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void buttonNewServer_Click(object sender, EventArgs e)
        {
            FromAddServer fas = new FromAddServer();
            DialogResult result = fas.ShowDialog();
            if (result == DialogResult.OK)
            {
                ServerList.Add(fas.NewServer);
                SaveServerList();
                UpdateGuiServerList();
            }
            fas.Dispose();
        }

        private void buttonServerListDelete_Click(object sender, EventArgs e)
        {
            ServerList.RemoveAll(x => x.name == listBoxServerList.SelectedItem.ToString());
            
            SaveServerList();
            UpdateGuiServerList();
        }
    }
}
