using System;
using System.Windows.Forms;

namespace timebreaker
{
    public partial class FormA : Form
    {
        public FormA()
        {
            InitializeComponent();
            timer.Interval = int.MaxValue;
            TimeBreaker.ContextMenuStrip = new ContextMenuStrip();
            TimeBreaker.ContextMenuStrip.Items.Add("10 Seconds", null);
            TimeBreaker.ContextMenuStrip.Items.Add("10 Minutes", null);
            TimeBreaker.ContextMenuStrip.Items.Add("30 Minutes", null);
            TimeBreaker.ContextMenuStrip.Items.Add("1 Hour", null);
            TimeBreaker.ContextMenuStrip.Items.Add("2 Hours", null);
            TimeBreaker.ContextMenuStrip.Items.Add("3 Hours", null);
            TimeBreaker.ContextMenuStrip.Items.Add("6 Hours", null);
            TimeBreaker.ContextMenuStrip.Items.Add("Stop", null);
            TimeBreaker.ContextMenuStrip.Items.Add("Quit", null);
            TimeBreaker.ContextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip_Clicked);
        }

        private void ToolStrip_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "10 Seconds":
                    timer.Interval = 10000;
                    break;
                case "10 Minutes":
                    timer.Interval = 600000;
                    break;
                case "30 Minutes":
                    timer.Interval = 1800000;
                    break;
                case "1 Hour":
                    timer.Interval = 3600000;
                    break;
                case "2 Hours":
                    timer.Interval = 7200000;
                    break;
                case "3 Hours":
                    timer.Interval = 10800000;
                    break;
                case "6 hours":
                    timer.Interval = 21600000;
                    break;
            }
            timer.Stop();
            if (e.ClickedItem.Text != "Stop")
            {
                timer.Start();
            }
            if (e.ClickedItem.Text == "Quit")
            {
                Dispose();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timer.Interval != 300000)
            {
                TimeBreaker.ShowBalloonTip(0, "Break Time", "Take a 5 minute break", ToolTipIcon.Warning);
            }
            else
            {
                TimeBreaker.ShowBalloonTip(0, "Break Over", "Back to work", ToolTipIcon.Info);
            }
            timer.Interval = 300000;
        }
    }
}
