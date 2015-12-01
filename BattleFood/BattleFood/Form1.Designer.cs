namespace BattleFood
{
    partial class frm_play
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_player2 = new System.Windows.Forms.Panel();
            this.pbox_player2 = new System.Windows.Forms.PictureBox();
            this.pbox_health2 = new System.Windows.Forms.PictureBox();
            this.lbl_name2 = new System.Windows.Forms.Label();
            this.pnl_player1 = new System.Windows.Forms.Panel();
            this.pbox_player1 = new System.Windows.Forms.PictureBox();
            this.pbox_health1 = new System.Windows.Forms.PictureBox();
            this.lbl_name1 = new System.Windows.Forms.Label();
            this.tmr_animateImage = new System.Windows.Forms.Timer(this.components);
            this.tmr_schiessen1 = new System.Windows.Forms.Timer(this.components);
            this.pbox_kugel1 = new System.Windows.Forms.PictureBox();
            this.pbox_kugel2 = new System.Windows.Forms.PictureBox();
            this.tmr_schiessen2 = new System.Windows.Forms.Timer(this.components);
            this.tmr_jump = new System.Windows.Forms.Timer(this.components);
            this.tmr_falldown1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_falldown2 = new System.Windows.Forms.Timer(this.components);
            this.pnl_player2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_health2)).BeginInit();
            this.pnl_player1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_health1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_kugel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_kugel2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_player2
            // 
            this.pnl_player2.BackColor = System.Drawing.Color.Transparent;
            this.pnl_player2.Controls.Add(this.pbox_player2);
            this.pnl_player2.Controls.Add(this.pbox_health2);
            this.pnl_player2.Controls.Add(this.lbl_name2);
            this.pnl_player2.Location = new System.Drawing.Point(841, 307);
            this.pnl_player2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_player2.Name = "pnl_player2";
            this.pnl_player2.Size = new System.Drawing.Size(90, 154);
            this.pnl_player2.TabIndex = 4;
            // 
            // pbox_player2
            // 
            this.pbox_player2.Location = new System.Drawing.Point(0, 62);
            this.pbox_player2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbox_player2.Name = "pbox_player2";
            this.pbox_player2.Size = new System.Drawing.Size(90, 92);
            this.pbox_player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_player2.TabIndex = 2;
            this.pbox_player2.TabStop = false;
            // 
            // pbox_health2
            // 
            this.pbox_health2.Location = new System.Drawing.Point(0, 38);
            this.pbox_health2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbox_health2.Name = "pbox_health2";
            this.pbox_health2.Size = new System.Drawing.Size(90, 23);
            this.pbox_health2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_health2.TabIndex = 1;
            this.pbox_health2.TabStop = false;
            // 
            // lbl_name2
            // 
            this.lbl_name2.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_name2.ForeColor = System.Drawing.Color.Black;
            this.lbl_name2.Location = new System.Drawing.Point(0, 0);
            this.lbl_name2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name2.Name = "lbl_name2";
            this.lbl_name2.Size = new System.Drawing.Size(90, 38);
            this.lbl_name2.TabIndex = 1;
            this.lbl_name2.Text = "Client";
            this.lbl_name2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_player1
            // 
            this.pnl_player1.BackColor = System.Drawing.Color.Transparent;
            this.pnl_player1.Controls.Add(this.pbox_player1);
            this.pnl_player1.Controls.Add(this.pbox_health1);
            this.pnl_player1.Controls.Add(this.lbl_name1);
            this.pnl_player1.Location = new System.Drawing.Point(90, 307);
            this.pnl_player1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_player1.Name = "pnl_player1";
            this.pnl_player1.Size = new System.Drawing.Size(90, 154);
            this.pnl_player1.TabIndex = 3;
            // 
            // pbox_player1
            // 
            this.pbox_player1.Location = new System.Drawing.Point(0, 62);
            this.pbox_player1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbox_player1.Name = "pbox_player1";
            this.pbox_player1.Size = new System.Drawing.Size(90, 92);
            this.pbox_player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_player1.TabIndex = 3;
            this.pbox_player1.TabStop = false;
            // 
            // pbox_health1
            // 
            this.pbox_health1.Location = new System.Drawing.Point(0, 38);
            this.pbox_health1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbox_health1.Name = "pbox_health1";
            this.pbox_health1.Size = new System.Drawing.Size(90, 23);
            this.pbox_health1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_health1.TabIndex = 1;
            this.pbox_health1.TabStop = false;
            // 
            // lbl_name1
            // 
            this.lbl_name1.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_name1.ForeColor = System.Drawing.Color.Black;
            this.lbl_name1.Location = new System.Drawing.Point(0, 0);
            this.lbl_name1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name1.Name = "lbl_name1";
            this.lbl_name1.Size = new System.Drawing.Size(90, 38);
            this.lbl_name1.TabIndex = 1;
            this.lbl_name1.Text = "Server";
            this.lbl_name1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_animateImage
            // 
            this.tmr_animateImage.Interval = 20;
            this.tmr_animateImage.Tick += new System.EventHandler(this.tmr_animateImage_Tick);
            // 
            // tmr_schiessen1
            // 
            this.tmr_schiessen1.Interval = 10;
            this.tmr_schiessen1.Tick += new System.EventHandler(this.tmr_schiessen1_Tick);
            // 
            // pbox_kugel1
            // 
            this.pbox_kugel1.BackColor = System.Drawing.Color.Transparent;
            this.pbox_kugel1.Location = new System.Drawing.Point(-30, -15);
            this.pbox_kugel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbox_kugel1.Name = "pbox_kugel1";
            this.pbox_kugel1.Size = new System.Drawing.Size(30, 15);
            this.pbox_kugel1.TabIndex = 5;
            this.pbox_kugel1.TabStop = false;
            // 
            // pbox_kugel2
            // 
            this.pbox_kugel2.BackColor = System.Drawing.Color.Transparent;
            this.pbox_kugel2.Location = new System.Drawing.Point(-30, -15);
            this.pbox_kugel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbox_kugel2.Name = "pbox_kugel2";
            this.pbox_kugel2.Size = new System.Drawing.Size(30, 15);
            this.pbox_kugel2.TabIndex = 6;
            this.pbox_kugel2.TabStop = false;
            // 
            // tmr_schiessen2
            // 
            this.tmr_schiessen2.Interval = 10;
            this.tmr_schiessen2.Tick += new System.EventHandler(this.tmr_schiessen2_Tick);
            // 
            // tmr_jump
            // 
            this.tmr_jump.Interval = 50;
            this.tmr_jump.Tick += new System.EventHandler(this.tmr_jump_Tick);
            // 
            // tmr_falldown1
            // 
            this.tmr_falldown1.Interval = 25;
            this.tmr_falldown1.Tick += new System.EventHandler(this.tmr_falldown1_Tick);
            // 
            // tmr_falldown2
            // 
            this.tmr_falldown2.Interval = 25;
            this.tmr_falldown2.Tick += new System.EventHandler(this.tmr_falldown2_Tick);
            // 
            // frm_play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pbox_kugel2);
            this.Controls.Add(this.pbox_kugel1);
            this.Controls.Add(this.pnl_player2);
            this.Controls.Add(this.pnl_player1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_play";
            this.Text = "na";
            this.Load += new System.EventHandler(this.frm_play_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_play_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_play_KeyUp);
            this.pnl_player2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_health2)).EndInit();
            this.pnl_player1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_health1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_kugel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_kugel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnl_player2;
        internal System.Windows.Forms.PictureBox pbox_player2;
        internal System.Windows.Forms.PictureBox pbox_health2;
        internal System.Windows.Forms.Label lbl_name2;
        internal System.Windows.Forms.Panel pnl_player1;
        internal System.Windows.Forms.PictureBox pbox_player1;
        internal System.Windows.Forms.PictureBox pbox_health1;
        internal System.Windows.Forms.Label lbl_name1;
        private System.Windows.Forms.Timer tmr_animateImage;
        private System.Windows.Forms.Timer tmr_schiessen1;
        internal System.Windows.Forms.PictureBox pbox_kugel1;
        internal System.Windows.Forms.PictureBox pbox_kugel2;
        private System.Windows.Forms.Timer tmr_schiessen2;
        private System.Windows.Forms.Timer tmr_jump;
        private System.Windows.Forms.Timer tmr_falldown1;
        private System.Windows.Forms.Timer tmr_falldown2;
    }
}

