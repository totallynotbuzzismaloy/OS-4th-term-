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
using System.Threading;
using System.Timers;

namespace OS_4th_lab
{
    public partial class Form1 : Form
    {
        private string path = null;
        private Thread timer_thread;
        private System.Timers.Timer myTimer = new System.Timers.Timer();
        private Stopwatch myStopwatch = new Stopwatch();
        private Form2 _form2;
        private Form3 _form3;
        
        public Form1()
        {
            InitializeComponent();
            new Thread(() => { _form2 = new Form2();})
            {
                Priority = ThreadPriority.AboveNormal,
                Name = "form 2 thread"
            }.Start();
            new Thread(() => { _form3 = new Form3();})
            {
                Priority = ThreadPriority.Highest,
                Name = "form 3 thread"
            }.Start();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                }
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }

        private void saveText_Click(object sender, EventArgs e)
        {
            try
            {
                if (path != null && timerText.Text != null)
                {
                    using (var sw = new StreamWriter(path))
                    {
                        var timeSpent =
                            $"Вы потратили столько времени: {timerText.Text}\nЧтобы написать это:\n {textBox1.Text}";
                        sw.WriteLineAsync(timeSpent);
                    }
                    textBox1.Clear();
                }
                else throw new NullReferenceException();
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }

        private void checkFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (path != null && File.Exists(path))
                    Process.Start(path);
                else throw new NullReferenceException("File doesnt exist or the path is null");
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }

        private void timerStart_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.ReadOnly = false;
                timer_thread = new Thread(TimerTick)
                {
                    Name = "thread for timer",
                    Priority = ThreadPriority.BelowNormal
                };
                timer_thread.Start();
                //textBox1.Text += Environment.NewLine + timer_thread.Name + ' '+ timer_thread.ManagedThreadId + ' ' + timer_thread.IsAlive + ' ' + timer_thread.ThreadState + "\n";
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }
        
        private void TimerTick()
        {
            myTimer.Interval = 100;
            myTimer.Elapsed += timerOnTick;
            myTimer.Start();
            myStopwatch.Start();
        }
        
        private void timerOnTick(object sender, EventArgs e)
        {
            timerText.Text = myStopwatch.Elapsed.ToString("mm\\:ss");
        }

        private void timerKill_Click(object sender, EventArgs e)
        {
            try
            {
                myTimer.Stop();
                myStopwatch.Stop();
                textBox1.ReadOnly = true;
                timer_thread.Abort();
                timer_thread.Join(1000);
                //textBox1.Text += Environment.NewLine + timer_thread.Name + ' ' + timer_thread.ManagedThreadId + ' ' + timer_thread.IsAlive + ' ' +
                                 //timer_thread.ThreadState + '\n';
            }
            catch (ThreadAbortException myException)
            {
                var title = "An exception with threads has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(myException.ToString(), title, button);
                if (result == DialogResult.OK) ;
                Thread.ResetAbort();
            }
        }

        private void HighPriority_Click(object sender, EventArgs e)
        {
            try
            {
                timer_thread.Abort();
                timer_thread.Join(500);
                timer_thread = new Thread(TimerTick)
                  {
                      Name = "thread for timer with belownormal priority",
                      Priority = ThreadPriority.Lowest
                  };
                timer_thread.Start();
               // textBox1.Text += Environment.NewLine + timer_thread.Priority +' '+ timer_thread.Name + ' ' + timer_thread.ManagedThreadId + ' ' + timer_thread.IsAlive + " " + timer_thread.ThreadState + "\n";
               // textBox1.Text += Environment.NewLine + curr.ThreadState + ' ' + curr.Priority + ' ' +
                                // curr.ManagedThreadId;
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }


        private void resetTimer_Click(object sender, EventArgs e)
        {
                myStopwatch.Reset();
                myTimer.Stop();
                timerText.Text = "00:00";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _form2.Show();
            }
            catch (Exception error)
            {
                textBox1.Text += error;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _form3.Show();
            }
            catch (Exception error)
            {
                textBox1.Text += error;
            }
        }

        private void hideForm3_Click(object sender, EventArgs e)
        {
            _form3.Hide();
        }

        private void hideForm2_Click(object sender, EventArgs e)
        { 
            _form2.Hide();
        }
    }
}