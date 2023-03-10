using System;
using System.Windows.Forms;
using System.Threading;

namespace OS_4th_lab
{
    public partial class Form2 : Form
    {
        private System.Timers.Timer myTimer = new System.Timers.Timer();
        private Thread timer_thread;
        private int ratio = 1;
        private bool flag = true;
        private Form5 _form5;
        public Form2()
        {
            InitializeComponent();
            moveToLeft.Width = 40;
            moveToLeft.Left = 50;
            Width = 400;
            timer_thread = new Thread(TimerTick)
            {
                Name = "thread for timer",
                Priority = ThreadPriority.AboveNormal
            };
            new Thread(() => { _form5 = new Form5();})
            {
                Priority = ThreadPriority.Highest,
                Name = "form 5 thread"
            }.Start();
        }


        private void timerStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag)
                {
                    timer_thread.Start();
                    flag = false;
                }
                else throw new Exception("kill timer");
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
        }
        
        private void timerOnTick(object sender, EventArgs e)
        {
            if (moveToLeft.Left == (Width - moveToLeft.Width - 10)) ratio = -1;
            else if (moveToLeft.Left == 0) ratio = 1;
            moveToLeft.Left += 10 * ratio;
        }

        private void killTimer_Click(object sender, EventArgs e)
        {
            try
            {
                flag = true;
                myTimer.Stop();
                timer_thread.Abort();
                timer_thread.Join(1000);
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

        private void showForm5_Click(object sender, EventArgs e)
        {
            try
            {
                _form5.Show();
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }

        private void closeForm5_Click(object sender, EventArgs e)
        {
            try
            {
                _form5.Hide();
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