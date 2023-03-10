using System;
using System.Threading;
using System.Windows.Forms;

namespace OS_4th_lab
{
    public partial class Form5 : Form
    {
        private Thread firsThread;
        private Thread SecondThread;
        private string tempStr = null;
        private int numb = 0;
        private bool flag = false;
        
        public Form5()
        {
            InitializeComponent();
            firsThread = new Thread(fThreadEvent)
            {
                Priority = ThreadPriority.Highest,
                Name = "first thread, form 5"
            };
            firsThread.Start();
            SecondThread = new Thread(sThreadEvent)
            {
                Priority = ThreadPriority.Highest,
                Name = "second thread, form5"
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fThreadEvent();
        }

        private void fThreadEvent()
        { 
            try
            {
                tempStr = textBox1.Text;
                if (int.TryParse(tempStr, out numb)) flag = true;
                else throw new Exception("Введите int");
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag)
                    SecondThread.Start(numb);
                else throw new Exception();
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;
            }
        }

        private void sThreadEvent(object? number)
        {
            try
            {
                if (number is int n)
                {
                    var outputString = $"n * n = {n * n}";
                    var title = "answer";
                    var button = MessageBoxButtons.OK;
                    var result = MessageBox.Show(outputString, title, button);
                    if (result == DialogResult.OK) ;
                }
                else throw new Exception();
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