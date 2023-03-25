using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryForFifthLab;
using myReplacementExplorer;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OS_5thLab
{
    public partial class Form1 : Form
    {
        private Class1 myClass1 = new Class1();
        private myGetInfo _myGetInfo = new myGetInfo();
        private ActionsWithDirs _actionsWithDirs;
        private ActionsWithFiles _actionsWithFiles;
        private string FunctionToShow;
        private string myTitle;

        private delegate void myDelegate();

        private delegate void SecondDelegate();
        
        public Form1()
        {
            InitializeComponent();
            this.Text = $"Current user is {_myGetInfo.GetCurrUserName()}";
            FunctionToShow = comboBox1.Items[0].ToString();
            MainPathTextBox.Text = Directory.GetCurrentDirectory();
            MainFilePath.Text = Directory.GetCurrentDirectory();
            MainFileName.Text = "new text file.txt";
            DirNameBox.Text = "testdir";
            NewPathTextBox.Text = "C:\\";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var myTimer = new System.Timers.Timer();
            myTimer.Interval = 200;
            myTimer.Elapsed += ElapsedEvent;
            myTimer.Start();
            var secondTimer = new System.Timers.Timer();
            myTimer.Interval = 310;
            myTimer.Elapsed += SecondElapsedEvent;
            secondTimer.Start();
        }

        private void SecondElapsedEvent(object sender, EventArgs e)
        {
            RamTextBox.BeginInvoke(new SecondDelegate(RAMoutout));
        }

        private void RAMoutout()
        {
            RamTextBox.Clear();
            var printStr = myClass1.outputRAM();
            RamTextBox.Text = printStr;
        }
        
        private void ElapsedEvent(object sender, EventArgs e)
        {
            DrivesTextBox.BeginInvoke(new myDelegate(outputDriveInfo));
        }

        private void outputDriveInfo()
        {
            DrivesTextBox.Clear();
            var outputString = myClass1.returnDriveInfo();
            DrivesTextBox.Text = outputString;
        }
        
        private void GetAllLogicDrives_Click(object sender, EventArgs e)
        {
            var title = "Logic drives";
            string[] logicDrives = myClass1.OnlyLogicDrives();
            var button = MessageBoxButtons.OK;
            var message =
                $"The list of names of logical drives: {String.Join(", ", logicDrives)}\nThe number of logical drives: {logicDrives.Length}";
            var result = MessageBox.Show(message, title, button, MessageBoxIcon.Information);
            if (result == DialogResult.OK) ;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SelectedFunction = (string)comboBox1.SelectedItem;
            switch (SelectedFunction)
            {
                case "OS Name":
                {
                    FunctionToShow = _myGetInfo.GetOsName();
                    myTitle = "OS Name";
                    break;
                }
                case "OS Version":
                {
                    FunctionToShow = _myGetInfo.GetOsVersion();
                    myTitle = "OS Version";
                    break;
                }
                case "Process Architecture":
                {
                    FunctionToShow = _myGetInfo.myGetProcessArchitecture();
                    myTitle = "Process Architecture";
                    break;
                }
                case "OS Architecture":
                {
                    FunctionToShow = _myGetInfo.myGetOSArchitecture();
                    myTitle = "OS Architecture";
                    break;
                }
            }
        }

        private void ShowSelectedIndex_Click(object sender, EventArgs e)
        {
            var button = MessageBoxButtons.OK;
            var message =
                $"{myTitle}: {FunctionToShow}";
            var result = MessageBox.Show(message, myTitle, button, MessageBoxIcon.Information);
            if (result == DialogResult.OK) ;
        }
        
        private void createDir_Click(object sender, EventArgs e)
        {
            try
            {
                _actionsWithDirs = new ActionsWithDirs(MainPathTextBox.Text, DirNameBox.Text);
                _actionsWithDirs.myCreateDir();
            }
            catch (Exception error)
            {
                var title = "Error message";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) ;
            }
            
        }

        private void deleteDir_Click(object sender, EventArgs e)
        {
            try
            {
                _actionsWithDirs = new ActionsWithDirs(MainPathTextBox.Text, DirNameBox.Text);
                _actionsWithDirs.myDeleteDir();
            }
            catch (Exception error)
            {
                var title = "Error message";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) ;
            }
        }

        private void moveDir_Click(object sender, EventArgs e)
        {
            try
            {
                _actionsWithDirs = new ActionsWithDirs(MainPathTextBox.Text, DirNameBox.Text);
                _actionsWithDirs.MoveDirFromCurrPath(NewPathTextBox.Text);
            }
            catch (Exception error)
            {
                var title = "Error message";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) ;
            }
        }

        private void OpenDir_Click(object sender, EventArgs e)
        {
            try
            {
                _actionsWithDirs = new ActionsWithDirs(MainPathTextBox.Text, DirNameBox.Text);
                _actionsWithDirs.myOpenDirectory();
            }
            catch (Exception error)
            {
                var title = "Error message";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) ;
            }
        }

        private void createFile_Click(object sender, EventArgs e)
        {
            try
            {
                _actionsWithFiles = new ActionsWithFiles(MainFilePath.Text, MainFileName.Text);
                _actionsWithFiles.myCreateFile();
            }
            catch (Exception error)
            {
                var title = "Error message";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) ;
            }
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                _actionsWithFiles = new ActionsWithFiles(MainFilePath.Text, MainFileName.Text);
                _actionsWithFiles.myDeleteFile();
            }
            catch (Exception error)
            {
                var title = "Error message";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) ;
            }
        }

        private void moveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                _actionsWithFiles = new ActionsWithFiles(MainFilePath.Text, MainFileName.Text);
                _actionsWithFiles.MoveFileToNewDest(NewFilePath.Text);
            }
            catch (Exception error)
            {
                var title = "Error message";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) ;
            }
        }

        private void copyToFile_Click(object sender, EventArgs e)
        {
            try
            {
                _actionsWithFiles = new ActionsWithFiles(MainFilePath.Text, MainFileName.Text);
                _actionsWithFiles.myCopyFile(NewFilePath.Text, NewFileName.Text);
            }
            catch (Exception error)
            {
                var title = "Error message";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) ;
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            try
            {
                _actionsWithFiles = new ActionsWithFiles(MainFilePath.Text, MainFileName.Text);
                _actionsWithFiles.myOpenFile();
            }
            catch (Exception error)
            {
                var title = "Error message";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) ;
            }
        }

        private void dinamicConnect()
        {
            try
            { 
                Assembly _myAssembly = Assembly.LoadFrom("myArithmeticOperations.dll");
                Object myObj = _myAssembly.CreateInstance("SomeArithmeticOperations");
                Type _type = _myAssembly.GetType("myArithmeticOperations.SomeArithmeticOperations");
                var numbers = new Object[2];
                var tempStr = new Object[2];
                tempStr[0] = numericUpDown1.Value.ToString();
                tempStr[1] = numericUpDown2.Value.ToString();
                //numbers[0] = Convert.ToInt32(numericUpDown1.Value);//int.Parse(numericUpDown1.Value.ToString());
                //numbers[1] = Convert.ToInt32(numericUpDown2.Value);//int.Parse(numericUpDown2.Value.ToString());
                MethodInfo method0 = _type.GetMethod("ReadNumbs");
                numbers = (object[])method0.Invoke(myObj, tempStr);
                MethodInfo method1 = _type.GetMethod("myAdd");
                MethodInfo method2 = _type.GetMethod("mySub");
                MethodInfo method3 = _type.GetMethod("myMult");
                MethodInfo method4 = _type.GetMethod("myDiv");
                MethodInfo method5 = _type.GetMethod("myMod");
                var myMessage = $"Add: {method1.Invoke(myObj, numbers)}\nSub: {method2.Invoke(myObj, numbers)}\nMult: {method3.Invoke(myObj, numbers)}\n" +
                                $"Div: {method4.Invoke(myObj, numbers)}\nMod: {method5.Invoke(myObj, numbers)}";
                var title = "result of operations";
                var button = MessageBoxButtons.OK;
                MessageBox.Show(myMessage, title, button, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                var title = "Error message";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) ;
            }
        }

        private void countShow_Click(object sender, EventArgs e)
        {
             dinamicConnect();
        }
    }
}