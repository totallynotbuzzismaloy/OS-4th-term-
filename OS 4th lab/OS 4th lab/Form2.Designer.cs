using System.ComponentModel;

namespace OS_4th_lab
{
    partial class Form2
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
            this.moveToLeft = new System.Windows.Forms.Button();
            this.timerStart = new System.Windows.Forms.Button();
            this.killTimer = new System.Windows.Forms.Button();
            this.showForm5 = new System.Windows.Forms.Button();
            this.closeForm5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moveToLeft
            // 
            this.moveToLeft.BackColor = System.Drawing.SystemColors.HotTrack;
            this.moveToLeft.Location = new System.Drawing.Point(119, 222);
            this.moveToLeft.Name = "moveToLeft";
            this.moveToLeft.Size = new System.Drawing.Size(101, 40);
            this.moveToLeft.TabIndex = 0;
            this.moveToLeft.UseVisualStyleBackColor = false;
            // 
            // timerStart
            // 
            this.timerStart.Location = new System.Drawing.Point(119, 303);
            this.timerStart.Name = "timerStart";
            this.timerStart.Size = new System.Drawing.Size(241, 35);
            this.timerStart.TabIndex = 2;
            this.timerStart.Text = "start timer";
            this.timerStart.UseVisualStyleBackColor = true;
            this.timerStart.Click += new System.EventHandler(this.timerStart_Click);
            // 
            // killTimer
            // 
            this.killTimer.Location = new System.Drawing.Point(119, 344);
            this.killTimer.Name = "killTimer";
            this.killTimer.Size = new System.Drawing.Size(241, 35);
            this.killTimer.TabIndex = 3;
            this.killTimer.Text = "kill timer";
            this.killTimer.UseVisualStyleBackColor = true;
            this.killTimer.Click += new System.EventHandler(this.killTimer_Click);
            // 
            // showForm5
            // 
            this.showForm5.Location = new System.Drawing.Point(80, 27);
            this.showForm5.Name = "showForm5";
            this.showForm5.Size = new System.Drawing.Size(120, 37);
            this.showForm5.TabIndex = 4;
            this.showForm5.Text = "show form5";
            this.showForm5.UseVisualStyleBackColor = true;
            this.showForm5.Click += new System.EventHandler(this.showForm5_Click);
            // 
            // closeForm5
            // 
            this.closeForm5.Location = new System.Drawing.Point(80, 70);
            this.closeForm5.Name = "closeForm5";
            this.closeForm5.Size = new System.Drawing.Size(120, 37);
            this.closeForm5.TabIndex = 5;
            this.closeForm5.Text = "close form5";
            this.closeForm5.UseVisualStyleBackColor = true;
            this.closeForm5.Click += new System.EventHandler(this.closeForm5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.closeForm5);
            this.Controls.Add(this.showForm5);
            this.Controls.Add(this.killTimer);
            this.Controls.Add(this.timerStart);
            this.Controls.Add(this.moveToLeft);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button showForm5;
        private System.Windows.Forms.Button closeForm5;

        private System.Windows.Forms.Button timerStart;
        private System.Windows.Forms.Button killTimer;

        private System.Windows.Forms.Button moveToLeft;

        #endregion
    }
}