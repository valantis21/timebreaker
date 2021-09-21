
namespace timebreaker
{
    partial class FormA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA));
            this.TimeBreaker = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeBreaker
            // 
            this.TimeBreaker.Icon = ((System.Drawing.Icon)(resources.GetObject("TimeBreaker.Icon")));
            this.TimeBreaker.Text = "Time Breaker";
            this.TimeBreaker.Visible = true;
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 0);
            this.MinimizeBox = false;
            this.Name = "FormA";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormA";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TimeBreaker;
        private System.Windows.Forms.Timer timer;
    }
}