using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BattleFood
{
   
    public partial class frm_options : Form
    {
        
        public frm_options()
        {
            InitializeComponent();
            
        }

        private void cb_music_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer backgroundmusic = new SoundPlayer(Properties.Resources.frametraxx_Manga_Action);
            Boolean music_playing = false;
            Properties.Settings.Default.music_on = cb_music.Checked;
            if(Properties.Settings.Default.music_on)
            {
                music_playing = true;
                backgroundmusic.Play();
            }
            else
            {
                music_playing = false;
                backgroundmusic.Stop();
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
