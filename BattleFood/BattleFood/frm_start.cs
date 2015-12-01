using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleFood
{
    public partial class frm_start : Form
    {
        public frm_start()
        {
            InitializeComponent();
        }

        //Verbirgt die aktuelle FOrm und ruft die Netzwerk form auf
        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_network.show();
        }

        //Öffnet die Optionen
        private void btn_options_Click(object sender, EventArgs e)
        {
            frm_options.ShowDialog();
        }

        //Beendet die Anwendung
        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_start_Load(object sender, EventArgs e)
        {
            musicthread = new Threading.Thread(playmusic);
        }
        void playmusic()
        {
            if(Properties.Settings.music_on)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(new MemoryStream(Properties.Resources.frametraxx_Manga_Action));
                frm_options.music_playing = Properties.Settings.music_on;
                player.Load();
                player.Play(); 
            }
        }
    }
}
