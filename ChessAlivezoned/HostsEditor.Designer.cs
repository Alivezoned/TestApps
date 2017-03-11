namespace ChessAlivezoned
{
    partial class HostsEditor
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
            this.txt_link1 = new System.Windows.Forms.TextBox();
            this.txt_link2 = new System.Windows.Forms.TextBox();
            this.label_link1 = new System.Windows.Forms.Label();
            this.label_link2 = new System.Windows.Forms.Label();
            this.btn_add_site = new System.Windows.Forms.Button();
            this.label_address = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_link1
            // 
            this.txt_link1.Location = new System.Drawing.Point(12, 28);
            this.txt_link1.Name = "txt_link1";
            this.txt_link1.Size = new System.Drawing.Size(197, 20);
            this.txt_link1.TabIndex = 0;
            this.txt_link1.TextChanged += new System.EventHandler(this.txt_link1_TextChanged);
            // 
            // txt_link2
            // 
            this.txt_link2.Location = new System.Drawing.Point(12, 87);
            this.txt_link2.Name = "txt_link2";
            this.txt_link2.Size = new System.Drawing.Size(197, 20);
            this.txt_link2.TabIndex = 1;
            // 
            // label_link1
            // 
            this.label_link1.AutoSize = true;
            this.label_link1.Location = new System.Drawing.Point(12, 9);
            this.label_link1.Name = "label_link1";
            this.label_link1.Size = new System.Drawing.Size(36, 13);
            this.label_link1.TabIndex = 2;
            this.label_link1.Text = "Link 1";
            // 
            // label_link2
            // 
            this.label_link2.AutoSize = true;
            this.label_link2.Location = new System.Drawing.Point(12, 71);
            this.label_link2.Name = "label_link2";
            this.label_link2.Size = new System.Drawing.Size(36, 13);
            this.label_link2.TabIndex = 3;
            this.label_link2.Text = "Link 2";
            // 
            // btn_add_site
            // 
            this.btn_add_site.Location = new System.Drawing.Point(12, 168);
            this.btn_add_site.Name = "btn_add_site";
            this.btn_add_site.Size = new System.Drawing.Size(197, 23);
            this.btn_add_site.TabIndex = 4;
            this.btn_add_site.Text = "Add";
            this.btn_add_site.UseVisualStyleBackColor = true;
            this.btn_add_site.Click += new System.EventHandler(this.btn_add_site_Click);
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(12, 126);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(45, 13);
            this.label_address.TabIndex = 6;
            this.label_address.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(12, 142);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(197, 20);
            this.txt_address.TabIndex = 5;
            // 
            // HostsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 321);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.btn_add_site);
            this.Controls.Add(this.label_link2);
            this.Controls.Add(this.label_link1);
            this.Controls.Add(this.txt_link2);
            this.Controls.Add(this.txt_link1);
            this.Name = "HostsEditor";
            this.Text = "HostsEditor";
            this.Load += new System.EventHandler(this.HostsEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_link1;
        private System.Windows.Forms.TextBox txt_link2;
        private System.Windows.Forms.Label label_link1;
        private System.Windows.Forms.Label label_link2;
        private System.Windows.Forms.Button btn_add_site;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox txt_address;
    }
}