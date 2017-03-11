namespace ChessAlivezoned
{
    partial class Rune
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rune));
            this.label_minute = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_xp_gained = new System.Windows.Forms.TextBox();
            this.label_xp_gained = new System.Windows.Forms.Label();
            this.label_xp_hour = new System.Windows.Forms.Label();
            this.btn_show_on_top = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.button_min = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_minute
            // 
            this.label_minute.AutoSize = true;
            this.label_minute.Font = new System.Drawing.Font("BankGothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minute.ForeColor = System.Drawing.Color.White;
            this.label_minute.Location = new System.Drawing.Point(5, 38);
            this.label_minute.Name = "label_minute";
            this.label_minute.Size = new System.Drawing.Size(196, 28);
            this.label_minute.TabIndex = 0;
            this.label_minute.Text = "00 : 00 : 00";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))), ((int)(((byte)(112)))));
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("BankGothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(12, 82);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(74, 23);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(140)))));
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("BankGothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(114, 82);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(74, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_xp_gained
            // 
            this.txt_xp_gained.Font = new System.Drawing.Font("BankGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xp_gained.Location = new System.Drawing.Point(10, 139);
            this.txt_xp_gained.Name = "txt_xp_gained";
            this.txt_xp_gained.Size = new System.Drawing.Size(178, 21);
            this.txt_xp_gained.TabIndex = 3;
            // 
            // label_xp_gained
            // 
            this.label_xp_gained.AutoSize = true;
            this.label_xp_gained.Font = new System.Drawing.Font("BankGothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_xp_gained.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_xp_gained.Location = new System.Drawing.Point(10, 123);
            this.label_xp_gained.Name = "label_xp_gained";
            this.label_xp_gained.Size = new System.Drawing.Size(86, 14);
            this.label_xp_gained.TabIndex = 5;
            this.label_xp_gained.Text = "XP Gained";
            // 
            // label_xp_hour
            // 
            this.label_xp_hour.AutoSize = true;
            this.label_xp_hour.Font = new System.Drawing.Font("AR CENA", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_xp_hour.ForeColor = System.Drawing.Color.White;
            this.label_xp_hour.Location = new System.Drawing.Point(10, 162);
            this.label_xp_hour.Name = "label_xp_hour";
            this.label_xp_hour.Size = new System.Drawing.Size(57, 18);
            this.label_xp_hour.TabIndex = 6;
            this.label_xp_hour.Text = "xp / h :";
            // 
            // btn_show_on_top
            // 
            this.btn_show_on_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_show_on_top.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_show_on_top.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_show_on_top.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_show_on_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_on_top.Font = new System.Drawing.Font("BankGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_on_top.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_show_on_top.Location = new System.Drawing.Point(10, 191);
            this.btn_show_on_top.Name = "btn_show_on_top";
            this.btn_show_on_top.Size = new System.Drawing.Size(178, 23);
            this.btn_show_on_top.TabIndex = 7;
            this.btn_show_on_top.Text = "Show on top";
            this.btn_show_on_top.UseVisualStyleBackColor = false;
            this.btn_show_on_top.Click += new System.EventHandler(this.btn_show_on_top_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel_top.Controls.Add(this.button_min);
            this.panel_top.Controls.Add(this.button_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(201, 24);
            this.panel_top.TabIndex = 8;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // button_min
            // 
            this.button_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button_min.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_min.Location = new System.Drawing.Point(149, 0);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(25, 24);
            this.button_min.TabIndex = 1;
            this.button_min.Text = "--";
            this.button_min.UseVisualStyleBackColor = false;
            this.button_min.Click += new System.EventHandler(this.button_min_Click_1);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_close.Location = new System.Drawing.Point(174, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(27, 24);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Rune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(201, 224);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.btn_show_on_top);
            this.Controls.Add(this.label_xp_hour);
            this.Controls.Add(this.label_xp_gained);
            this.Controls.Add(this.txt_xp_gained);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label_minute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rune";
            this.Text = "Rune Xp";
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_minute;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_xp_gained;
        private System.Windows.Forms.Label label_xp_gained;
        private System.Windows.Forms.Label label_xp_hour;
        private System.Windows.Forms.Button btn_show_on_top;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_close;
    }
}