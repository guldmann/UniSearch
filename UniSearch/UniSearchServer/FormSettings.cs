using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Pcis.common;

namespace UniSearchServer
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadSettingsToGUI();
        }

        private void LoadSettingsToGUI()
        {
            DriveSettings();
            IndexFileNames();
            IndexFilePath();
            TokenNum();
            CheckSum();
            LogIndexing();
            FolderFilter();
        }

        private void FolderFilter()
        {
            object[] key = ConfigurationManager.AppSettings["filter"].Split(',');
            listBoxFolderFilter.Items.AddRange(key);
        }

        private void LogIndexing()
        {
            var key = ConfigurationManager.AppSettings["logindexing"];
            if (key == "true")
            {
                checkBoxLogIndexing.CheckState = CheckState.Checked;
            }
        }

        private void CheckSum()
        {
            var key = ConfigurationManager.AppSettings["usemd5"];
            if (key == "true")
            {
                checkBoxFileHasch.CheckState = CheckState.Checked;
            }
            
        }

        private void TokenNum()
        {
            int value = 0;
            if (int.TryParse(ConfigurationManager.AppSettings["tokengennum"], out value))
            {
                numericUpDownTokenGenNum.Value = value;
            } 
            
        }

        private void IndexFilePath()
        {
            var key = ConfigurationManager.AppSettings["indexfilepath"];
            textBoxIndexFilePath.Text = key;
        }

        private void IndexFileNames()
        {
            var key = ConfigurationManager.AppSettings["indexfilename"];
            textBoxindexFileName.Text = key;
        }

        private void DriveSettings()
        {
            var key = ConfigurationManager.AppSettings["Drives"].Replace(" ", string.Empty);
            var settingDriveValue = key.ToUpper().Split(',');
            var systemDrives = DriveInfo.GetDrives();

            var useNetDrive = ConfigurationManager.AppSettings["netdrives"]; 
            if(useNetDrive == "true") checkBoxIndexnetdrives.CheckState = CheckState.Checked;
           

            int itemsCounter = 0;

            checkedListBoxDrives.Items.Add("All");

            if (settingDriveValue[0].ToUpper() == "ALL")
            {
                checkedListBoxDrives.SetItemChecked(itemsCounter, true);
            }

            foreach (var drive in systemDrives)
            {
                checkedListBoxDrives.Items.Add(drive.Name + " [" + drive.DriveType + "]");
                itemsCounter++;
                if (settingDriveValue.Contains(drive.Name.ToUpper()))
                {
                    checkedListBoxDrives.SetItemChecked(itemsCounter, true);
                }
            }
        }

        private void SaveSettings()
        {
            //TODO add save settings stuff here 
            this.Close();
        }

        private void checkedListBoxDrives_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkedListBoxDrives.SelectedIndex == 0)
            {
                if (checkedListBoxDrives.GetItemCheckState(0) == CheckState.Checked)
                {
                    var items = checkedListBoxDrives.Items.Count;
                    for (int i = 1; i < items; i++)
                    {
                        checkedListBoxDrives.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
            else
            {
                if (checkedListBoxDrives.GetItemCheckState(checkedListBoxDrives.SelectedIndex) == CheckState.Checked)
                {
                    checkedListBoxDrives.SetItemChecked(0, false);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string drives = "";
            foreach (var checkedItem in checkedListBoxDrives.CheckedItems)
            {
                drives += checkedItem.ToString().Substring(0, 3) + ",";
            }
            drives = drives.TrimEnd(',');
            AppConfigWriter.Write("Drives", drives);

            if (checkBoxIndexnetdrives.Checked)
            {
                AppConfigWriter.Write("netdrives", "true");
            }
            else
            {
                AppConfigWriter.Write("netdrives", "false");
            }

            if (checkBoxLogIndexing.Checked)
            {
                AppConfigWriter.Write("logindexing", "true");
            }
            else
            {
                AppConfigWriter.Write("logindexing", "false");
            }

            AppConfigWriter.Write("indexfilename", textBoxindexFileName.Text);
            AppConfigWriter.Write("indexfilepath", textBoxIndexFilePath.Text);
            AppConfigWriter.Write("tokengennum", numericUpDownTokenGenNum.Value.ToString());
            if (checkBoxFileHasch.Checked)
            {
                AppConfigWriter.Write("usemd5", "true");
            }
            else
            {
                AppConfigWriter.Write("usemd5", "false");
            }

            string filterStr = "";
            if (listBoxFolderFilter.Items.Count > 0)
            {
                foreach (var item in listBoxFolderFilter.Items)
                {
                    filterStr += item + ",";
                }
            }
            filterStr = filterStr.TrimEnd(',');
            AppConfigWriter.Write("filter", filterStr);
            
            this.Close();
        }
    

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (listBoxFolderFilter.SelectedIndex >= 0)
            {
                if (e.ClickedItem.Text == "Delete")
                {
                    listBoxFolderFilter.Items.RemoveAt(listBoxFolderFilter.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Select item to delete.");
            }
           
        }

        private void buttonAddFilter_Click(object sender, EventArgs e)
        {
            listBoxFolderFilter.Items.Add(textBoxAddFilter.Text);
        }
    }
}
