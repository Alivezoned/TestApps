namespace ChessAlivezoned
{
    partial class Form1
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
            this.b1_1 = new System.Windows.Forms.Button();
            this.b1_2 = new System.Windows.Forms.Button();
            this.b1_3 = new System.Windows.Forms.Button();
            this.b2_2 = new System.Windows.Forms.Button();
            this.b2_3 = new System.Windows.Forms.Button();
            this.b2_1 = new System.Windows.Forms.Button();
            this.b3_1 = new System.Windows.Forms.Button();
            this.b3_3 = new System.Windows.Forms.Button();
            this.b3_2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_turn = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label_player1 = new System.Windows.Forms.Label();
            this.label_player2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b1_1
            // 
            this.b1_1.Location = new System.Drawing.Point(12, 12);
            this.b1_1.Name = "b1_1";
            this.b1_1.Size = new System.Drawing.Size(75, 60);
            this.b1_1.TabIndex = 0;
            this.b1_1.UseVisualStyleBackColor = true;
            this.b1_1.Click += new System.EventHandler(this.button_clicked);
            // 
            // b1_2
            // 
            this.b1_2.Location = new System.Drawing.Point(93, 12);
            this.b1_2.Name = "b1_2";
            this.b1_2.Size = new System.Drawing.Size(75, 60);
            this.b1_2.TabIndex = 1;
            this.b1_2.UseVisualStyleBackColor = true;
            this.b1_2.Click += new System.EventHandler(this.button_clicked);
            // 
            // b1_3
            // 
            this.b1_3.Location = new System.Drawing.Point(174, 12);
            this.b1_3.Name = "b1_3";
            this.b1_3.Size = new System.Drawing.Size(75, 60);
            this.b1_3.TabIndex = 2;
            this.b1_3.UseVisualStyleBackColor = true;
            this.b1_3.Click += new System.EventHandler(this.button_clicked);
            // 
            // b2_2
            // 
            this.b2_2.Location = new System.Drawing.Point(93, 78);
            this.b2_2.Name = "b2_2";
            this.b2_2.Size = new System.Drawing.Size(75, 60);
            this.b2_2.TabIndex = 3;
            this.b2_2.UseVisualStyleBackColor = true;
            this.b2_2.Click += new System.EventHandler(this.button_clicked);
            // 
            // b2_3
            // 
            this.b2_3.Location = new System.Drawing.Point(174, 78);
            this.b2_3.Name = "b2_3";
            this.b2_3.Size = new System.Drawing.Size(75, 60);
            this.b2_3.TabIndex = 4;
            this.b2_3.UseVisualStyleBackColor = true;
            this.b2_3.Click += new System.EventHandler(this.button_clicked);
            // 
            // b2_1
            // 
            this.b2_1.Location = new System.Drawing.Point(12, 78);
            this.b2_1.Name = "b2_1";
            this.b2_1.Size = new System.Drawing.Size(75, 60);
            this.b2_1.TabIndex = 5;
            this.b2_1.UseVisualStyleBackColor = true;
            this.b2_1.Click += new System.EventHandler(this.button_clicked);
            // 
            // b3_1
            // 
            this.b3_1.Location = new System.Drawing.Point(12, 144);
            this.b3_1.Name = "b3_1";
            this.b3_1.Size = new System.Drawing.Size(75, 60);
            this.b3_1.TabIndex = 8;
            this.b3_1.UseVisualStyleBackColor = true;
            this.b3_1.Click += new System.EventHandler(this.button_clicked);
            // 
            // b3_3
            // 
            this.b3_3.Location = new System.Drawing.Point(174, 144);
            this.b3_3.Name = "b3_3";
            this.b3_3.Size = new System.Drawing.Size(75, 60);
            this.b3_3.TabIndex = 7;
            this.b3_3.UseVisualStyleBackColor = true;
            this.b3_3.Click += new System.EventHandler(this.button_clicked);
            // 
            // b3_2
            // 
            this.b3_2.Location = new System.Drawing.Point(93, 144);
            this.b3_2.Name = "b3_2";
            this.b3_2.Size = new System.Drawing.Size(75, 60);
            this.b3_2.TabIndex = 6;
            this.b3_2.UseVisualStyleBackColor = true;
            this.b3_2.Click += new System.EventHandler(this.button_clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_player2);
            this.groupBox1.Controls.Add(this.label_player1);
            this.groupBox1.Controls.Add(this.label_turn);
            this.groupBox1.Location = new System.Drawing.Point(273, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 192);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // label_turn
            // 
            this.label_turn.AutoSize = true;
            this.label_turn.Location = new System.Drawing.Point(7, 173);
            this.label_turn.Name = "label_turn";
            this.label_turn.Size = new System.Drawing.Size(37, 13);
            this.label_turn.TabIndex = 0;
            this.label_turn.Text = "Turns:";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(12, 210);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(236, 23);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label_player1
            // 
            this.label_player1.AutoSize = true;
            this.label_player1.Location = new System.Drawing.Point(7, 29);
            this.label_player1.Name = "label_player1";
            this.label_player1.Size = new System.Drawing.Size(57, 13);
            this.label_player1.TabIndex = 1;
            this.label_player1.Text = "Player 1: 0";
            // 
            // label_player2
            // 
            this.label_player2.AutoSize = true;
            this.label_player2.Location = new System.Drawing.Point(10, 84);
            this.label_player2.Name = "label_player2";
            this.label_player2.Size = new System.Drawing.Size(57, 13);
            this.label_player2.TabIndex = 2;
            this.label_player2.Text = "Player 2: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 382);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b3_1);
            this.Controls.Add(this.b3_3);
            this.Controls.Add(this.b3_2);
            this.Controls.Add(this.b2_1);
            this.Controls.Add(this.b2_3);
            this.Controls.Add(this.b2_2);
            this.Controls.Add(this.b1_3);
            this.Controls.Add(this.b1_2);
            this.Controls.Add(this.b1_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1_1;
        private System.Windows.Forms.Button b1_2;
        private System.Windows.Forms.Button b1_3;
        private System.Windows.Forms.Button b2_2;
        private System.Windows.Forms.Button b2_3;
        private System.Windows.Forms.Button b2_1;
        private System.Windows.Forms.Button b3_1;
        private System.Windows.Forms.Button b3_3;
        private System.Windows.Forms.Button b3_2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_turn;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label_player2;
        private System.Windows.Forms.Label label_player1;
    }
}

