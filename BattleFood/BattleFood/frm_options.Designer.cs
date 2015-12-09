namespace BattleFood
{
    partial class frm_options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_options));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.lbl_space = new System.Windows.Forms.Label();
            this.lbl_settings = new System.Windows.Forms.Label();
            this.lbl_controlls = new System.Windows.Forms.Label();
            this.lbl_right = new System.Windows.Forms.Label();
            this.lbl_left = new System.Windows.Forms.Label();
            this.cb_music = new System.Windows.Forms.CheckBox();
            this.lbl_backgroundmusic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(224, 589);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(105, 67);
            this.btn_back.TabIndex = 1;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_quit.BackgroundImage")));
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Location = new System.Drawing.Point(654, 589);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(105, 67);
            this.btn_quit.TabIndex = 2;
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // lbl_space
            // 
            this.lbl_space.AutoSize = true;
            this.lbl_space.BackColor = System.Drawing.Color.Transparent;
            this.lbl_space.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_space.ForeColor = System.Drawing.Color.White;
            this.lbl_space.Location = new System.Drawing.Point(534, 352);
            this.lbl_space.Name = "lbl_space";
            this.lbl_space.Size = new System.Drawing.Size(237, 25);
            this.lbl_space.TabIndex = 13;
            this.lbl_space.Text = "Leertaste = Schießen";
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.BackColor = System.Drawing.Color.Transparent;
            this.lbl_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settings.Location = new System.Drawing.Point(124, 105);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(238, 39);
            this.lbl_settings.TabIndex = 14;
            this.lbl_settings.Text = "Einstellungen";
            // 
            // lbl_controlls
            // 
            this.lbl_controlls.AutoSize = true;
            this.lbl_controlls.BackColor = System.Drawing.Color.Transparent;
            this.lbl_controlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_controlls.Location = new System.Drawing.Point(574, 105);
            this.lbl_controlls.Name = "lbl_controlls";
            this.lbl_controlls.Size = new System.Drawing.Size(185, 39);
            this.lbl_controlls.TabIndex = 15;
            this.lbl_controlls.Text = "Steuerung";
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.BackColor = System.Drawing.Color.Transparent;
            this.lbl_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_right.ForeColor = System.Drawing.Color.White;
            this.lbl_right.Location = new System.Drawing.Point(534, 430);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(348, 25);
            this.lbl_right.TabIndex = 16;
            this.lbl_right.Text = "Pfeiltaste rechts = Rechtslaufen";
            // 
            // lbl_left
            // 
            this.lbl_left.AutoSize = true;
            this.lbl_left.BackColor = System.Drawing.Color.Transparent;
            this.lbl_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_left.ForeColor = System.Drawing.Color.White;
            this.lbl_left.Location = new System.Drawing.Point(534, 267);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(315, 25);
            this.lbl_left.TabIndex = 17;
            this.lbl_left.Text = "Pfeiltaste links = Linkslaufen";
            // 
            // cb_music
            // 
            this.cb_music.AutoSize = true;
            this.cb_music.Location = new System.Drawing.Point(347, 267);
            this.cb_music.Name = "cb_music";
            this.cb_music.Size = new System.Drawing.Size(15, 14);
            this.cb_music.TabIndex = 18;
            this.cb_music.UseVisualStyleBackColor = true;
            this.cb_music.CheckedChanged += new System.EventHandler(this.cb_music_CheckedChanged);
            // 
            // lbl_backgroundmusic
            // 
            this.lbl_backgroundmusic.AutoSize = true;
            this.lbl_backgroundmusic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_backgroundmusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_backgroundmusic.ForeColor = System.Drawing.Color.White;
            this.lbl_backgroundmusic.Location = new System.Drawing.Point(126, 258);
            this.lbl_backgroundmusic.Name = "lbl_backgroundmusic";
            this.lbl_backgroundmusic.Size = new System.Drawing.Size(203, 25);
            this.lbl_backgroundmusic.TabIndex = 19;
            this.lbl_backgroundmusic.Text = "Hintergrundmusik:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lbl_backgroundmusic);
            this.Controls.Add(this.cb_music);
            this.Controls.Add(this.lbl_left);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_controlls);
            this.Controls.Add(this.lbl_settings);
            this.Controls.Add(this.lbl_space);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_back;
        internal System.Windows.Forms.Button btn_quit;
        internal System.Windows.Forms.Label lbl_space;
        internal System.Windows.Forms.Label lbl_settings;
        internal System.Windows.Forms.Label lbl_controlls;
        internal System.Windows.Forms.Label lbl_right;
        internal System.Windows.Forms.Label lbl_left;
        internal System.Windows.Forms.CheckBox cb_music;
        internal System.Windows.Forms.Label lbl_backgroundmusic;
    }
}