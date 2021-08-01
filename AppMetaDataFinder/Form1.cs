using AppMetaDataFinder.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MobilityAppVersionFinder.logic;
using MobilityAppVersionFinder.data;

namespace MobilityAppVersionFinder
{
    public partial class mainForm : Form
    {
        FileHandler fileHandler;
        List<App> apps;

        public mainForm()
        {
            InitializeComponent();

            checkButton.Enabled = false;
            updateButton.Enabled = false;

            fileHandler = new FileHandler();
            
            //Set label text and parse file
            if (Settings.Default.lastExcelFilePath != null && !Settings.Default.lastExcelFilePath.Equals(""))
            {
                fileNameLabel.Text = Path.GetFileName(Settings.Default.lastExcelFilePath);
                processExcelFile(Settings.Default.lastExcelFilePath);
            }
        }

        private void fileNameLabel_Click(object sender, EventArgs e)
        {
            //Create a new file dialog
            OpenFileDialog openExcelFileDialog = new OpenFileDialog();
            openExcelFileDialog.Filter = "Excel Files|*.xlsx";
            openExcelFileDialog.Title = "Select the Excel File with Mobility Apps";
            if (Settings.Default.lastExcelFilePath != null && !Settings.Default.lastExcelFilePath.Equals(""))
            {
                openExcelFileDialog.InitialDirectory = Path.GetDirectoryName(Settings.Default.lastExcelFilePath);
            }

            if (openExcelFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Save lastly used file
                Settings.Default.lastExcelFilePath = openExcelFileDialog.FileName;
                Settings.Default.Save();

                //Set label text
                fileNameLabel.Text = Path.GetFileName(openExcelFileDialog.FileName);

                //Process file
                processExcelFile(openExcelFileDialog.FileName);
            }
        }

        private void processExcelFile(string fileName)
        {        
            toolStripStatusLabel1.Text = "";

            fileHandler.FileName = fileName;
            apps = fileHandler.ParseFile();

            if (apps.Count > 0)
            {
                appCountLabel.Text = "Found " + apps.Count + " apps";

                appBindingSource.DataSource = apps;
                appTable.DataSource = appBindingSource;

                checkButton.Enabled = true;
            }
            else
            {
                appCountLabel.Text = "No apps found";
            }
            updateButton.Enabled = false;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

            apps = fileHandler.CheckVersions();

            appBindingSource.DataSource = apps;
            appTable.DataSource = appBindingSource;
            appTable.Refresh();

            updateButton.Enabled = true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (fileHandler.UpdateFile())
            {
                toolStripStatusLabel1.Text = "Updated Excel file";
            };
        }
    }
}
