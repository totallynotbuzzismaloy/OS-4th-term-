namespace OS_test
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
            this.FolderToDeletePath = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myDelete = new System.Windows.Forms.Button();
            this.mySelectFolder = new System.Windows.Forms.Button();
            this.DeleteSelectedFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FolderToDeletePath
            // 
            this.FolderToDeletePath.Location = new System.Drawing.Point(12, 91);
            this.FolderToDeletePath.Name = "FolderToDeletePath";
            this.FolderToDeletePath.Size = new System.Drawing.Size(341, 52);
            this.FolderToDeletePath.TabIndex = 0;
            this.FolderToDeletePath.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Удаление через путь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myDelete
            // 
            this.myDelete.Location = new System.Drawing.Point(13, 149);
            this.myDelete.Name = "myDelete";
            this.myDelete.Size = new System.Drawing.Size(340, 52);
            this.myDelete.TabIndex = 2;
            this.myDelete.Text = "удалить";
            this.myDelete.UseVisualStyleBackColor = true;
            this.myDelete.Click += new System.EventHandler(this.myDelete_Click);
            // 
            // mySelectFolder
            // 
            this.mySelectFolder.Location = new System.Drawing.Point(466, 90);
            this.mySelectFolder.Name = "mySelectFolder";
            this.mySelectFolder.Size = new System.Drawing.Size(294, 52);
            this.mySelectFolder.TabIndex = 3;
            this.mySelectFolder.Text = "Select Folder";
            this.mySelectFolder.UseVisualStyleBackColor = true;
            this.mySelectFolder.Click += new System.EventHandler(this.mySelectFolder_Click);
            // 
            // DeleteSelectedFolder
            // 
            this.DeleteSelectedFolder.Location = new System.Drawing.Point(466, 149);
            this.DeleteSelectedFolder.Name = "DeleteSelectedFolder";
            this.DeleteSelectedFolder.Size = new System.Drawing.Size(294, 52);
            this.DeleteSelectedFolder.TabIndex = 4;
            this.DeleteSelectedFolder.Text = "Delete Selected Folder";
            this.DeleteSelectedFolder.UseVisualStyleBackColor = true;
            this.DeleteSelectedFolder.Click += new System.EventHandler(this.DeleteSelectedFolder_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(466, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Удаление через выбор папки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteSelectedFolder);
            this.Controls.Add(this.mySelectFolder);
            this.Controls.Add(this.myDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderToDeletePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button mySelectFolder;
        private System.Windows.Forms.Button DeleteSelectedFolder;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button myDelete;

        private System.Windows.Forms.RichTextBox FolderToDeletePath;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}