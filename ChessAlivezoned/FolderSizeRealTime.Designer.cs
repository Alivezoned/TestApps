namespace ChessAlivezoned
{
    partial class FolderSizeRealTime
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_browse = new System.Windows.Forms.Button();
            this.label_current_size = new System.Windows.Forms.Label();
            this.label_previous_size = new System.Windows.Forms.Label();
            this.label_change = new System.Windows.Forms.Label();
            this.label_folder_selected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_browse
            // 
            this.button_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_browse.ForeColor = System.Drawing.Color.DimGray;
            this.button_browse.Location = new System.Drawing.Point(22, 106);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(305, 34);
            this.button_browse.TabIndex = 0;
            this.button_browse.Text = "Browse Folder";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // label_current_size
            // 
            this.label_current_size.AutoSize = true;
            this.label_current_size.Location = new System.Drawing.Point(69, 27);
            this.label_current_size.Name = "label_current_size";
            this.label_current_size.Size = new System.Drawing.Size(67, 13);
            this.label_current_size.TabIndex = 1;
            this.label_current_size.Text = "Current Size:";
            // 
            // label_previous_size
            // 
            this.label_previous_size.AutoSize = true;
            this.label_previous_size.Location = new System.Drawing.Point(62, 54);
            this.label_previous_size.Name = "label_previous_size";
            this.label_previous_size.Size = new System.Drawing.Size(74, 13);
            this.label_previous_size.TabIndex = 2;
            this.label_previous_size.Text = "Previous Size:";
            // 
            // label_change
            // 
            this.label_change.AutoSize = true;
            this.label_change.Location = new System.Drawing.Point(19, 79);
            this.label_change.Name = "label_change";
            this.label_change.Size = new System.Drawing.Size(117, 13);
            this.label_change.TabIndex = 3;
            this.label_change.Text = "Change since last start:";
            // 
            // label_folder_selected
            // 
            this.label_folder_selected.AutoSize = true;
            this.label_folder_selected.Location = new System.Drawing.Point(32, 143);
            this.label_folder_selected.Name = "label_folder_selected";
            this.label_folder_selected.Size = new System.Drawing.Size(87, 13);
            this.label_folder_selected.TabIndex = 4;
            this.label_folder_selected.Text = "Folder Selected: ";
            // 
            // FolderSizeRealTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 261);
            this.Controls.Add(this.label_folder_selected);
            this.Controls.Add(this.label_change);
            this.Controls.Add(this.label_previous_size);
            this.Controls.Add(this.label_current_size);
            this.Controls.Add(this.button_browse);
            this.Name = "FolderSizeRealTime";
            this.Text = "FolderSizeRealTime";
            this.Load += new System.EventHandler(this.FolderSizeRealTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label_current_size;
        private System.Windows.Forms.Label label_previous_size;
        private System.Windows.Forms.Label label_change;
        private System.Windows.Forms.Label label_folder_selected;
    }
}