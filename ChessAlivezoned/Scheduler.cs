using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ChessAlivezoned
{
    public partial class Scheduler : Form
    {
        String Status = "";
        private long mBytes = 1000000;
        private String FilePath;
        private String SizePath;
        private int StartAfterSeconds;
        Boolean ApplicationStarted;

        System.Timers.Timer myTimer;
        System.Timers.Timer sizeTimer;
        System.Windows.Forms.Timer statusUpdate = new System.Windows.Forms.Timer();

        public Scheduler()
        {
            InitializeComponent();

            statusUpdate.Tick += StatusUpdate;
            statusUpdate.Interval = 1000;
            statusUpdate.Start();
        }

        // Timed
        public void StatusUpdate(object source, EventArgs e)
        {
            label_status_size.Text = Status;
        }
        // Timed
        public void TimedFunc(object source, EventArgs e)
        {
            if (ApplicationStarted == false)
            {
                StartApp(FilePath);
                ApplicationStarted = true;
                // If the Application has been started by the scheduler 
                //it will not start again
            }
        }
        // Timed
        public void TimedFuncSize(object source, EventArgs e)
        {
            // Exceed the File Size of the selected File
            long size = new System.IO.FileInfo(SizePath).Length;
            long mb = size / mBytes;
            

            String sizeToExceed = txt_file_size.Text.ToString();
            int mainSize = int.Parse(sizeToExceed);
            if (mb > mainSize && ApplicationStarted == false)
            {
                StartApp(FilePath);
                ApplicationStarted = true;
            }
            Status = size + " Bytes | " + mb + " MB | " + Path.GetFileName(SizePath) + " | Exceed: "+mainSize+" MB";
        }


        // Start Application - Button
        private void btn_start_Click(object sender, EventArgs e)
        {
            sizeTimer.Start();

            ApplicationStarted = false;
            SetStartAfterSeconds();
            if (StartAfterSeconds > 0)
            {
                int seconds = 1000 * StartAfterSeconds;
                MessageBox.Show("Time Set: "+seconds);
                myTimer = new System.Timers.Timer();
                myTimer.Elapsed += TimedFunc;
                myTimer.Interval = seconds;
                myTimer.Start();
            }
        }

        // Set Application to Open - Button
        private void btn_set_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                FilePath = openFileDialog1.FileName;
                label_file_path.Text = FilePath;
            }
           
        }

        // Set Application for Size Check - Button
        private void btn_set_size_path_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                SizePath = openFileDialog1.FileName;
                label_file_size.Text = SizePath;

                int seconds = 1000 * 3;
                sizeTimer = new System.Timers.Timer();
                sizeTimer.Elapsed += TimedFuncSize;
                sizeTimer.Interval = seconds;
            }
        }

        // Sets the Seconds after which to start Application
        private void SetStartAfterSeconds()
        {
            String sec = txt_start_after_sec.Text.ToString();
            StartAfterSeconds = int.Parse(sec);
        }

        // Starts the specified app from Path
        private void StartApp(String FilePath)
        {      
            // Prepare process to run
            ProcessStartInfo start = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            // start.Arguments = arguments; 
            // Enter the executable to run, including the complete path
            start.FileName = FilePath;

            // Show in a Console
            // start.WindowStyle = ProcessWindowStyle.Hidden;
            // start.CreateNoWindow = true;
            int exitCode;

            // Running process & waiting for it to finish
            using (Process proc = Process.Start(start))
            {
                 proc.WaitForExit();
                 // Retrieve the app's exit code
                 exitCode = proc.ExitCode;
            }
        }
    }
}
