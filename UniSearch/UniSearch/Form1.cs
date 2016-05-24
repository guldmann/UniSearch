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
        private List<Server> ServerList; 
     
        public Form1()
        {
            InitializeComponent();
            // TODO open server list from file "deserialize" here 
            //TODO save user (server) passwords in a password protected cryptated file ? 

            OpenServerList();

        }

        private void OpenServerList()
        {
            string ServerFile = "serverFile.bin";
            if (File.Exists(ServerFile))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(ServerFile, FileMode.Open, FileAccess.Read, FileShare.Read);
                ServerList.AddRange((List<Server>)formatter.Deserialize(stream));
                stream.Close();
            }
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


            /*

            IndexServiceClient proxy = new IndexServiceClient();
            proxy.ClientCredentials.UserName.UserName = "john"; // ändra denna 
            proxy.ClientCredentials.UserName.Password = "gopaet69";//ändra denna 
            proxy.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            */
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
                    List<IndexServiceReference.IndexFile> lst = result.OfType<IndexServiceReference.IndexFile>().ToList();
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
            //var diResult = new DialogResult(); 
            //if (resultList.Count >= 2000)
            //{
             //    diResult  = MessageBox.Show($"Found {resultList.Count} Update list will be slow {Environment.NewLine} Show result ?", "Large result warning!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning); 
           // }
           // else if(resultList.Count < 1 )
           // {
               // MessageBox.Show("Found nothing!"); 
           // }

           // if (resultList.Count <= 2000 || diResult == DialogResult.Yes )
           // {
                InitListView();
                foreach (var indexFile in resultList)
                {
                   
                    listViewResult.UseWaitCursor = true; 
                    listViewResult.BeginUpdate();
                    var item = new ListViewItem(new string[] {"", indexFile.Folderk__BackingField, indexFile.Namek__BackingField, indexFile.Extensionk__BackingField});
                    listViewResult.Items.Add(item);
                    listViewResult.EndUpdate();
                    
                    listViewResult.UseWaitCursor = false; 
                }

            //}
            //listViewResult.ListViewItemSorter = lvwColumnSorter;
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

        private void buttonNewServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            FromAddServer fas = new FromAddServer(server);
            DialogResult result = fas.ShowDialog();
            if (result == DialogResult.OK)
            {
                //TODO get server object and save adn use it  !!...  
            }




        }
    }
    
}
