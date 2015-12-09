namespace BattleFood
{
    partial class frm_network
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_network));
            this.txt_sendip = new System.Windows.Forms.TextBox();
            this.lbl_sendip = new System.Windows.Forms.Label();
            this.lbl_multiplayer = new System.Windows.Forms.Label();
            this.lbl_oder = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_host = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sendip
            // 
            this.txt_sendip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_sendip.Location = new System.Drawing.Point(247, 214);
            this.txt_sendip.Name = "txt_sendip";
            this.txt_sendip.Size = new System.Drawing.Size(164, 31);
            this.txt_sendip.TabIndex = 7;
            // 
            // lbl_sendip
            // 
            this.lbl_sendip.AutoSize = true;
            this.lbl_sendip.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sendip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_sendip.ForeColor = System.Drawing.Color.White;
            this.lbl_sendip.Location = new System.Drawing.Point(147, 214);
            this.lbl_sendip.Name = "lbl_sendip";
            this.lbl_sendip.Size = new System.Drawing.Size(40, 25);
            this.lbl_sendip.TabIndex = 8;
            this.lbl_sendip.Text = "IP:";
            // 
            // lbl_multiplayer
            // 
            this.lbl_multiplayer.AutoSize = true;
            this.lbl_multiplayer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_multiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_multiplayer.ForeColor = System.Drawing.Color.White;
            this.lbl_multiplayer.Location = new System.Drawing.Point(158, 60);
            this.lbl_multiplayer.Name = "lbl_multiplayer";
            this.lbl_multiplayer.Size = new System.Drawing.Size(156, 31);
            this.lbl_multiplayer.TabIndex = 9;
            this.lbl_multiplayer.Text = "Multiplayer";
            // 
            // lbl_oder
            // 
            this.lbl_oder.AutoSize = true;
            this.lbl_oder.BackColor = System.Drawing.Color.Transparent;
            this.lbl_oder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_oder.ForeColor = System.Drawing.Color.White;
            this.lbl_oder.Location = new System.Drawing.Point(351, 314);
            this.lbl_oder.Name = "lbl_oder";
            this.lbl_oder.Size = new System.Drawing.Size(97, 31);
            this.lbl_oder.TabIndex = 10;
            this.lbl_oder.Text = "ODER";
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Transparent;
            this.btn_connect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_connect.BackgroundImage")));
            this.btn_connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_connect.FlatAppearance.BorderSize = 0;
            this.btn_connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Location = new System.Drawing.Point(500, 196);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(124, 67);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_host
            // 
            this.btn_host.BackColor = System.Drawing.Color.Transparent;
            this.btn_host.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_host.BackgroundImage")));
            this.btn_host.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_host.FlatAppearance.BorderSize = 0;
            this.btn_host.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_host.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_host.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_host.Location = new System.Drawing.Point(348, 415);
            this.btn_host.Name = "btn_host";
            this.btn_host.Size = new System.Drawing.Size(124, 67);
            this.btn_host.TabIndex = 5;
            this.btn_host.UseVisualStyleBackColor = false;
            this.btn_host.Click += new System.EventHandler(this.btn_host_Click);
            // 
            // frm_network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BattleFood.Properties.Resources.VerbindenFull;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lbl_oder);
            this.Controls.Add(this.lbl_multiplayer);
            this.Controls.Add(this.lbl_sendip);
            this.Controls.Add(this.txt_sendip);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_host);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_network";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_network";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_host;
        internal System.Windows.Forms.Button btn_connect;
        internal System.Windows.Forms.TextBox txt_sendip;
        internal System.Windows.Forms.Label lbl_sendip;
        internal System.Windows.Forms.Label lbl_multiplayer;
        internal System.Windows.Forms.Label lbl_oder;
    }
}