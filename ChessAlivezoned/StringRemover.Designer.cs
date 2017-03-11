namespace ChessAlivezoned
{
    partial class StringRemover
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
            this.txt_to_remove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_folder_select = new System.Windows.Forms.Button();
            this.label_folder_loc = new System.Windows.Forms.Label();
            this.btn_remove_text = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_to_remove
            // 
            this.txt_to_remove.Location = new System.Drawing.Point(12, 42);
            this.txt_to_remove.Name = "txt_to_remove";
            this.txt_to_remove.Size = new System.Drawing.Size(224, 20);
            this.txt_to_remove.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type Text To Remove";
            // 
            // btn_folder_select
            // 
            this.btn_folder_select.Location = new System.Drawing.Point(12, 83);
            this.btn_folder_select.Name = "btn_folder_select";
            this.btn_folder_select.Size = new System.Drawing.Size(224, 23);
            this.btn_folder_select.TabIndex = 2;
            this.btn_folder_select.Text = "Select Folder";
            this.btn_folder_select.UseVisualStyleBackColor = true;
            this.btn_folder_select.Click += new System.EventHandler(this.btn_folder_select_Click);
            // 
            // label_folder_loc
            // 
            this.label_folder_loc.AutoSize = true;
            this.label_folder_loc.Location = new System.Drawing.Point(12, 109);
            this.label_folder_loc.Name = "label_folder_loc";
            this.label_folder_loc.Size = new System.Drawing.Size(121, 13);
            this.label_folder_loc.TabIndex = 3;
            this.label_folder_loc.Text = "Folder location Selected";
            // 
            // btn_remove_text
            // 
            this.btn_remove_text.Location = new System.Drawing.Point(12, 152);
            this.btn_remove_text.Name = "btn_remove_text";
            this.btn_remove_text.Size = new System.Drawing.Size(224, 23);
            this.btn_remove_text.TabIndex = 4;
            this.btn_remove_text.Text = "Start Removing Text";
            this.btn_remove_text.UseVisualStyleBackColor = true;
            this.btn_remove_text.Click += new System.EventHandler(this.btn_remove_text_Click);
            // 
            // StringRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_remove_text);
            this.Controls.Add(this.label_folder_loc);
            this.Controls.Add(this.btn_folder_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_to_remove);
            this.Name = "StringRemover";
            this.Text = "StringRemover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_to_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_folder_select;
        private System.Windows.Forms.Label label_folder_loc;
        private System.Windows.Forms.Button btn_remove_text;
    }
}