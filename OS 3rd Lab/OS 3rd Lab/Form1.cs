using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_3rd_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            currentPath.Text = Directory.GetCurrentDirectory();
            newPath.Text = "C:\\";
            directoryName.Text = "testDir";
            fileName.Text = "file.txt";
            copyFileName.Text = "newfilename.txt";
        }


        private void createDir_Click(object sender, EventArgs e)
        {
            try
            {
                if (directoryName.Text != null && currentPath.Text != null)
                {
                    var dir = new DirectoryInfo(currentPath.Text);
                    dir.CreateSubdirectory(directoryName.Text);
                }
                else throw new SystemException();
            }
            catch (Exception error)
            {
                exceptions_checks.Text += error;
            }
        }

        private void deleteDir_Click(object sender, EventArgs e)
        {
            try
            {
                if (directoryName.Text != null && currentPath.Text != null)
                {
                    var path = currentPath.Text + "\\" + directoryName.Text;
                    var dir = new DirectoryInfo(path);
                    dir.Delete(true);
                    // Directory.Delete(path, true);
                }
                else throw new SystemException();
            }
            catch (Exception error)
            {
                exceptions_checks.Text += error;
            }
        }

        private void moveDir_Click(object sender, EventArgs e)
        {
            var path = currentPath.Text;
            try
            {
                if (directoryName.Text != null && !Directory.Exists(newPath.Text))
                {
                    path += "\\" + directoryName.Text;
                    var dir = new DirectoryInfo(path);
                    dir.MoveTo(newPath.Text);
                    
                }
                else throw new SystemException();
            }
            catch (Exception error)
            {
                exceptions_checks.Text += error;
            }
        }

        private void clear_excep_Click(object sender, EventArgs e)
        {
            exceptions_checks.Clear();
        }

        private void createFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileName.Text != null && currentPath.Text != null)
                {
                    var path = currentPath.Text + "\\" + fileName.Text;
                    var file = new FileInfo(path);
                    file.Create();
                }
                else throw new SystemException();
            }
            catch (Exception error)
            {
                exceptions_checks.Text += error;
            }
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileName.Text != null && currentPath.Text != null)
                {
                    var path = currentPath.Text + "\\" + fileName.Text;
                    var file = new FileInfo(path);
                    if(file.Exists)
                        file.Delete();
                    //File.Delete(path);
                }
                else throw new SystemException();
            }
            catch (Exception error)
            {
                exceptions_checks.Text += error;
            }
        }

        private void moveFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileName.Text != null && currentPath.Text != null)
                {
                    var path = currentPath.Text + "\\" + fileName.Text;
                    var file = new FileInfo(path);
                    if(file.Exists) 
                        file.MoveTo(newPath.Text + "\\" + fileName.Text);
                }
                else throw new SystemException();
            }
            catch (Exception error)
            {
                exceptions_checks.Text += error;
            }
        }

        private void copyFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileName.Text != null && currentPath.Text != null)
                {
                    var path = currentPath.Text + "\\" + fileName.Text;
                    var file = new FileInfo(path);
                    if (file.Exists)
                        file.CopyTo(newPath.Text + "\\" + copyFileName.Text, true);

                }
                else throw new SystemException();
            }
            catch (Exception error)
            {
                exceptions_checks.Text += error;
            }
        }

        private void OpenDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (directoryName.Text != null && currentPath.Text != null)
                {
                    var path = currentPath.Text + "\\" + directoryName.Text;
                    if (Directory.Exists(path))
                        Process.Start("explorer.exe", path);
                    else exceptions_checks.Text += "\ndirectory doesnt exist\n";
                }
                else throw new SystemException();
            }
            catch (Exception error)
            {
                exceptions_checks.Text += error;
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileName.Text != null && currentPath.Text != null)
                {
                    var path = currentPath.Text + "\\" + fileName.Text;
                    if (File.Exists(path))
                        Process.Start(path);
                    else exceptions_checks.Text += "\nfile doesnt exist\n";
                }
                else throw new SystemException();
            }
            catch (Exception error)
            {
                exceptions_checks.Text += error;
            }
        }
    }
}