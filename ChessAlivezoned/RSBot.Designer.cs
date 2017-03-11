namespace ChessAlivezoned
{
    partial class RSBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSBot));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_start_botting = new System.Windows.Forms.Button();
            this.txt_access_bank_sec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_click_time = new System.Windows.Forms.Label();
            this.label_inventory_time = new System.Windows.Forms.Label();
            this.label_script_time = new System.Windows.Forms.Label();
            this.label_act_interval = new System.Windows.Forms.Label();
            this.label_fast_click = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChessAlivezoned.Properties.Resources.RsBotLog;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seconds :";
            // 
            // button_start_botting
            // 
            this.button_start_botting.Location = new System.Drawing.Point(126, 66);
            this.button_start_botting.Name = "button_start_botting";
            this.button_start_botting.Size = new System.Drawing.Size(75, 23);
            this.button_start_botting.TabIndex = 2;
            this.button_start_botting.Text = "Start Botting";
            this.button_start_botting.UseVisualStyleBackColor = true;
            this.button_start_botting.Click += new System.EventHandler(this.button_start_botting_Click);
            // 
            // txt_access_bank_sec
            // 
            this.txt_access_bank_sec.Location = new System.Drawing.Point(123, 137);
            this.txt_access_bank_sec.Name = "txt_access_bank_sec";
            this.txt_access_bank_sec.Size = new System.Drawing.Size(100, 20);
            this.txt_access_bank_sec.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Access Bank After (in Seconds)";
            // 
            // label_click_time
            // 
            this.label_click_time.AutoSize = true;
            this.label_click_time.Location = new System.Drawing.Point(26, 207);
            this.label_click_time.Name = "label_click_time";
            this.label_click_time.Size = new System.Drawing.Size(62, 13);
            this.label_click_time.TabIndex = 5;
            this.label_click_time.Text = "Click Time :";
            // 
            // label_inventory_time
            // 
            this.label_inventory_time.AutoSize = true;
            this.label_inventory_time.Location = new System.Drawing.Point(26, 220);
            this.label_inventory_time.Name = "label_inventory_time";
            this.label_inventory_time.Size = new System.Drawing.Size(83, 13);
            this.label_inventory_time.TabIndex = 6;
            this.label_inventory_time.Text = "Inventory Time :";
            // 
            // label_script_time
            // 
            this.label_script_time.AutoSize = true;
            this.label_script_time.Location = new System.Drawing.Point(103, 12);
            this.label_script_time.Name = "label_script_time";
            this.label_script_time.Size = new System.Drawing.Size(78, 13);
            this.label_script_time.TabIndex = 7;
            this.label_script_time.Text = "Script Interval :";
            // 
            // label_act_interval
            // 
            this.label_act_interval.AutoSize = true;
            this.label_act_interval.Location = new System.Drawing.Point(26, 233);
            this.label_act_interval.Name = "label_act_interval";
            this.label_act_interval.Size = new System.Drawing.Size(85, 13);
            this.label_act_interval.TabIndex = 8;
            this.label_act_interval.Text = "Activity Interval :";
            // 
            // label_fast_click
            // 
            this.label_fast_click.AutoSize = true;
            this.label_fast_click.Location = new System.Drawing.Point(188, 233);
            this.label_fast_click.Name = "label_fast_click";
            this.label_fast_click.Size = new System.Drawing.Size(97, 13);
            this.label_fast_click.TabIndex = 9;
            this.label_fast_click.Text = "Fast Click Interval :";
            // 
            // RSBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 289);
            this.Controls.Add(this.label_fast_click);
            this.Controls.Add(this.label_act_interval);
            this.Controls.Add(this.label_script_time);
            this.Controls.Add(this.label_inventory_time);
            this.Controls.Add(this.label_click_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_access_bank_sec);
            this.Controls.Add(this.button_start_botting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RSBot";
            this.Text = "RSBot";
            this.Load += new System.EventHandler(this.RSBot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_start_botting;
        private System.Windows.Forms.TextBox txt_access_bank_sec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_click_time;
        private System.Windows.Forms.Label label_inventory_time;
        private System.Windows.Forms.Label label_script_time;
        private System.Windows.Forms.Label label_act_interval;
        private System.Windows.Forms.Label label_fast_click;
    }
}