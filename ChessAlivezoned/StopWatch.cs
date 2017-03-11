using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ChessAlivezoned
{
    public partial class Rune : Form
    {
        // Clock Speed tick. (1 = 1 second OR 1 minute OR 1 Hour)
        private int speed = 1;
        // Tick Interval in ms
        private int tickInterval = 1000;

        private Boolean RunWatch = false;
        private int hour = 0;
        private int minute = 0;
        private int second = 0;
        private System.Windows.Forms.Timer mTime = new System.Windows.Forms.Timer();

        private int SecondsElapsed = 0;

        private Boolean ShowOnTop = false;

        private System.Drawing.Point MouseDownLocation;

        public Rune()
        {
            InitializeComponent();
            mTime.Tick += Stopwatch;
            mTime.Interval = tickInterval;
            mTime.Start();
        }

        /// <summary>
        /// Overridden to Draw a Form Shadow
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void Stopwatch(object source, EventArgs e)
        {
            if (RunWatch)
            {
                if (ShowOnTop)
                {
                    this.TopMost = true;
                }
                else
                {
                    this.TopMost = false;
                }

                //-------------------
                SecondsElapsed += speed;
                second += speed;

                if (second > 59)
                {
                    minute += speed;
                    second = 0;
                }

                if (minute > 59)
                {
                    hour += speed;
                    minute = 0;
                }
                //-------------------

                String ShowSeconds = "Display Seconds";
                String ShowMinute = "Display Minute";
                String ShowHour = "Display Hour";

                if (second > 9)
                {
                    ShowSeconds = second.ToString();
                }
                else
                {
                    ShowSeconds = "0" + second.ToString();
                }
                if (minute > 9)
                {
                    ShowMinute = minute.ToString();
                }
                else
                {
                    ShowMinute = "0" + minute.ToString();
                }
                if (hour > 9)
                {
                    ShowHour = hour.ToString();
                }
                else
                {
                    ShowHour = "0" + hour.ToString();
                }

                label_minute.Text = ShowHour + " : " + ShowMinute + " : " + ShowSeconds;

                label_xp_hour.Text = "xp / h :- " + CalculateXP().ToString();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (RunWatch)
            {
                RunWatch = false;
                btn_start.Text = "Start";
            }
            else
            {
                RunWatch = true;
                btn_start.Text = "Stop";
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            minute = 0;
            second = 0;
            hour = 0;
            SecondsElapsed = 0;

            label_minute.Text = "00 : 00 : 00";
        }


        private void btn_show_on_top_Click(object sender, EventArgs e)
        {
            if (ShowOnTop)
            {
                ShowOnTop = false;
            }
            else
            {
                ShowOnTop = true;
            }
        }

        private String CalculateXP()
        {
            String xpStr = "";

            try
            {
                String xpGained = txt_xp_gained.Text.ToString().Trim();
                Decimal xp = Decimal.Parse(xpGained);

                Decimal xpPerSecond = xp / SecondsElapsed;
                Decimal xpPerHour = xpPerSecond * 3600;

                xpStr = Decimal.Round(xpPerHour, 0).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }

            return xpStr;
        }

        // Move Form
        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void button_min_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Exit Application?", "Exit Application", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
