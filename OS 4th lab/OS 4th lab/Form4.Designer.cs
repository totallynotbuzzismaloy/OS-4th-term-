using System.ComponentModel;

namespace OS_4th_lab
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startTimer = new System.Windows.Forms.Button();
            this.stopTimer = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.showRam = new System.Windows.Forms.Button();
            this.stopShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(356, 243);
            this.textBox1.TabIndex = 0;
            // 
            // startTimer
            // 
            this.startTimer.Location = new System.Drawing.Point(12, 289);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(170, 44);
            this.startTimer.TabIndex = 1;
            this.startTimer.Text = "start";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.startTimer_Click);
            // 
            // stopTimer
            // 
            this.stopTimer.Location = new System.Drawing.Point(198, 289);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(170, 44);
            this.stopTimer.TabIndex = 2;
            this.stopTimer.Text = "stop";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(320, 188);
            this.textBox2.TabIndex = 3;
            // 
            // showRam
            // 
            this.showRam.Location = new System.Drawing.Point(402, 234);
            this.showRam.Name = "showRam";
            this.showRam.Size = new System.Drawing.Size(150, 49);
            this.showRam.TabIndex = 4;
            this.showRam.Text = "start";
            this.showRam.UseVisualStyleBackColor = true;
            this.showRam.Click += new System.EventHandler(this.showRam_Click);
            // 
            // stopShow
            // 
            this.stopShow.Location = new System.Drawing.Point(572, 234);
            this.stopShow.Name = "stopShow";
            this.stopShow.Size = new System.Drawing.Size(150, 49);
            this.stopShow.TabIndex = 5;
            this.stopShow.Text = "stop";
            this.stopShow.UseVisualStyleBackColor = true;
            this.stopShow.Click += new System.EventHandler(this.stopShow_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopShow);
            this.Controls.Add(this.showRam);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.stopTimer);
            this.Controls.Add(this.startTimer);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button showRam;
        private System.Windows.Forms.Button stopShow;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Button stopTimer;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}