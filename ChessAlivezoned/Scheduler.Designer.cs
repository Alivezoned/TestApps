namespace ChessAlivezoned
{
    partial class Scheduler
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_file_path = new System.Windows.Forms.Label();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_start_after_sec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_file_size = new System.Windows.Forms.TextBox();
            this.label_file_size = new System.Windows.Forms.Label();
            this.btn_set_size_path = new System.Windows.Forms.Button();
            this.label_status_size = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_file_path
            // 
            this.label_file_path.AutoSize = true;
            this.label_file_path.Location = new System.Drawing.Point(13, 38);
            this.label_file_path.Name = "label_file_path";
            this.label_file_path.Size = new System.Drawing.Size(48, 13);
            this.label_file_path.TabIndex = 0;
            this.label_file_path.Text = "File Path";
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(12, 54);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(211, 23);
            this.btn_set.TabIndex = 1;
            this.btn_set.Text = "Set Application To Open";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(11, 277);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(211, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start Application";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_start_after_sec
            // 
            this.txt_start_after_sec.Location = new System.Drawing.Point(11, 184);
            this.txt_start_after_sec.Name = "txt_start_after_sec";
            this.txt_start_after_sec.Size = new System.Drawing.Size(211, 20);
            this.txt_start_after_sec.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start After Seconds: (Application Will Start after this time regardless of other " +
    "settings)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Application if this file Size exceeds (Enter File Size in MB)";
            // 
            // txt_file_size
            // 
            this.txt_file_size.Location = new System.Drawing.Point(11, 238);
            this.txt_file_size.Name = "txt_file_size";
            this.txt_file_size.Size = new System.Drawing.Size(211, 20);
            this.txt_file_size.TabIndex = 5;
            // 
            // label_file_size
            // 
            this.label_file_size.AutoSize = true;
            this.label_file_size.Location = new System.Drawing.Point(13, 92);
            this.label_file_size.Name = "label_file_size";
            this.label_file_size.Size = new System.Drawing.Size(48, 13);
            this.label_file_size.TabIndex = 7;
            this.label_file_size.Text = "File Path";
            // 
            // btn_set_size_path
            // 
            this.btn_set_size_path.Location = new System.Drawing.Point(11, 108);
            this.btn_set_size_path.Name = "btn_set_size_path";
            this.btn_set_size_path.Size = new System.Drawing.Size(211, 23);
            this.btn_set_size_path.TabIndex = 8;
            this.btn_set_size_path.Text = "Set Application For Size Check";
            this.btn_set_size_path.UseVisualStyleBackColor = true;
            this.btn_set_size_path.Click += new System.EventHandler(this.btn_set_size_path_Click);
            // 
            // label_status_size
            // 
            this.label_status_size.AutoSize = true;
            this.label_status_size.Location = new System.Drawing.Point(13, 136);
            this.label_status_size.Name = "label_status_size";
            this.label_status_size.Size = new System.Drawing.Size(44, 13);
            this.label_status_size.TabIndex = 9;
            this.label_status_size.Text = "Tracker";
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 388);
            this.Controls.Add(this.label_status_size);
            this.Controls.Add(this.btn_set_size_path);
            this.Controls.Add(this.label_file_size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_file_size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_start_after_sec);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.label_file_path);
            this.Name = "Scheduler";
            this.Text = "Scheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_file_path;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_start_after_sec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_file_size;
        private System.Windows.Forms.Label label_file_size;
        private System.Windows.Forms.Button btn_set_size_path;
        private System.Windows.Forms.Label label_status_size;
    }
}