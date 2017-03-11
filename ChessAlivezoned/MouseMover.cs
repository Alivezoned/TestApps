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
using System.Threading;

namespace ChessAlivezoned
{
    public partial class MouseMover : Form
    {
        //Get Cursor location on screen
        //-----------------------------
        //this.Cursor = new Cursor(Cursor.Current.Handle);
        //int posX = Cursor.Position.X;
        //int posY = Cursor.Position.Y;
        //-----------------------------

        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        Random rand;

        List<Tuple<int, int>> list;
        Boolean record;

        int[] arrayX;
        int[] arrayY;
        Boolean play;

        Boolean PlayTimer;
        int ArrayCounter;

        // Moves mouse to the starting point of the recording
        Boolean MoveToPosition;

        Boolean arc;

        public MouseMover()
        {
            InitializeComponent();
            rand = new Random();
            PlayTimer = false;
        }

        // Form Load
        private void MouseMover_Load(object sender, EventArgs e)
        {
            myTimer.Tick += UpdateRegularly;
            myTimer.Interval = 15;
            myTimer.Start();
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            if (record)
            {
                record = false;

                btn_record.Text = "Recording: Stopped";
            }
            else
            {
                record = true;

                // Record Script
                list = new List<Tuple<int, int>>();
                RecordMouse();
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (play)
            {
                play = false;
                ArrayCounter = 0;
                btn_play.Text = "Play: Stopped";
            }
            else
            {
                play = true;
                MoveToPosition = true;

                int counter = 0;

                int count = list.Count;
                arrayX = new int[count];
                arrayY = new int[count];

                foreach (var item in list)
                {
                    arrayX[counter] = item.Item1;
                    arrayY[counter] = item.Item2;
                    counter += 1;

                    richTextBox1.AppendText(item.Item1 + "");
                }

                ArrayCounter = 0;

                btn_play.Text = "Play: Running";
            }
        }


        private void btn_stop_timer_Click(object sender, EventArgs e)
        {
            if (PlayTimer)
            {
                PlayTimer = false;
                btn_stop_timer.Text = "Timer: Stopped";
            }
            else
            {
                PlayTimer = true; 
                btn_stop_timer.Text = "Timer: Running";
            }
        }

        // Timer Function Performing Mouse Movement
        public void UpdateRegularly(object source, EventArgs e)
        {
            if (PlayTimer)
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                btn_stop_timer.Text = "Timer: Running";

                if (arc)
                {
                    Point test = new Point();
                    test.X = 500;
                    test.Y = 500;

                    Point curr = new Point();
                    curr.X = Cursor.Position.X;
                    curr.Y = Cursor.Position.Y;

                    LinearSmoothMove(test, 1000, curr);

                    if (test == curr)
                    {
                        arc = false;
                        button_mouse_arc.Text = "Mouse Arc: Stopped";
                    }
                    else if (curr.X < 600 && curr.X > 400)
                    {
                        arc = false;
                        button_mouse_arc.Text = "Mouse Arc: Stopped";
                    }
                }

                if (play)
                {
                    if (ArrayCounter < arrayX.Length)
                    {
                        int a = arrayX[ArrayCounter];
                        int b = arrayY[ArrayCounter];
                        
                        int posX = Cursor.Position.X;
                        int posY = Cursor.Position.Y;

                        int ax = a+10;
                        int bx = a-10;

                        if (posX < ax && posX > bx)
                        {
                            MoveToPosition = false;

                            Win32.SetCursorPos(a, b);
                            ArrayCounter += 1;
                        }
                        else
                        {
                            MoveMouseHere(a, b, posX, posY);
                        }
                        richTextBox1.AppendText(a + ", " + b + "\n");
                    }
                    else
                    {
                        play = false;
                        btn_play.Text = "Play: Stopped";
                    }
                }
                else if (record)
                {
                    RecordMouse();
                }
            }
        }

        public void RecordMouse()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = Cursor.Position.X;
            int posY = Cursor.Position.Y;

            list.Add(Tuple.Create(posX, posY));

            btn_record.Text = "Record: recording";
        }

        public void MoveMouseHere(int x, int y, int posX, int posY)
        {
            if (MoveToPosition)
            {
                int min = 0;
                int max = 2;

                int newX = 0, newY = 0;

                if (posX <= x)
                {
                    newX = rand.Next(posX + min, posX + max);
                }
                else if (posX >= x)
                {
                    newX = rand.Next(posX - max, posX - min);
                }

                if (posY <= y)
                {
                    newY = rand.Next(posY + min, posY + max);
                }
                else if (posY >= y)
                {
                    newY = rand.Next(posY - max, posY - min);
                }
                Win32.SetCursorPos(newX, newY);
            }
        }

        public void LinearSmoothMove(Point newPosition, int steps, Point currentPosition)
        {
            Point start = currentPosition;
            PointF iterPoint = start;

            // Find the slope of the line segment defined by start and newPosition
            PointF slope = new PointF(newPosition.X - start.X, newPosition.Y - start.Y);

            // Divide by the number of steps
            slope.X = slope.X / steps;
            slope.Y = slope.Y / steps;

            // Move the mouse to each iterative point.
            for (int i = 0; i < steps; i++)
            {
                iterPoint = new PointF(iterPoint.X + slope.X, iterPoint.Y + slope.Y);

                int tx = Point.Round(iterPoint).X;
                int ty = Point.Round(iterPoint).Y;

                Win32.SetCursorPos(tx, ty);

                richTextBox1.AppendText(tx+" , "+ty);

                Thread.Sleep(40);
            }
            // Move the mouse to the final destination.
            //SetCursorPosition(newPosition);
        }

        private void button_mouse_arc_Click(object sender, EventArgs e)
        {
            if (arc)
            {
                arc = false;
                button_mouse_arc.Text = "Mouse Arc: Stopped";
            }
            else
            {
                arc = true;
                button_mouse_arc.Text = "Mouse Arc: Running";
            }
        }
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
