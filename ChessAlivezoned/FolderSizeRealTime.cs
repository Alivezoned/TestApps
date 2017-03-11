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

namespace ChessAlivezoned
{
    public partial class FolderSizeRealTime : Form
    {
        private String FolderLocation = "";
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        double prevSize = 0;
        double curSize = 0;

        public FolderSizeRealTime()
        {
            InitializeComponent();
        }

        private void FolderSizeRealTime_Load(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = @"C:\ProgramData\Jagex\RuneScape";
            myTimer.Tick += UpdateRegularly;
            myTimer.Interval = 1000; // 1000 ms is one second
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            DialogResult d = folderBrowserDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                FolderLocation = folderBrowserDialog1.SelectedPath;
                label_folder_selected.Text = "Folder Selected:- " + FolderLocation;

                DirectoryInfo DirInfo = new DirectoryInfo(FolderLocation);
                long sizeMB = ConvertToMB(GetFolderSize(DirInfo));
                prevSize = Convert.ToDouble(sizeMB);

                label_previous_size.Text = "Previous Size: "+sizeMB+" MB | "+ConvertToGB(sizeMB)+" GB";

                myTimer.Start();
            }
         
        }

        public void UpdateRegularly(object source, EventArgs e)
        {
            DirectoryInfo DirInfo = new DirectoryInfo(FolderLocation);
            long sizeMB = ConvertToMB(GetFolderSize(DirInfo));
            curSize = Convert.ToDouble(sizeMB);

            label_current_size.Text = "Current Size: "+sizeMB+" MB | "+ConvertToGB(sizeMB)+" GB";

            double ChangeInSize = curSize - prevSize;
            label_change.Text = "Change since last start: " + ChangeInSize + "MB | " + ConvertToGB(Convert.ToInt64(ChangeInSize))+" GB";
        }

        private long GetFolderSize(DirectoryInfo d)
        {
            long size = 0;

            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }

            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += GetFolderSize(di);
            }

            return size;
        }

        private long ConvertToMB(long TotalBytes)
        {
            long finalMB = TotalBytes / 1048576;
            return finalMB;
        }

        private String ConvertToGB(long TotalMB)
        {
            double megabytes = Convert.ToDouble(TotalMB);
            double finalGB = megabytes / 1024;
            finalGB = Math.Round(finalGB, 3);
            return finalGB.ToString();
        }
    }
}
