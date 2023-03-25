namespace OS_6thLab
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clearListBox1 = new System.Windows.Forms.Button();
            this.killSelectedProc = new System.Windows.Forms.Button();
            this.AboutMyProcessInfo = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fillTheListBox1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.moveSelectedWindow = new System.Windows.Forms.Button();
            this.GetSelectedWindowSize = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.myInfoAboutWindow = new System.Windows.Forms.RichTextBox();
            this.changeAndMove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.changeTheName = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.stopTimer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1003, 634);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clearListBox1);
            this.tabPage1.Controls.Add(this.killSelectedProc);
            this.tabPage1.Controls.Add(this.AboutMyProcessInfo);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.fillTheListBox1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(995, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clearListBox1
            // 
            this.clearListBox1.Location = new System.Drawing.Point(171, 79);
            this.clearListBox1.Name = "clearListBox1";
            this.clearListBox1.Size = new System.Drawing.Size(160, 29);
            this.clearListBox1.TabIndex = 7;
            this.clearListBox1.Text = "clear ListBox1";
            this.clearListBox1.UseVisualStyleBackColor = true;
            this.clearListBox1.Click += new System.EventHandler(this.clearListBox1_Click);
            // 
            // killSelectedProc
            // 
            this.killSelectedProc.Location = new System.Drawing.Point(617, 80);
            this.killSelectedProc.Name = "killSelectedProc";
            this.killSelectedProc.Size = new System.Drawing.Size(369, 29);
            this.killSelectedProc.TabIndex = 6;
            this.killSelectedProc.Text = "kill";
            this.killSelectedProc.UseVisualStyleBackColor = true;
            this.killSelectedProc.Click += new System.EventHandler(this.killSelectedProc_Click);
            // 
            // AboutMyProcessInfo
            // 
            this.AboutMyProcessInfo.Location = new System.Drawing.Point(617, 115);
            this.AboutMyProcessInfo.Name = "AboutMyProcessInfo";
            this.AboutMyProcessInfo.ReadOnly = true;
            this.AboutMyProcessInfo.Size = new System.Drawing.Size(369, 468);
            this.AboutMyProcessInfo.TabIndex = 5;
            this.AboutMyProcessInfo.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 52);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Только окна с интерфейсом(T/F)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fillTheListBox1
            // 
            this.fillTheListBox1.Location = new System.Drawing.Point(6, 79);
            this.fillTheListBox1.Name = "fillTheListBox1";
            this.fillTheListBox1.Size = new System.Drawing.Size(160, 30);
            this.fillTheListBox1.TabIndex = 1;
            this.fillTheListBox1.Text = "fill listbox";
            this.fillTheListBox1.UseVisualStyleBackColor = true;
            this.fillTheListBox1.Click += new System.EventHandler(this.fillTheListBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(605, 468);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.moveSelectedWindow);
            this.tabPage2.Controls.Add(this.GetSelectedWindowSize);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.myInfoAboutWindow);
            this.tabPage2.Controls.Add(this.changeAndMove);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numericWidth);
            this.tabPage2.Controls.Add(this.numericHeight);
            this.tabPage2.Controls.Add(this.numericX);
            this.tabPage2.Controls.Add(this.numericY);
            this.tabPage2.Controls.Add(this.changeTheName);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.stopTimer);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(995, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // moveSelectedWindow
            // 
            this.moveSelectedWindow.Location = new System.Drawing.Point(736, 60);
            this.moveSelectedWindow.Name = "moveSelectedWindow";
            this.moveSelectedWindow.Size = new System.Drawing.Size(91, 49);
            this.moveSelectedWindow.TabIndex = 19;
            this.moveSelectedWindow.Text = "move";
            this.moveSelectedWindow.UseVisualStyleBackColor = true;
            this.moveSelectedWindow.Click += new System.EventHandler(this.moveSelectedWindow_Click);
            // 
            // GetSelectedWindowSize
            // 
            this.GetSelectedWindowSize.Location = new System.Drawing.Point(907, 60);
            this.GetSelectedWindowSize.Name = "GetSelectedWindowSize";
            this.GetSelectedWindowSize.Size = new System.Drawing.Size(78, 48);
            this.GetSelectedWindowSize.TabIndex = 18;
            this.GetSelectedWindowSize.Text = "Get size";
            this.GetSelectedWindowSize.UseVisualStyleBackColor = true;
            this.GetSelectedWindowSize.Click += new System.EventHandler(this.GetSelectedWindowSize_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(829, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 49);
            this.button2.TabIndex = 17;
            this.button2.Text = "show info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // myInfoAboutWindow
            // 
            this.myInfoAboutWindow.Location = new System.Drawing.Point(639, 115);
            this.myInfoAboutWindow.Name = "myInfoAboutWindow";
            this.myInfoAboutWindow.Size = new System.Drawing.Size(347, 483);
            this.myInfoAboutWindow.TabIndex = 16;
            this.myInfoAboutWindow.Text = "";
            // 
            // changeAndMove
            // 
            this.changeAndMove.Location = new System.Drawing.Point(639, 60);
            this.changeAndMove.Name = "changeAndMove";
            this.changeAndMove.Size = new System.Drawing.Size(91, 49);
            this.changeAndMove.TabIndex = 15;
            this.changeAndMove.Text = "change size";
            this.changeAndMove.UseVisualStyleBackColor = true;
            this.changeAndMove.Click += new System.EventHandler(this.changeAndMove_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(557, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Width";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(557, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Height";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(245, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(245, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(441, 32);
            this.numericWidth.Maximum = new decimal(new int[] { 1920, 0, 0, 0 });
            this.numericWidth.Minimum = new decimal(new int[] { 150, 0, 0, 0 });
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(110, 22);
            this.numericWidth.TabIndex = 10;
            this.numericWidth.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(441, 3);
            this.numericHeight.Maximum = new decimal(new int[] { 1080, 0, 0, 0 });
            this.numericHeight.Minimum = new decimal(new int[] { 150, 0, 0, 0 });
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(110, 22);
            this.numericHeight.TabIndex = 9;
            this.numericHeight.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(325, 3);
            this.numericX.Maximum = new decimal(new int[] { 1920, 0, 0, 0 });
            this.numericX.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(110, 22);
            this.numericX.TabIndex = 8;
            this.numericX.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(325, 31);
            this.numericY.Maximum = new decimal(new int[] { 1080, 0, 0, 0 });
            this.numericY.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(110, 22);
            this.numericY.TabIndex = 7;
            this.numericY.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // changeTheName
            // 
            this.changeTheName.Location = new System.Drawing.Point(491, 60);
            this.changeTheName.Name = "changeTheName";
            this.changeTheName.Size = new System.Drawing.Size(142, 49);
            this.changeTheName.TabIndex = 6;
            this.changeTheName.Text = "change the name";
            this.changeTheName.UseVisualStyleBackColor = true;
            this.changeTheName.Click += new System.EventHandler(this.changeTheName_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 60);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(215, 49);
            this.textBox2.TabIndex = 5;
            // 
            // stopTimer
            // 
            this.stopTimer.Location = new System.Drawing.Point(139, 60);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(125, 49);
            this.stopTimer.TabIndex = 4;
            this.stopTimer.Text = "stop timer";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(861, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 3;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(8, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 46);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Is visible? (T/F)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(8, 115);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(625, 484);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 646);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button moveSelectedWindow;

        private System.Windows.Forms.Button clearListBox1;

        private System.Windows.Forms.Button GetSelectedWindowSize;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.RichTextBox myInfoAboutWindow;

        private System.Windows.Forms.Button changeAndMove;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button changeTheName;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button stopTimer;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.CheckBox checkBox2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ListBox listBox2;

        private System.Windows.Forms.Button killSelectedProc;

        private System.Windows.Forms.RichTextBox AboutMyProcessInfo;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.Button fillTheListBox1;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}