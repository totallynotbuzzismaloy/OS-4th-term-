using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace OS_4th_lab
{
    public partial class Form4 : Form
    {
        private DriveInfo[] alldrives = DriveInfo.GetDrives();
        private System.Timers.Timer myTimer = new System.Timers.Timer();
        private System.Timers.Timer myTimer2 = new System.Timers.Timer();
        
        private delegate void my_delegate();
        private delegate void myDelegate2();
        private IAsyncResult resultobj;
        private IAsyncResult resultobj2;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void outputInfo()
        {
            textBox1.Clear();
            foreach (var drive in alldrives)
            {
                textBox1.Text = "Drive " + drive.Name + Environment.NewLine;
                textBox1.Text = textBox1.Text + "   Drive type: " + drive.DriveType + Environment.NewLine;
                if (drive.IsReady == true)
                {
                    textBox1.Text = textBox1.Text + "   Volume Label is " + drive.VolumeLabel + Environment.NewLine;
                    textBox1.Text = textBox1.Text + "   File system is " + drive.DriveFormat + Environment.NewLine;
                    textBox1.Text = textBox1.Text + $"   Available space is {drive.AvailableFreeSpace, 15} bytes" 
                                                  + Environment.NewLine;
                    textBox1.Text = textBox1.Text + $"   Total available space is {drive.TotalFreeSpace, 15} bytes"
                                                  + Environment.NewLine;
                    textBox1.Text = textBox1.Text +
                                    $"   Total size of drive is {Math.Round(drive.TotalSize / 1073741824.0, 3), 8} Gbytes"
                                    + Environment.NewLine;
                }
            }
        }
        
        private void startTimer_Click(object sender, EventArgs e)
        {
            try
            {
                timerConfig();
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }

        private void timerConfig()
        {
            myTimer.Interval = 150;
            myTimer.Elapsed += Elapsed_event1;
            myTimer.Start();
        }

        private void Elapsed_event1(object sender, EventArgs e)
        {
            resultobj = textBox1.BeginInvoke(new my_delegate(outputInfo));
        }

        private void stopTimer_Click(object sender, EventArgs e)
        {
            textBox1.EndInvoke(resultobj);
            myTimer.Stop();
        }

        private void timer2Config()
        {
            myTimer2.Interval = 100;
            myTimer2.Elapsed += Elapsed_event2;
            myTimer2.Start();
        }

        private void Elapsed_event2(object sender, EventArgs e)
        {
            resultobj2 = textBox2.BeginInvoke(new myDelegate2(outputRAM));
        }

        private void showRam_Click(object sender, EventArgs e)
        {
            try
            {
                timer2Config();
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }

        private void outputRAM()
        {
            var computerInfo = new ComputerInfo();
            var total_phys_ram = Math.Round(computerInfo.TotalPhysicalMemory / 1073741824.0, 3);
            var available_phys_ram = Math.Round(computerInfo.AvailablePhysicalMemory / 1073741824.0, 3);
            var totaly_virt_ram = Math.Round(computerInfo.TotalVirtualMemory / 1073741824.0, 4);
            var available_virt_ram = Math.Round(computerInfo.AvailableVirtualMemory / 1073741824.0, 4);
            var output =
                $"Total physical RAM: {total_phys_ram, 10}{Environment.NewLine}Total virtual RAM: {totaly_virt_ram, 10}{Environment.NewLine}\tAvailable physical RAM: {available_phys_ram, 10}{Environment.NewLine}\tAvailable virtual RAM: {available_virt_ram, 10}";
            textBox2.Text = output;
        }

        private void stopShow_Click(object sender, EventArgs e)
        {
            textBox2.EndInvoke(resultobj2);
            myTimer2.Stop();
        }
    }
}