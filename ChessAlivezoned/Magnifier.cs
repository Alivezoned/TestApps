using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ChessAlivezoned
{
    public partial class Magnifier : Form
    {
        public Magnifier()
        {
            InitializeComponent();
        }

        Graphics g;
        Bitmap bmp;
        int posX, posY;
        private System.Drawing.Point MouseLocation;
        Boolean moveForm;

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BringToFront();

            GetMouseLocation();

            MouseLocation = new Point();
            MouseLocation.X = posX;
            MouseLocation.Y = posY;

            bmp = new Bitmap(100, 100);
            g = this.CreateGraphics();
            g = Graphics.FromImage(bmp);
            g.CopyFromScreen(MousePosition.X - 50, MousePosition.Y - 50, 0, 0, new Size(100, 100));
            this.BackgroundImage = bmp;

            this.TopMost = true;

            if (moveForm)
            {
                MoveForm();
            }
            LogKeys();
        }


        public void LogKeys()
        {
            for (Int32 i = 0; i < 255; i++)
            {
                int keyState = GetAsyncKeyState(i);
                if (keyState == 1 || keyState == -32767)
                {
                    String keyName = (Keys)i + "";
                    if (keyName.Contains("LMenu"))
                    {
                        if (moveForm == false)
                        {
                            moveForm = true;
                        }
                        else
                        {
                            moveForm = false;
                        }
                    }
                }
            }
        }

        //Moves the form with the mouse
        public void MoveForm()
        {
            this.Left = 30 + MouseLocation.X;
            this.Top = 30 + MouseLocation.Y;
            this.TopMost = true;
        }

        //Get Location of Mouse
        public void GetMouseLocation()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            posX = Cursor.Position.X;
            posY = Cursor.Position.Y;
        }

        //Set Location of Mouse
        public void MoveMouse(int x, int y)
        {
            Win32.POINT p = new Win32.POINT();
            p.x = x;
            p.y = y;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);
        }

        public class Win32
        {
            [DllImport("User32.Dll")]
            public static extern long SetCursorPos(int x, int y);

            [DllImport("User32.Dll")]
            public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

            [StructLayout(LayoutKind.Sequential)]
            public struct POINT
            {
                public int x;
                public int y;
            }
        }
    }
}
