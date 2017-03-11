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
    public partial class StringRemover : Form
    {
        private String directory;

        public StringRemover()
        {
            InitializeComponent();
            Console.WriteLine("Dhruv Kumar - Alivezoned");
        }

        private void btn_remove_text_Click(object sender, EventArgs e)
        {
            String textToRemove = txt_to_remove.Text.ToString();
            if (directory.Length > 1 && textToRemove.Length > 0)
            {
                RemoveString(textToRemove);
            }
        }

        private void btn_folder_select_Click(object sender, EventArgs e)
        {
            DialogResult d = folderBrowserDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                directory = folderBrowserDialog1.SelectedPath.ToString();
                label_folder_loc.Text = directory;
            }
        }

        private void RemoveString(String replace)
        {
            try
            {
                StringBuilder b = new StringBuilder();

                DirectoryInfo d = new DirectoryInfo(directory);
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    b.Append(f.Name + " -> ");
                    File.Move(f.FullName, f.FullName.ToString().Replace(replace, ""));
                    b.Append(Path.GetFileName(f.FullName.ToString().Replace(replace, "")));
                    b.AppendLine("");b.AppendLine("");
                }

                MessageBox.Show(b.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }
    }
}
