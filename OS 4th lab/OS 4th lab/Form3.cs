using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace OS_4th_lab
{
    public partial class Form3 : Form
    {
        private System.Timers.Timer myTimer1 = new System.Timers.Timer();
        private System.Timers.Timer myTimer2 = new System.Timers.Timer();
        private Stopwatch myStopwatch = new Stopwatch();
        private Thread timer1_thread;
        private Thread timer2_thread;
        private Form4 _form4;
        public Form3()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            progressBar1.Step = 2;
            new Thread(() => { _form4 = new Form4();})
            {
                Priority = ThreadPriority.Highest,
                Name = "form 4 thread"
            }.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                timer1_thread = new Thread(timer1Tick)
                {
                    Priority = ThreadPriority.BelowNormal
                };
                timer2_thread = new Thread(timer2Tick)
                {
                    Priority = ThreadPriority.AboveNormal
                };
                timer1_thread.Start();
                timer2_thread.Start();
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }

        private void timer1Tick()
        {
            myTimer1.Interval = 650;
            myTimer1.Elapsed += ElapsedEvent1;
            myTimer1.Start();
        }

        private void timer2Tick()
        {
            myTimer2.Interval = 100;
            myTimer2.Elapsed += ElapsedEvent2;
            myTimer2.Start();
            myStopwatch.Start();
        }

        private void ElapsedEvent1(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void ElapsedEvent2(object sender, EventArgs e)
        {
            stopWatchText.Text = myStopwatch.Elapsed.ToString("mm\\:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                myTimer1.Stop();
                myTimer2.Stop();
                myStopwatch.Reset();
                progressBar1.Value = 0;
                stopWatchText.Text = "00:00";
                timer1_thread.Abort();
                timer1_thread.Join(1000);
                timer2_thread.Abort();
                timer2_thread.Join(1000);
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


        private void showForm4_Click(object sender, EventArgs e)
        {
            try
            {
                _form4.Show();
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }

        private void hideForm4_Click(object sender, EventArgs e)
        {
            try
            {
                _form4.Hide();
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }
    }
}