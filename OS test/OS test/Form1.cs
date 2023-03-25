using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.IO.Directory;
using static System.String;

namespace OS_test
{
    public partial class Form1 : Form
    {
        private string myFolderName = Empty;
        public Form1()
        {
            InitializeComponent();
            DeleteSelectedFolder.Enabled = false;
        }

        private void myDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsNullOrEmpty(FolderToDeletePath.Text))
                {
                    var dir = new DirectoryInfo(FolderToDeletePath.Text);
                    if (dir.Exists) dir.Delete(true);
                    else throw new NullReferenceException("folder doesnt exist, lol");
                }
                else throw new NullReferenceException();
            }
            catch (Exception error)
            {
                var title = "Error has been occured, lol";
                var button = MessageBoxButtons.OK;
                MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
            }
            
        }

        private void mySelectFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var myFolder = new FolderBrowserDialog();
                myFolder.RootFolder = Environment.SpecialFolder.DesktopDirectory;
                var result = myFolder.ShowDialog();
                if (result != DialogResult.OK) return;
                myFolderName = myFolder.SelectedPath;
                DeleteSelectedFolder.Enabled = true;
            }
            catch (Exception error)
            {
                var title = "Error has been occured, lol";
                var button = MessageBoxButtons.OK;
                MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
            }
        }


        private void DeleteSelectedFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var currDir = new DirectoryInfo(myFolderName);
                if (currDir.Exists) currDir.Delete(true);
                else throw new NullReferenceException("folder doesnt exist, lol");
            }
            catch (Exception error)
            {
                var title = "Error has been occured, lol";
                var button = MessageBoxButtons.OK;
                MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
            }
        }
    }
}