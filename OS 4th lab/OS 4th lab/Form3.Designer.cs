using System.ComponentModel;

namespace OS_4th_lab
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.stopWatchText = new System.Windows.Forms.Label();
            this.showForm4 = new System.Windows.Forms.Button();
            this.hideForm4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(445, 73);
            this.progressBar1.Step = 2;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "kill";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stopWatchText
            // 
            this.stopWatchText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stopWatchText.Location = new System.Drawing.Point(496, 12);
            this.stopWatchText.Name = "stopWatchText";
            this.stopWatchText.Size = new System.Drawing.Size(217, 73);
            this.stopWatchText.TabIndex = 3;
            this.stopWatchText.Text = "00:00";
            this.stopWatchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showForm4
            // 
            this.showForm4.Location = new System.Drawing.Point(72, 300);
            this.showForm4.Name = "showForm4";
            this.showForm4.Size = new System.Drawing.Size(146, 49);
            this.showForm4.TabIndex = 4;
            this.showForm4.Text = "show form4";
            this.showForm4.UseVisualStyleBackColor = true;
            this.showForm4.Click += new System.EventHandler(this.showForm4_Click);
            // 
            // hideForm4
            // 
            this.hideForm4.Location = new System.Drawing.Point(72, 355);
            this.hideForm4.Name = "hideForm4";
            this.hideForm4.Size = new System.Drawing.Size(146, 49);
            this.hideForm4.TabIndex = 5;
            this.hideForm4.Text = "hide form4";
            this.hideForm4.UseVisualStyleBackColor = true;
            this.hideForm4.Click += new System.EventHandler(this.hideForm4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hideForm4);
            this.Controls.Add(this.showForm4);
            this.Controls.Add(this.stopWatchText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button showForm4;
        private System.Windows.Forms.Button hideForm4;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label stopWatchText;

        private System.Windows.Forms.ProgressBar progressBar1;

        #endregion
    }
}