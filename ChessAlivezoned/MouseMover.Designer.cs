namespace ChessAlivezoned
{
    partial class MouseMover
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_record = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop_timer = new System.Windows.Forms.Button();
            this.button_mouse_arc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(37, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(462, 195);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btn_record
            // 
            this.btn_record.Location = new System.Drawing.Point(37, 12);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(150, 23);
            this.btn_record.TabIndex = 2;
            this.btn_record.Text = "Record";
            this.btn_record.UseVisualStyleBackColor = true;
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(193, 12);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(150, 23);
            this.btn_play.TabIndex = 3;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop_timer
            // 
            this.btn_stop_timer.Location = new System.Drawing.Point(349, 12);
            this.btn_stop_timer.Name = "btn_stop_timer";
            this.btn_stop_timer.Size = new System.Drawing.Size(150, 23);
            this.btn_stop_timer.TabIndex = 4;
            this.btn_stop_timer.Text = "Stop Timer";
            this.btn_stop_timer.UseVisualStyleBackColor = true;
            this.btn_stop_timer.Click += new System.EventHandler(this.btn_stop_timer_Click);
            // 
            // button_mouse_arc
            // 
            this.button_mouse_arc.Location = new System.Drawing.Point(145, 242);
            this.button_mouse_arc.Name = "button_mouse_arc";
            this.button_mouse_arc.Size = new System.Drawing.Size(150, 23);
            this.button_mouse_arc.TabIndex = 5;
            this.button_mouse_arc.Text = "Mouse Arc";
            this.button_mouse_arc.UseVisualStyleBackColor = true;
            this.button_mouse_arc.Click += new System.EventHandler(this.button_mouse_arc_Click);
            // 
            // MouseMover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 414);
            this.Controls.Add(this.button_mouse_arc);
            this.Controls.Add(this.btn_stop_timer);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_record);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MouseMover";
            this.Text = "MouseMover";
            this.Load += new System.EventHandler(this.MouseMover_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop_timer;
        private System.Windows.Forms.Button button_mouse_arc;
    }
}