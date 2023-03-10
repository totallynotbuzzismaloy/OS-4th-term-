namespace OS_4th_lab
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.timerText = new System.Windows.Forms.Label();
            this.saveText = new System.Windows.Forms.Button();
            this.timerStart = new System.Windows.Forms.Button();
            this.timerKill = new System.Windows.Forms.Button();
            this.checkFile = new System.Windows.Forms.Button();
            this.HighPriority = new System.Windows.Forms.Button();
            this.resetTimer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hideForm2 = new System.Windows.Forms.Button();
            this.hideForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(840, 207);
            this.textBox1.TabIndex = 0;
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.openFile.Location = new System.Drawing.Point(330, 267);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(170, 41);
            this.openFile.TabIndex = 1;
            this.openFile.Text = " Open file to write";
            this.openFile.UseVisualStyleBackColor = false;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // timerText
            // 
            this.timerText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timerText.Location = new System.Drawing.Point(327, 9);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(197, 40);
            this.timerText.TabIndex = 5;
            this.timerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveText
            // 
            this.saveText.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveText.Location = new System.Drawing.Point(506, 267);
            this.saveText.Name = "saveText";
            this.saveText.Size = new System.Drawing.Size(170, 41);
            this.saveText.TabIndex = 6;
            this.saveText.Text = "Save text";
            this.saveText.UseVisualStyleBackColor = false;
            this.saveText.Click += new System.EventHandler(this.saveText_Click);
            // 
            // timerStart
            // 
            this.timerStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.timerStart.Location = new System.Drawing.Point(12, 267);
            this.timerStart.Name = "timerStart";
            this.timerStart.Size = new System.Drawing.Size(170, 41);
            this.timerStart.TabIndex = 7;
            this.timerStart.Text = "Start timer";
            this.timerStart.UseVisualStyleBackColor = false;
            this.timerStart.Click += new System.EventHandler(this.timerStart_Click);
            // 
            // timerKill
            // 
            this.timerKill.BackColor = System.Drawing.SystemColors.ControlDark;
            this.timerKill.Location = new System.Drawing.Point(12, 314);
            this.timerKill.Name = "timerKill";
            this.timerKill.Size = new System.Drawing.Size(170, 41);
            this.timerKill.TabIndex = 8;
            this.timerKill.Text = "Kill timer";
            this.timerKill.UseVisualStyleBackColor = false;
            this.timerKill.Click += new System.EventHandler(this.timerKill_Click);
            // 
            // checkFile
            // 
            this.checkFile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkFile.Location = new System.Drawing.Point(682, 267);
            this.checkFile.Name = "checkFile";
            this.checkFile.Size = new System.Drawing.Size(170, 41);
            this.checkFile.TabIndex = 9;
            this.checkFile.Text = " Open file";
            this.checkFile.UseVisualStyleBackColor = false;
            this.checkFile.Click += new System.EventHandler(this.checkFile_Click);
            // 
            // HighPriority
            // 
            this.HighPriority.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HighPriority.Location = new System.Drawing.Point(682, 314);
            this.HighPriority.Name = "HighPriority";
            this.HighPriority.Size = new System.Drawing.Size(170, 41);
            this.HighPriority.TabIndex = 10;
            this.HighPriority.Text = "change Thread priority";
            this.HighPriority.UseVisualStyleBackColor = false;
            this.HighPriority.Click += new System.EventHandler(this.HighPriority_Click);
            // 
            // resetTimer
            // 
            this.resetTimer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resetTimer.Location = new System.Drawing.Point(188, 267);
            this.resetTimer.Name = "resetTimer";
            this.resetTimer.Size = new System.Drawing.Size(136, 41);
            this.resetTimer.TabIndex = 11;
            this.resetTimer.Text = "reset()";
            this.resetTimer.UseVisualStyleBackColor = false;
            this.resetTimer.Click += new System.EventHandler(this.resetTimer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(188, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show form2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(441, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Show form3";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hideForm2
            // 
            this.hideForm2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hideForm2.Location = new System.Drawing.Point(188, 459);
            this.hideForm2.Name = "hideForm2";
            this.hideForm2.Size = new System.Drawing.Size(235, 41);
            this.hideForm2.TabIndex = 14;
            this.hideForm2.Text = "Hide form2";
            this.hideForm2.UseVisualStyleBackColor = false;
            this.hideForm2.Click += new System.EventHandler(this.hideForm2_Click);
            // 
            // hideForm3
            // 
            this.hideForm3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hideForm3.Location = new System.Drawing.Point(441, 459);
            this.hideForm3.Name = "hideForm3";
            this.hideForm3.Size = new System.Drawing.Size(235, 41);
            this.hideForm3.TabIndex = 15;
            this.hideForm3.Text = "Hide form3";
            this.hideForm3.UseVisualStyleBackColor = false;
            this.hideForm3.Click += new System.EventHandler(this.hideForm3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 634);
            this.Controls.Add(this.hideForm3);
            this.Controls.Add(this.hideForm2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resetTimer);
            this.Controls.Add(this.HighPriority);
            this.Controls.Add(this.checkFile);
            this.Controls.Add(this.timerKill);
            this.Controls.Add(this.timerStart);
            this.Controls.Add(this.saveText);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button hideForm2;
        private System.Windows.Forms.Button hideForm3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button resetTimer;

        private System.Windows.Forms.Button HighPriority;

        private System.Windows.Forms.Button checkFile;
        private System.Windows.Forms.Button textbox;

        private System.Windows.Forms.Button timerStart;
        private System.Windows.Forms.Button timerKill;

        private System.Windows.Forms.Button saveText;

        private System.Windows.Forms.Button openFile;

        private System.Windows.Forms.Label timerText;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}