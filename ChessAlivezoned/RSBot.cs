using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace ChessAlivezoned
{
    public partial class RSBot : Form
    {
        Random rand;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint mButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private const int KEYEVENT_QUICKPRESET = 0x31; //Key 1

        //If specified, the key is being released. If not specified, the key is being depressed.
        private const uint KEYEVENTF_KEYUP = 0x0002;

        //If specified, the scan code was preceded by a prefix byte having the value 0xE0 (224
        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer clickTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer qInventoryTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer mouse = new System.Windows.Forms.Timer();

        Boolean exitFlag;
        Boolean clickTimer_exitFlag;
        Boolean qInventory_exitFlag;
        Boolean mouse_exitFlag;

        int mouseClickCount;
        int maxClicks;

        int SecondCount;
        int AccessBankAfterSeconds;

        public RSBot()
        {
            InitializeComponent();
            rand = new Random();

            SecondCount = 0;
            mouseClickCount = 0;
            maxClicks = 3;

            exitFlag = false;
            clickTimer_exitFlag = false;
            qInventory_exitFlag = false;
            mouse_exitFlag = false;
        }

        private void RSBot_Load(object sender, EventArgs e)
        {
            myTimer.Tick += RunRegular;
            myTimer.Interval = 1000;
            myTimer.Start();

            clickTimer.Tick += ClickDelay;
            qInventoryTimer.Tick += QuickInventoryClick;
            mouse.Tick += Mouse;
        }
        private void button_start_botting_Click(object sender, EventArgs e)
        {
            String bAccess = txt_access_bank_sec.Text.ToString();
            AccessBankAfterSeconds = int.Parse(bAccess);

            if (exitFlag)
            {
                exitFlag = false;
                clickTimer_exitFlag = false;
                qInventory_exitFlag = false;
                mouse_exitFlag = false;

                button_start_botting.Text = "Bot Stopped";
            }
            else
            {
                exitFlag = true;

                button_start_botting.Text = "Bot Running";
            }
        }

        public void RunRegular(object source, EventArgs e)
        {
            if (exitFlag)
            {
                SecondCount += 1;
                if (SecondCount >= AccessBankAfterSeconds)
                {
                    clickTimer_exitFlag = false;
                    qInventory_exitFlag = false;
                    mouse_exitFlag = false;

                    // Click Bank after Random Delay
                    int clickTime = rand.Next(900,1400);
                    label_click_time.Text = "Click Delay : "+clickTime;

                    clickTimer.Interval = clickTime;
                    clickTimer_exitFlag = true;
                    clickTimer.Start();

                    SecondCount = 0;
                }
                label1.Text = "Seconds : " + SecondCount.ToString();

                int timeInterval = rand.Next(970,1070);
                myTimer.Interval = timeInterval;

                label_script_time.Text = "Script Interval :" + timeInterval;

                // (Hold Key) Bone Burying Hotkey
            }
        }

        public void Mouse(object source, EventArgs e)
        {
            if (mouse_exitFlag)
            {
                if (mouseClickCount > maxClicks)
                {
                    mouse_exitFlag = false;
                }
                else
                {
                    MouseClick();
                    mouseClickCount += 1;

                    int r = rand.Next(150, 250);
                    mouse.Interval = r;

                    label_fast_click.Text = "Fast Click Interval :" + r;

                }
            }
        }

        // Mouse Click on Bank
        public void ClickDelay(object source, EventArgs e)
        {
            if (clickTimer_exitFlag)
            {
                // Stop activity before access bank
                qInventory_exitFlag = false;

                // Click bank
                mouseClickCount = 0;
                maxClicks = 3;
                mouse_exitFlag = true;
                mouse.Interval = 200;
                mouse.Start();

                // Use Quick Inventory hotkey after clicking bank to withdraw items
                qInventoryTimer.Stop();

                int invenTimer = rand.Next(3200, 3900);
                label_inventory_time.Text = "Load Preset : " + invenTimer;

                qInventoryTimer.Interval = invenTimer;
                qInventory_exitFlag = true;
                qInventoryTimer.Start();

                // Stop the Clicks
                clickTimer_exitFlag = false;
            }
        }

        // Press Quick Inventory Key and Bury Bones
        public void QuickInventoryClick(object source, EventArgs e)
        {
            if (qInventory_exitFlag)
            {
                // Press 1 (Quick Preset Hotkey) : This Withdraws Items

                mouse_exitFlag = false;
                keybd_event((byte)KEYEVENT_QUICKPRESET, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);

                int r = rand.Next(1900,2400);
                qInventoryTimer.Interval = r;

                label_act_interval.Text = "Bury Bones Click : " + r;
            }
        }

        // Press the Key and keep it pressed
        protected void PressKey(int k)
        {
            keybd_event((byte)k, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
        }
        // Press the key then release it
        protected void ReleaseKey(int k)
        {
            keybd_event((byte)k, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        public void MouseClick()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            uint finalX = uint.Parse(X + "");
            uint finalY = uint.Parse(Y + "");
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, finalX, finalY, 0, 0);
        }


    }
}
