namespace OS_3rd_Lab
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
            this.currentPath = new System.Windows.Forms.TextBox();
            this.newPath = new System.Windows.Forms.TextBox();
            this.directoryName = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.createDir = new System.Windows.Forms.Button();
            this.deleteDir = new System.Windows.Forms.Button();
            this.moveDir = new System.Windows.Forms.Button();
            this.createFile = new System.Windows.Forms.Button();
            this.deleteFile = new System.Windows.Forms.Button();
            this.moveFile = new System.Windows.Forms.Button();
            this.copyFile = new System.Windows.Forms.Button();
            this.OpenDirectory = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.exceptions_checks = new System.Windows.Forms.TextBox();
            this.clear_excep = new System.Windows.Forms.Button();
            this.copyFileName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentPath
            // 
            this.currentPath.Location = new System.Drawing.Point(10, 91);
            this.currentPath.Multiline = true;
            this.currentPath.Name = "currentPath";
            this.currentPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.currentPath.Size = new System.Drawing.Size(430, 50);
            this.currentPath.TabIndex = 0;
            // 
            // newPath
            // 
            this.newPath.Location = new System.Drawing.Point(11, 206);
            this.newPath.Multiline = true;
            this.newPath.Name = "newPath";
            this.newPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.newPath.Size = new System.Drawing.Size(429, 126);
            this.newPath.TabIndex = 1;
            // 
            // directoryName
            // 
            this.directoryName.Location = new System.Drawing.Point(462, 91);
            this.directoryName.Multiline = true;
            this.directoryName.Name = "directoryName";
            this.directoryName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.directoryName.Size = new System.Drawing.Size(217, 50);
            this.directoryName.TabIndex = 2;
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(462, 206);
            this.fileName.Multiline = true;
            this.fileName.Name = "fileName";
            this.fileName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileName.Size = new System.Drawing.Size(218, 33);
            this.fileName.TabIndex = 3;
            // 
            // createDir
            // 
            this.createDir.Location = new System.Drawing.Point(12, 399);
            this.createDir.Name = "createDir";
            this.createDir.Size = new System.Drawing.Size(137, 40);
            this.createDir.TabIndex = 4;
            this.createDir.Text = "create";
            this.createDir.UseVisualStyleBackColor = true;
            this.createDir.Click += new System.EventHandler(this.createDir_Click);
            // 
            // deleteDir
            // 
            this.deleteDir.Location = new System.Drawing.Point(155, 399);
            this.deleteDir.Name = "deleteDir";
            this.deleteDir.Size = new System.Drawing.Size(145, 40);
            this.deleteDir.TabIndex = 5;
            this.deleteDir.Text = "delete";
            this.deleteDir.UseVisualStyleBackColor = true;
            this.deleteDir.Click += new System.EventHandler(this.deleteDir_Click);
            // 
            // moveDir
            // 
            this.moveDir.Location = new System.Drawing.Point(306, 399);
            this.moveDir.Name = "moveDir";
            this.moveDir.Size = new System.Drawing.Size(134, 40);
            this.moveDir.TabIndex = 6;
            this.moveDir.Text = "move";
            this.moveDir.UseVisualStyleBackColor = true;
            this.moveDir.Click += new System.EventHandler(this.moveDir_Click);
            // 
            // createFile
            // 
            this.createFile.Location = new System.Drawing.Point(12, 516);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(102, 40);
            this.createFile.TabIndex = 7;
            this.createFile.Text = "create";
            this.createFile.UseVisualStyleBackColor = true;
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.Location = new System.Drawing.Point(121, 516);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(102, 40);
            this.deleteFile.TabIndex = 8;
            this.deleteFile.Text = "delete";
            this.deleteFile.UseVisualStyleBackColor = true;
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // moveFile
            // 
            this.moveFile.Location = new System.Drawing.Point(230, 516);
            this.moveFile.Name = "moveFile";
            this.moveFile.Size = new System.Drawing.Size(102, 40);
            this.moveFile.TabIndex = 9;
            this.moveFile.Text = "move";
            this.moveFile.UseVisualStyleBackColor = true;
            this.moveFile.Click += new System.EventHandler(this.moveFile_Click);
            // 
            // copyFile
            // 
            this.copyFile.Location = new System.Drawing.Point(339, 516);
            this.copyFile.Name = "copyFile";
            this.copyFile.Size = new System.Drawing.Size(102, 40);
            this.copyFile.TabIndex = 10;
            this.copyFile.Text = "copy";
            this.copyFile.UseVisualStyleBackColor = true;
            this.copyFile.Click += new System.EventHandler(this.copyFile_Click);
            // 
            // OpenDirectory
            // 
            this.OpenDirectory.Location = new System.Drawing.Point(462, 398);
            this.OpenDirectory.Name = "OpenDirectory";
            this.OpenDirectory.Size = new System.Drawing.Size(218, 41);
            this.OpenDirectory.TabIndex = 12;
            this.OpenDirectory.Text = "open Dir";
            this.OpenDirectory.UseVisualStyleBackColor = true;
            this.OpenDirectory.Click += new System.EventHandler(this.OpenDirectory_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(462, 516);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(218, 41);
            this.OpenFile.TabIndex = 13;
            this.OpenFile.Text = "open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 79);
            this.label1.TabIndex = 14;
            this.label1.Text = "Текущий путь(в нем файлы/директории создаются/удаляются/из него перемещаются)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(11, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 58);
            this.label2.TabIndex = 15;
            this.label2.Text = "Путь, по которому необходимо переместить директорию/скопировать файл";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 47);
            this.label3.TabIndex = 16;
            this.label3.Text = "Кнопки для взаимодействия с директориями";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 47);
            this.label4.TabIndex = 17;
            this.label4.Text = "Кнопки для взаимодействия с файлами";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(462, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 47);
            this.label5.TabIndex = 18;
            this.label5.Text = "Проверить сущ-ние директории(из textbox №1)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(462, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 47);
            this.label6.TabIndex = 19;
            this.label6.Text = "Проверить сущ-ние файла(из textbox №2)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(462, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 79);
            this.label7.TabIndex = 20;
            this.label7.Text = "имя директории, которую нужно создать/удалить/переместить (textbox №1)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(462, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 59);
            this.label8.TabIndex = 21;
            this.label8.Text = "имя файла, который нужно создать/удалить/переместить/скопировать (textbox№2)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exceptions_checks
            // 
            this.exceptions_checks.Location = new System.Drawing.Point(697, 9);
            this.exceptions_checks.Multiline = true;
            this.exceptions_checks.Name = "exceptions_checks";
            this.exceptions_checks.ReadOnly = true;
            this.exceptions_checks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.exceptions_checks.Size = new System.Drawing.Size(222, 504);
            this.exceptions_checks.TabIndex = 22;
            // 
            // clear_excep
            // 
            this.clear_excep.Location = new System.Drawing.Point(697, 515);
            this.clear_excep.Name = "clear_excep";
            this.clear_excep.Size = new System.Drawing.Size(222, 41);
            this.clear_excep.TabIndex = 23;
            this.clear_excep.Text = "clear";
            this.clear_excep.UseVisualStyleBackColor = true;
            this.clear_excep.Click += new System.EventHandler(this.clear_excep_Click);
            // 
            // copyFileName
            // 
            this.copyFileName.Location = new System.Drawing.Point(462, 299);
            this.copyFileName.Multiline = true;
            this.copyFileName.Name = "copyFileName";
            this.copyFileName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.copyFileName.Size = new System.Drawing.Size(218, 33);
            this.copyFileName.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(462, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 54);
            this.label9.TabIndex = 25;
            this.label9.Text = "Имя файла для копирования в новый путь";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 643);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.copyFileName);
            this.Controls.Add(this.clear_excep);
            this.Controls.Add(this.exceptions_checks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.OpenDirectory);
            this.Controls.Add(this.copyFile);
            this.Controls.Add(this.moveFile);
            this.Controls.Add(this.deleteFile);
            this.Controls.Add(this.createFile);
            this.Controls.Add(this.moveDir);
            this.Controls.Add(this.deleteDir);
            this.Controls.Add(this.createDir);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.directoryName);
            this.Controls.Add(this.newPath);
            this.Controls.Add(this.currentPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox copyFileName;

        private System.Windows.Forms.Button clear_excep;

        private System.Windows.Forms.TextBox exceptions_checks;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button OpenDirectory;

        private System.Windows.Forms.Button createFile;
        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.Button moveFile;
        private System.Windows.Forms.Button copyFile;

        private System.Windows.Forms.Button createDir;
        private System.Windows.Forms.Button deleteDir;
        private System.Windows.Forms.Button moveDir;

        private System.Windows.Forms.TextBox fileName;

        private System.Windows.Forms.TextBox directoryName;

        private System.Windows.Forms.TextBox newPath;

        private System.Windows.Forms.TextBox currentPath;

        #endregion
    }
}