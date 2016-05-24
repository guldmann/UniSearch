using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Windows.Forms; 
using IndexServiceLibrary;
using Pcis.common;
using SipleLogger;


namespace UniSearchServer
{
    public partial class UniSearchServer : Form
    {
        private ServiceHost _host;
        SimpleLogger _log = new SimpleLogger();
        IndexService _indexService = new IndexService();
        

        public UniSearchServer()
        {
            InitializeComponent();                                  
            EListener(_indexService.GetLogger());
        }

        private void StatusEventListner(IndexService iService)
        {
            iService.UpdateStatusEvent += IndexService_UpdateStatusEvent;
        }

        private void IndexService_UpdateStatusEvent(IndexService iService, EventStatusBool e)
        {
            if(e.eventStatusBool)
            {
                toolStripStatusLabelIndexStatusValue.Text = "Index ready";   
            }
            else
            {
                toolStripStatusLabelIndexStatusValue.Text = "Indexing files";
            }
        }

        private void EListener(SimpleLogger simpleLogger)
        {
            simpleLogger.AddStringEvent += Log_AddStringEvent;
        }

        private void Log_AddStringEvent(SimpleLogger log, EventStrign e)
        {
          if(richTextBoxLog.InvokeRequired)
            {                
                richTextBoxLog.Invoke(new MethodInvoker(delegate { richTextBoxLog.AppendText(e.evetString + Environment.NewLine); })); 
            }
          else
            {
                richTextBoxLog.AppendText(e.evetString  + Environment.NewLine);
            }
          
        }
        
        private void startServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void StartServer()
        {
            _host = new ServiceHost(typeof(IndexService));
            _host.Credentials.ServiceCertificate.SetCertificate(StoreLocation.LocalMachine, StoreName.My, X509FindType.FindBySubjectName, "localhost");
            try
            {
                _host.Open();
                richTextBoxLog.AppendText("Server is running on : " + Environment.NewLine);
                foreach (var baseAddress in _host.BaseAddresses)
                {
                    richTextBoxLog.AppendText(baseAddress.AbsoluteUri + Environment.NewLine);
                }
                SetToolStripStatus("Online", Color.Chartreuse);

                _indexService = new IndexService();
                StatusEventListner(_indexService);
                _indexService.CreateIndex();

                if (_indexService.GetIndexStatus())
                {
                    toolStripStatusLabelIndexStatusValue.Text = "Index ready";
                }
                toolStripStatusLabelIndexStatusValue.Text = "Indexing files";
            }
            catch (CommunicationObjectFaultedException ex)
            {
                MessageBox.Show("could not start server" + Environment.NewLine + ex);
            }
            catch (Exception ex)
            {
                richTextBoxLog.AppendText(ex.Message + Environment.NewLine);
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                if (_host.State == CommunicationState.Faulted)
                {
                    _host.Abort();
                }
            }
        }

        private void SetToolStripStatus(string text, Color color)
        {
            toolStripStatusLabel1.Text = text;
            toolStripStatusLabel1.BackColor = color;
        }

        private void stopServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelIndexStatusValue.Text = "Unknown";
            toolStripStatusLabel1.Text = "Offline";
            toolStripStatusLabel1.BackColor = Color.Red;
            _host.Close();
        }

        private void toolStripStatusLabelIndexStatusValue_TextChanged(object sender, EventArgs e)
        {
            if(toolStripStatusLabelIndexStatusValue.Text == "Indexing files")
            {   
                toolStripStatusLabelIndexStatusValue.BackColor = Color.Red;              
            }
            if (toolStripStatusLabelIndexStatusValue.Text == "Index ready")
            {
                if(statusStrip2.InvokeRequired)
                {
                    statusStrip2.Invoke(new MethodInvoker(delegate { toolStripStatusLabelIndexStatusValue.BackColor = Color.Chartreuse; }));
                }
                else
                {
                    toolStripStatusLabelIndexStatusValue.BackColor = Color.Chartreuse;
                }            
               
            }
            if (toolStripStatusLabelIndexStatusValue.Text == "Unknown")
            {
                toolStripStatusLabelIndexStatusValue.BackColor = Color.Red;
         
            }
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { this.Refresh(); }));
            }
            else
            {
                this.Refresh(); 
            }
        }

        private void rebuildIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _indexService.ClearIndex();
                toolStripStatusLabelIndexStatusValue.Text = "Indexing files";
                _indexService.CreateIndex();
            }
            catch (Exception ex)
            {
                //Ignore this for now 
            }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSettings fs = new FormSettings();
            fs.ShowDialog();

            if (fs.DialogResult == DialogResult.OK)
            {
                if (_host != null)
                {
                    if (_host.State != CommunicationState.Closed)
                    {
                        _indexService.ReadSettings();
                    }
                }
                
            }
            MessageBox.Show("Depending on setting changes you might need to restart server and rebuild index");
        }

        private void restartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_host != null)
            {
                _host.Close();
                while (_host.State != CommunicationState.Closed)
                {
                    StartServer();
                }
            }
            else
            {
                StartServer();
            }
            
        }

        private void reloadLogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_indexService != null)
            {
                var serverLog = _indexService.GetLog();
                foreach (var logEntry in serverLog)
                {
                    richTextBoxLog.AppendText(logEntry + Environment.NewLine);
                }
            }
        }

        private void clearLogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_indexService != null)
            {
                _indexService.ClearLog();
            }
        }

        private void clearLogScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
        }

        private void passwordHashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPasswordHash fp = new FormPasswordHash();
            fp.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_indexService != null)
            {
                FormAddUser fau = new FormAddUser();
                fau.ShowDialog();
                if (fau.DialogResult == DialogResult.OK)
                {
                    _indexService.AddUser(fau.Username, fau.Password); 
                }
            }
        }
    }
}

