namespace BattleFood
{
    partial class frm_start
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_options = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundImage = global::BattleFood.Properties.Resources.Startbutton;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Location = new System.Drawing.Point(228, 653);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(105, 67);
            this.btn_start.TabIndex = 0;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_options
            // 
            this.btn_options.BackColor = System.Drawing.Color.Transparent;
            this.btn_options.BackgroundImage = global::BattleFood.Properties.Resources.Optionen;
            this.btn_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_options.FlatAppearance.BorderSize = 0;
            this.btn_options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_options.Location = new System.Drawing.Point(469, 653);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(105, 67);
            this.btn_options.TabIndex = 1;
            this.btn_options.UseVisualStyleBackColor = false;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_quit.BackgroundImage = global::BattleFood.Properties.Resources.Beenden;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Location = new System.Drawing.Point(711, 653);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(105, 67);
            this.btn_quit.TabIndex = 2;
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // frm_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BattleFood.Properties.Resources.Hauptmenü;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_start";
            this.Load += new System.EventHandler(this.frm_start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_options;
        private System.Windows.Forms.Button btn_quit;
    }
}