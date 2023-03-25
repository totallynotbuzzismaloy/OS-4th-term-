namespace OS_5thLab
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
            this.DrivesTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RamTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetAllLogicDrives = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ShowSelectedIndex = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MainPathTextBox = new System.Windows.Forms.TextBox();
            this.NewPathTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createDir = new System.Windows.Forms.Button();
            this.deleteDir = new System.Windows.Forms.Button();
            this.moveDir = new System.Windows.Forms.Button();
            this.OpenDir = new System.Windows.Forms.Button();
            this.DirNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MainFilePath = new System.Windows.Forms.TextBox();
            this.MainFileName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NewFilePath = new System.Windows.Forms.TextBox();
            this.NewFileName = new System.Windows.Forms.TextBox();
            this.createFile = new System.Windows.Forms.Button();
            this.deleteFile = new System.Windows.Forms.Button();
            this.moveToFile = new System.Windows.Forms.Button();
            this.copyToFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.countShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // DrivesTextBox
            // 
            this.DrivesTextBox.Location = new System.Drawing.Point(12, 52);
            this.DrivesTextBox.Name = "DrivesTextBox";
            this.DrivesTextBox.ReadOnly = true;
            this.DrivesTextBox.Size = new System.Drawing.Size(376, 211);
            this.DrivesTextBox.TabIndex = 0;
            this.DrivesTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "info about drives";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RamTextBox
            // 
            this.RamTextBox.Location = new System.Drawing.Point(394, 52);
            this.RamTextBox.Name = "RamTextBox";
            this.RamTextBox.ReadOnly = true;
            this.RamTextBox.Size = new System.Drawing.Size(230, 147);
            this.RamTextBox.TabIndex = 2;
            this.RamTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(394, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "info about RAM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetAllLogicDrives
            // 
            this.GetAllLogicDrives.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GetAllLogicDrives.Location = new System.Drawing.Point(394, 205);
            this.GetAllLogicDrives.Name = "GetAllLogicDrives";
            this.GetAllLogicDrives.Size = new System.Drawing.Size(230, 58);
            this.GetAllLogicDrives.TabIndex = 4;
            this.GetAllLogicDrives.Text = "Logic drives";
            this.GetAllLogicDrives.UseVisualStyleBackColor = false;
            this.GetAllLogicDrives.Click += new System.EventHandler(this.GetAllLogicDrives_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "OS Name", "OS Version", "Process Architecture", "OS Architecture" });
            this.comboBox1.Location = new System.Drawing.Point(633, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ShowSelectedIndex
            // 
            this.ShowSelectedIndex.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ShowSelectedIndex.Location = new System.Drawing.Point(630, 88);
            this.ShowSelectedIndex.Name = "ShowSelectedIndex";
            this.ShowSelectedIndex.Size = new System.Drawing.Size(228, 30);
            this.ShowSelectedIndex.TabIndex = 6;
            this.ShowSelectedIndex.Text = "show";
            this.ShowSelectedIndex.UseVisualStyleBackColor = false;
            this.ShowSelectedIndex.Click += new System.EventHandler(this.ShowSelectedIndex_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(633, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "info about ur computer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(492, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "Actions with dirs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPathTextBox
            // 
            this.MainPathTextBox.Location = new System.Drawing.Point(12, 378);
            this.MainPathTextBox.Multiline = true;
            this.MainPathTextBox.Name = "MainPathTextBox";
            this.MainPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MainPathTextBox.Size = new System.Drawing.Size(327, 47);
            this.MainPathTextBox.TabIndex = 9;
            // 
            // NewPathTextBox
            // 
            this.NewPathTextBox.Location = new System.Drawing.Point(11, 475);
            this.NewPathTextBox.Multiline = true;
            this.NewPathTextBox.Name = "NewPathTextBox";
            this.NewPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NewPathTextBox.Size = new System.Drawing.Size(327, 47);
            this.NewPathTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(12, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 45);
            this.label5.TabIndex = 11;
            this.label5.Text = "Путь, по которому создаются и удаляются директории";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(12, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(492, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "Путь, по которому директории перемещаются";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createDir
            // 
            this.createDir.Location = new System.Drawing.Point(12, 528);
            this.createDir.Name = "createDir";
            this.createDir.Size = new System.Drawing.Size(160, 38);
            this.createDir.TabIndex = 13;
            this.createDir.Text = "create";
            this.createDir.UseVisualStyleBackColor = true;
            this.createDir.Click += new System.EventHandler(this.createDir_Click);
            // 
            // deleteDir
            // 
            this.deleteDir.Location = new System.Drawing.Point(178, 528);
            this.deleteDir.Name = "deleteDir";
            this.deleteDir.Size = new System.Drawing.Size(160, 38);
            this.deleteDir.TabIndex = 14;
            this.deleteDir.Text = "delete";
            this.deleteDir.UseVisualStyleBackColor = true;
            this.deleteDir.Click += new System.EventHandler(this.deleteDir_Click);
            // 
            // moveDir
            // 
            this.moveDir.Location = new System.Drawing.Point(344, 528);
            this.moveDir.Name = "moveDir";
            this.moveDir.Size = new System.Drawing.Size(160, 38);
            this.moveDir.TabIndex = 15;
            this.moveDir.Text = "move";
            this.moveDir.UseVisualStyleBackColor = true;
            this.moveDir.Click += new System.EventHandler(this.moveDir_Click);
            // 
            // OpenDir
            // 
            this.OpenDir.Location = new System.Drawing.Point(345, 475);
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.Size = new System.Drawing.Size(159, 47);
            this.OpenDir.TabIndex = 16;
            this.OpenDir.Text = "open";
            this.OpenDir.UseVisualStyleBackColor = true;
            this.OpenDir.Click += new System.EventHandler(this.OpenDir_Click);
            // 
            // DirNameBox
            // 
            this.DirNameBox.Location = new System.Drawing.Point(345, 378);
            this.DirNameBox.Multiline = true;
            this.DirNameBox.Name = "DirNameBox";
            this.DirNameBox.Size = new System.Drawing.Size(159, 46);
            this.DirNameBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(345, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 34);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dir To create/delete";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(570, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(492, 46);
            this.label8.TabIndex = 20;
            this.label8.Text = "Actions with files";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(570, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(327, 45);
            this.label9.TabIndex = 21;
            this.label9.Text = "Путь, по которому создаются и удаляются файлы";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(903, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 34);
            this.label10.TabIndex = 22;
            this.label10.Text = "File To create/delete";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainFilePath
            // 
            this.MainFilePath.Location = new System.Drawing.Point(570, 378);
            this.MainFilePath.Multiline = true;
            this.MainFilePath.Name = "MainFilePath";
            this.MainFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MainFilePath.Size = new System.Drawing.Size(327, 47);
            this.MainFilePath.TabIndex = 23;
            // 
            // MainFileName
            // 
            this.MainFileName.Location = new System.Drawing.Point(903, 379);
            this.MainFileName.Multiline = true;
            this.MainFileName.Name = "MainFileName";
            this.MainFileName.Size = new System.Drawing.Size(159, 46);
            this.MainFileName.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(570, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(327, 39);
            this.label11.TabIndex = 25;
            this.label11.Text = "Путь, по которому файлы перемещаются/копируются";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(903, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 39);
            this.label12.TabIndex = 26;
            this.label12.Text = "New file name to use in path";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewFilePath
            // 
            this.NewFilePath.Location = new System.Drawing.Point(570, 472);
            this.NewFilePath.Multiline = true;
            this.NewFilePath.Name = "NewFilePath";
            this.NewFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NewFilePath.Size = new System.Drawing.Size(327, 47);
            this.NewFilePath.TabIndex = 27;
            // 
            // NewFileName
            // 
            this.NewFileName.Location = new System.Drawing.Point(903, 472);
            this.NewFileName.Multiline = true;
            this.NewFileName.Name = "NewFileName";
            this.NewFileName.Size = new System.Drawing.Size(159, 46);
            this.NewFileName.TabIndex = 28;
            // 
            // createFile
            // 
            this.createFile.Location = new System.Drawing.Point(570, 528);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(92, 38);
            this.createFile.TabIndex = 29;
            this.createFile.Text = "create";
            this.createFile.UseVisualStyleBackColor = true;
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.Location = new System.Drawing.Point(668, 528);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(92, 38);
            this.deleteFile.TabIndex = 30;
            this.deleteFile.Text = "delete";
            this.deleteFile.UseVisualStyleBackColor = true;
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // moveToFile
            // 
            this.moveToFile.Location = new System.Drawing.Point(766, 528);
            this.moveToFile.Name = "moveToFile";
            this.moveToFile.Size = new System.Drawing.Size(100, 38);
            this.moveToFile.TabIndex = 31;
            this.moveToFile.Text = "move";
            this.moveToFile.UseVisualStyleBackColor = true;
            this.moveToFile.Click += new System.EventHandler(this.moveToFile_Click);
            // 
            // copyToFile
            // 
            this.copyToFile.Location = new System.Drawing.Point(872, 528);
            this.copyToFile.Name = "copyToFile";
            this.copyToFile.Size = new System.Drawing.Size(92, 38);
            this.copyToFile.TabIndex = 32;
            this.copyToFile.Text = "copy";
            this.copyToFile.UseVisualStyleBackColor = true;
            this.copyToFile.Click += new System.EventHandler(this.copyToFile_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(970, 528);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(92, 38);
            this.openFile.TabIndex = 33;
            this.openFile.Text = "open";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(633, 177);
            this.numericUpDown1.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 22);
            this.numericUpDown1.TabIndex = 34;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(748, 177);
            this.numericUpDown2.Maximum = new decimal(new int[] { 199, 0, 0, 0 });
            this.numericUpDown2.Minimum = new decimal(new int[] { 10, 0, 0, -2147483648 });
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(110, 22);
            this.numericUpDown2.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(633, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 36);
            this.label13.TabIndex = 36;
            this.label13.Text = "Number 1";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(748, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 36);
            this.label14.TabIndex = 37;
            this.label14.Text = "Number 2";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countShow
            // 
            this.countShow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.countShow.Location = new System.Drawing.Point(633, 205);
            this.countShow.Name = "countShow";
            this.countShow.Size = new System.Drawing.Size(225, 58);
            this.countShow.TabIndex = 38;
            this.countShow.Text = "button1";
            this.countShow.UseVisualStyleBackColor = false;
            this.countShow.Click += new System.EventHandler(this.countShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 706);
            this.Controls.Add(this.countShow);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.copyToFile);
            this.Controls.Add(this.moveToFile);
            this.Controls.Add(this.deleteFile);
            this.Controls.Add(this.createFile);
            this.Controls.Add(this.NewFileName);
            this.Controls.Add(this.NewFilePath);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MainFileName);
            this.Controls.Add(this.MainFilePath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DirNameBox);
            this.Controls.Add(this.OpenDir);
            this.Controls.Add(this.moveDir);
            this.Controls.Add(this.deleteDir);
            this.Controls.Add(this.createDir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NewPathTextBox);
            this.Controls.Add(this.MainPathTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowSelectedIndex);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GetAllLogicDrives);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RamTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrivesTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button countShow;

        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;

        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.Button moveToFile;
        private System.Windows.Forms.Button copyToFile;
        private System.Windows.Forms.Button openFile;

        private System.Windows.Forms.TextBox NewFilePath;
        private System.Windows.Forms.TextBox NewFileName;
        private System.Windows.Forms.Button createFile;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.TextBox MainFileName;

        private System.Windows.Forms.TextBox MainFilePath;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox DirNameBox;

        private System.Windows.Forms.Button OpenDir;

        private System.Windows.Forms.Button createDir;
        private System.Windows.Forms.Button deleteDir;
        private System.Windows.Forms.Button moveDir;

        private System.Windows.Forms.TextBox NewPathTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox MainPathTextBox;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button ShowSelectedIndex;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button GetAllLogicDrives;

        private System.Windows.Forms.RichTextBox RamTextBox;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.RichTextBox DrivesTextBox;

        #endregion
    }
}