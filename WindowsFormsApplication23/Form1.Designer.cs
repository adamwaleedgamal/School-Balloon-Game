namespace WindowsFormsApplication23
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
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.Arrow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.b_1 = new System.Windows.Forms.PictureBox();
            this.b_2 = new System.Windows.Forms.PictureBox();
            this.b_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::WindowsFormsApplication23.Properties.Resources.idle;
            this.player.Location = new System.Drawing.Point(72, 133);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(105, 124);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // Arrow
            // 
            this.Arrow.Image = global::WindowsFormsApplication23.Properties.Resources.arrow;
            this.Arrow.Location = new System.Drawing.Point(220, 187);
            this.Arrow.Margin = new System.Windows.Forms.Padding(4);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(63, 17);
            this.Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Arrow.TabIndex = 0;
            this.Arrow.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // b_1
            // 
            this.b_1.Image = global::WindowsFormsApplication23.Properties.Resources.balloon_1;
            this.b_1.Location = new System.Drawing.Point(744, 347);
            this.b_1.Margin = new System.Windows.Forms.Padding(4);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(31, 45);
            this.b_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b_1.TabIndex = 0;
            this.b_1.TabStop = false;
            // 
            // b_2
            // 
            this.b_2.Image = global::WindowsFormsApplication23.Properties.Resources.balloon_2;
            this.b_2.Location = new System.Drawing.Point(595, 374);
            this.b_2.Margin = new System.Windows.Forms.Padding(4);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(31, 45);
            this.b_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b_2.TabIndex = 0;
            this.b_2.TabStop = false;
            // 
            // b_3
            // 
            this.b_3.Image = global::WindowsFormsApplication23.Properties.Resources.balloon_3;
            this.b_3.Location = new System.Drawing.Point(476, 326);
            this.b_3.Margin = new System.Windows.Forms.Padding(4);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(31, 45);
            this.b_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b_3.TabIndex = 0;
            this.b_3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(4, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(908, 62);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Black;
            this.lbl_score.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.Red;
            this.lbl_score.Location = new System.Drawing.Point(64, 11);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(40, 41);
            this.lbl_score.TabIndex = 2;
            this.lbl_score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 434);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.b_3);
            this.Controls.Add(this.b_2);
            this.Controls.Add(this.b_1);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.player);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(927, 481);
            this.MinimumSize = new System.Drawing.Size(927, 481);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Arrow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox b_1;
        private System.Windows.Forms.PictureBox b_2;
        private System.Windows.Forms.PictureBox b_3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_score;
    }
}

