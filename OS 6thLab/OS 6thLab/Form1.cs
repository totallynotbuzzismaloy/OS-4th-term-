using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.String;


namespace OS_6thLab
{
    public partial class Form1 : Form
    {
        private myParseString myParse = new myParseString();
        private myProcessData constStruct;
        private System.Timers.Timer myTimer = new System.Timers.Timer();
        private System.Timers.Timer anotherTimer = new System.Timers.Timer();
        
        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        private delegate void myDelegate();
        
        [DllImport("user32.dll")] 
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        /*[DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();*/

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int numbChars);

        [DllImport("user32.dll")]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWindowVisible(IntPtr hWnd);
        
        [DllImport("user32.dll")]
        private static extern int SetWindowText(IntPtr hWnd, string text);

        [DllImport("user32.dll")]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        private static extern int GetWindowThreadProcessId(IntPtr hWnd, out int IpdwProcessId);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        
        
        public Form1()
        {
            InitializeComponent();
            stopTimer.Enabled = false;
            stopTimer.Visible = false;
            textBox2.ReadOnly = true;
            changeTheName.Enabled = false;
            changeAndMove.Enabled = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            GetSelectedWindowSize.Enabled = false;
        }

        private void fillTheListBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (checkBox1.Checked == false)
            {
                Process[] processesList = Process.GetProcesses();
                //var outputString = String.Empty;
                foreach (var myProcess in processesList)
                {
                    //outputString = !String.IsNullOrEmpty(myProcess.MainWindowTitle) ? $"Name: '{myProcess.ProcessName}',   ID: {myProcess.Id},   Window title: {myProcess.MainWindowTitle}" : $"Name: '{myProcess.ProcessName}',   ID: {myProcess.Id},   Process doesnt have interface";
                    listBox1.Items.Add($"Name: {myProcess.ProcessName}, ID: {myProcess.Id}");
                }
            }
            else
            {
                Process[] processesList = Process.GetProcesses();
                foreach (var myProcess in processesList)
                {
                    if (!IsNullOrEmpty(myProcess.MainWindowTitle)) listBox1.Items.Add($"Name: {myProcess.ProcessName}, ID: {myProcess.Id}");
                }
                
            } 
        }
        
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var StringName = Empty;
            StringName = listBox1.SelectedItem.ToString();
            constStruct.selectedProcessID = Convert.ToInt32(myParse.MyGetIDProcess(StringName));
            showInfo();
            //showInfo(Convert.ToInt32(myParse.MyGetIDProcess(StringName)));
            //AboutMyProcessInfo.Text = myParse.MyGetIDProcess(StringName).ToString();
            //showInfo(StringName);

        }

        private void showInfo()
        {
            AboutMyProcessInfo.Clear();
            try
            {
                var currProcess = Process.GetProcessById(Convert.ToInt32(constStruct.selectedProcessID));
                    if (checkBox1.Checked == false)
                    {
                        var outputString =
                            $"Name: {currProcess.ProcessName}, ID: {constStruct.selectedProcessID}\n\tMain Window Handle: {currProcess.MainWindowHandle}\n\tMain Window Title: {currProcess.MainWindowTitle}";
                        AboutMyProcessInfo.Text = outputString;
                    }
                    else
                    {
                        var outputString =
                            $"Name: {currProcess.ProcessName}, ID: {constStruct.selectedProcessID}\n\tMain Window Title: {currProcess.MainWindowTitle}\n\tMain Window Handle: {currProcess.MainWindowHandle}\n\tPriority Class: {currProcess.PriorityClass}\n\tBase Priority: {currProcess.BasePriority}\n\tPhysical Memory usage: {currProcess.WorkingSet64,10} bytes\n\tPaged System memory size: {currProcess.PagedSystemMemorySize64,10} bytes\n\tPaged memory size: {currProcess.PagedMemorySize64,10} bytes";
                        AboutMyProcessInfo.Text = outputString;
                    }
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                MessageBox.Show(error.ToString(),title,button);
            }
            
        }

        private void killSelectedProc_Click(object sender, EventArgs e)
        {
            try
            {
                var currProcess = Process.GetProcessById(constStruct.selectedProcessID);
                if (!checkBox1.Checked || IsNullOrEmpty(currProcess.MainWindowTitle)) return;
                currProcess.Kill();
                currProcess.WaitForExit();
                AboutMyProcessInfo.Clear();
            }
            catch (Exception error)
            {}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if (!IsNullOrEmpty(myGetWindows()))
             {
                 listBox2.Items.Add(myGetWindows());
             } */
           myTimer.Interval = 1900;
           myTimer.Elapsed += ElapsedEvent;
           myTimer.Start();
           button1.Enabled = false;
           button1.Visible = false;
           stopTimer.Enabled = true;
           stopTimer.Visible = true;
        }

        private void ElapsedEvent(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.DataSource = myGetList();
        }
        
        private List<string> myGetList()
        {
            var returnList = new List<string>();
            if (!checkBox2.Checked)
            {
                EnumWindows(delegate(IntPtr hWnd, IntPtr param)
                {
                    if (GetWindowTextLength(hWnd) != 0)
                    {
                        var saveString = $"{GetWindowText(hWnd)}, {hWnd}";
                        returnList.Add(saveString);
                        //listBox2.Items.Add(GetWindowText(hWnd));
                    }
                    return true;
                }, IntPtr.Zero);
            }
            else
            {
                EnumWindows(delegate(IntPtr hWnd, IntPtr param)
                {
                    if (GetWindowTextLength(hWnd) != 0 && IsWindowVisible(hWnd))
                    {
                        var saveString = $"{GetWindowText(hWnd)}, {hWnd}";
                        returnList.Add(saveString);
                        //listBox2.Items.Add(GetWindowText(hWnd));
                    }
                    return true;
                }, IntPtr.Zero);
            }

            return returnList;
        }

        private static string GetWindowText(IntPtr hWnd)
        {
            var size = GetWindowTextLength(hWnd);
            if (size <= 0) return Empty;
            var Buff = new StringBuilder(size + 1);
            GetWindowText(hWnd, Buff, Buff.Capacity);
            return Buff.ToString();
            /*const int amount = 256;
            var Buff = new StringBuilder(amount);
            var handle = GetForegroundWindow();
            if (GetWindowText(handle, Buff, amount) > 0) return Buff.ToString();
            else return Empty;*/
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedString = Empty;
            selectedString = listBox2.SelectedItem.ToString();
            constStruct.secondSelectedProcessID = Convert.ToInt32(myParse.MyGetIDProcess(selectedString));
            textBox1.Text = constStruct.secondSelectedProcessID.ToString();
        }

        private void stopTimer_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
            button1.Enabled = true;
            button1.Visible = true;
            stopTimer.Enabled = false;
            stopTimer.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.ReadOnly = false;
                changeTheName.Enabled = true;
                changeAndMove.Enabled = true;
                GetSelectedWindowSize.Enabled = true;
            }
            else
            {
                textBox2.ReadOnly = true;
                changeTheName.Enabled = false;
                changeAndMove.Enabled = false;
                GetSelectedWindowSize.Enabled = false;
            }
        }

        private void changeTheName_Click(object sender, EventArgs e)
        {
            SetWindowText((IntPtr)constStruct.secondSelectedProcessID, textBox2.Text);
        }

        private void changeAndMove_Click(object sender, EventArgs e)
        { 
            GetWinSize();
            //var x = Convert.ToInt32(numericX.Value);
            //var y = Convert.ToInt32(numericY.Value);
            var myWidth = Convert.ToInt32(numericWidth.Value);
            var myHeight = Convert.ToInt32(numericHeight.Value);
            MoveWindow((IntPtr)constStruct.secondSelectedProcessID, constStruct.x, constStruct.y, myWidth, myHeight,
                true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myInfoAboutWindow.Clear();
            showInformation();
            myInfoAboutWindow.ReadOnly = true;
        }

        private void showInformation()
        {
            GetWindowThreadProcessId((IntPtr)constStruct.secondSelectedProcessID, out var currProcessId);
            var currProcess = Process.GetProcessById(currProcessId);
            if (checkBox2.Checked)
            {
                var outputString = $"Name: {currProcess.ProcessName}, ID: {currProcessId}\n\tMain Window Title: {currProcess.MainWindowTitle}\n\tMain Window Handle: {currProcess.MainWindowHandle}\n\tPriority Class: {currProcess.PriorityClass}\n\tBase Priority: {currProcess.BasePriority}\n\tPhysical Memory usage: {currProcess.WorkingSet64,10} bytes\n\tPaged System memory size: {currProcess.PagedSystemMemorySize64,10} bytes\n\tPaged memory size: {currProcess.PagedMemorySize64,10} bytes\n\tPrivate memory size: {currProcess.PrivateMemorySize64}\n\tSession ID: {currProcess.SessionId}\n\tSafe Handle: {currProcess.SafeHandle}";
                myInfoAboutWindow.Text = outputString;
            }
            else
            {
                var outputString = $"Name: {currProcess.ProcessName}, ID: {currProcessId}\n\tMain Window Title: {currProcess.MainWindowTitle}\n\tMain Window Handle: {currProcess.MainWindowHandle}\n\tSafe Handle: {currProcess.SafeHandle}\n\tPriority Class: {currProcess.PriorityClass}";
                myInfoAboutWindow.Text = outputString;
            }
            //myInfoAboutWindow.Text = $"Name: {currProcess.ProcessName}, ID: {currProcessId}";
        }

        private void GetSelectedWindowSize_Click(object sender, EventArgs e)
        {
            GetWinSize();
            var message = $"\tWidth: {constStruct.myWidth}\n\tHeight: {constStruct.myHeight}\n\tX position: {constStruct.x}\n\tY position: {constStruct.y}";
            var title = "The size and the position in coordinates of the selected window";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetWinSize()
        {
            var rc = new RECT();
            GetWindowRect((IntPtr)constStruct.secondSelectedProcessID, ref rc);
            constStruct.myWidth = rc.Right - rc.Left;
            constStruct.myHeight = rc.Bottom - rc.Top;
            constStruct.x = rc.Left;
            constStruct.y = rc.Top;
        }

        private void clearListBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void moveSelectedWindow_Click(object sender, EventArgs e)
        {
            GetWinSize();
            var myX = Convert.ToInt32(numericX.Value);
            var myY = Convert.ToInt32(numericY.Value);
            MoveWindow((IntPtr)constStruct.secondSelectedProcessID, myX, myY, constStruct.myWidth, constStruct.myHeight,
                true);
        }
    }
}