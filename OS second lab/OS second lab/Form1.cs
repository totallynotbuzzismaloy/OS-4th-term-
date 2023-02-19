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
using System.Management;

namespace OS_second_lab
{
    public partial class Form1 : Form
    {
        private DriveInfo[] alldrives = DriveInfo.GetDrives();
        private ManagementObjectSearcher Search = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
        private System.Timers.Timer my_timer;
        private delegate void my_delegate();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void output_info()
        {
            textBox1.Clear();
            foreach (DriveInfo drive in alldrives)
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
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            String[] drives = Environment.GetLogicalDrives();
            textBox2.Text = "The list of names of logical drives: " + String.Join(", ", drives);
            textBox2.Text = textBox2.Text + Environment.NewLine + "The number of logical drives is" + drives.Length;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Environment.UserName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (ManagementObject Mobject in Search.Get())
            {
                double Ram_bytes = Convert.ToDouble(Mobject["TotalPhysicalMemory"]);
                textBox4.Text = "RAM size in bytes is " + Ram_bytes + " bytes";
                textBox4.Text = textBox4.Text + Environment.NewLine + "RAM size in Gbytes is " +
                                Math.Round(Ram_bytes / 1073741824.0, 3) + " Gbytes";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            my_timer = new System.Timers.Timer();
            my_timer.Interval = 200;
            my_timer.Elapsed += elapsed_event;
            my_timer.Start(); 
            
        }

        private void elapsed_event(object sender, EventArgs e)
        {
            textBox1.BeginInvoke(new my_delegate(output_info));
        }
        
    }
    
}
