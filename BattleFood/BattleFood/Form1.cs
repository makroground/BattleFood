using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleFood
{
    public partial class frm_play : Form
    {
        public cls_network networkConnection = new cls_network;
        private String result = "";
        public Boolean isServer = false;

        private int positionXinMap = 0;
        private Image map_background;

        private enum Team
        {
            Player1,
            Player2
        }

        private enum PlayerImage
        {
            Potato,
            Melone,
            Onion
        }

        private Team currentPlayer;
        private PlayerImage currentPlayerImage;
        private Boolean initSend = true;

        private PlayerImage player1_image = PlayerImage.Potato;
        private Boolean player1_laufeRechts = true;
        private int player1_health = 100;
        private Point player1_position;
        private int player1_curRunPos = 0;
        private Boolean player1_jump = false;

        private PlayerImage player2_image = PlayerImage.Potato;
        private Boolean player2_laufeRechts = true;
        private int player2_health = 100;
        private Point player2_position;
        private int player2_curRunPos = 0;
        private Boolean player2_jump = false;

        private Boolean schuss1_nachRechts = true;
        private Boolean schuss2_nachRechts = true;

        private Image[] p_laufenImage = new Image[5];
        private Image[] p_laufenImageI = new Image[5];
        private Image[] m_laufenImage = new Image[5];
        private Image[] m_laufenImageI = new Image[5];
        private Image[] o_laufenImage = new Image[5];
        private Image[] o_laufenImageI = new Image[5];

        // Variablen für die fallenden Objekte:
        private int PositionX, PositionY;
        private Queue picbox = new Queue();
        private int frequency = 1;
        private Random rnd = new Random();

        public frm_play()
        {
            InitializeComponent();
        }

        private void frm_play_Load(object sender, EventArgs e)
        {
            InitialImages();

        }

        private void InitialImages()
        {
            map_background = Properties.Resources.de_kitchen2_final;
            BackgroundImage = map_background;

            player1_position = new Point(150, ClientSize.Height - pnl_player1.Height - 180);
            pnl_player1.Location = player1_position;
            switch (player1_image)
            {
                case PlayerImage.Potato:
                    pbox_player1.Image = spiegelImage(Properties.Resources.p_normal);
                    break;
                case PlayerImage.Melone:
                    pbox_player1.Image = spiegelImage(Properties.Resources.m_normal);
                    break;
                case PlayerImage.Onion:
                    pbox_player1.Image = spiegelImage(Properties.Resources.o_normal);
                    break;
            }

            player2_position = new Point(ClientSize.Width - pnl_player2.Width - 150, ClientSize.Height - pnl_player2.Height - 180);
            pnl_player2.Location = player2_position;
            switch (player2_image)
            {
                case PlayerImage.Potato:
                    pbox_player2.Image = spiegelImage(Properties.Resources.p_normal);
                    break;
                case PlayerImage.Melone:
                    pbox_player2.Image = spiegelImage(Properties.Resources.m_normal);
                    break;
                case PlayerImage.Onion:
                    pbox_player2.Image = spiegelImage(Properties.Resources.o_normal);
                    break;
            }

            p_laufenImage[0] = (Image)Properties.Resources.ResourceManager.GetObject("p_lfn_" + 0);
            p_laufenImage[1] = (Image)Properties.Resources.ResourceManager.GetObject("p_lfn_" + 1);
            p_laufenImage[2] = (Image)Properties.Resources.ResourceManager.GetObject("p_lfn_" + 2);
            p_laufenImage[3] = (Image)Properties.Resources.ResourceManager.GetObject("p_lfn_" + 3);
            p_laufenImage[4] = (Image)Properties.Resources.ResourceManager.GetObject("p_lfn_" + 4);

            p_laufenImage[0] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("p_lfn_" + 0));
            p_laufenImage[1] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("p_lfn_" + 1));
            p_laufenImage[2] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("p_lfn_" + 2));
            p_laufenImage[3] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("p_lfn_" + 3));
            p_laufenImage[4] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("p_lfn_" + 4));

            p_laufenImage[0] = (Image)Properties.Resources.ResourceManager.GetObject("m_lfn_" + 0);
            p_laufenImage[1] = (Image)Properties.Resources.ResourceManager.GetObject("m_lfn_" + 1);
            p_laufenImage[2] = (Image)Properties.Resources.ResourceManager.GetObject("m_lfn_" + 2);
            p_laufenImage[3] = (Image)Properties.Resources.ResourceManager.GetObject("m_lfn_" + 3);
            p_laufenImage[4] = (Image)Properties.Resources.ResourceManager.GetObject("m_lfn_" + 4);

            p_laufenImage[0] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("m_lfn_" + 0));
            p_laufenImage[1] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("m_lfn_" + 1));
            p_laufenImage[2] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("m_lfn_" + 2));
            p_laufenImage[3] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("m_lfn_" + 3));
            p_laufenImage[4] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("m_lfn_" + 4));

            p_laufenImage[0] = (Image)Properties.Resources.ResourceManager.GetObject("o_lfn_" + 0);
            p_laufenImage[1] = (Image)Properties.Resources.ResourceManager.GetObject("o_lfn_" + 1);
            p_laufenImage[2] = (Image)Properties.Resources.ResourceManager.GetObject("o_lfn_" + 2);
            p_laufenImage[3] = (Image)Properties.Resources.ResourceManager.GetObject("o_lfn_" + 3);
            p_laufenImage[4] = (Image)Properties.Resources.ResourceManager.GetObject("o_lfn_" + 4);

            p_laufenImage[0] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("o_lfn_" + 0));
            p_laufenImage[1] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("o_lfn_" + 1));
            p_laufenImage[2] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("o_lfn_" + 2));
            p_laufenImage[3] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("o_lfn_" + 3));
            p_laufenImage[4] = spiegelImage((Image)Properties.Resources.ResourceManager.GetObject("o_lfn_" + 4));
        }
        
        private Image spiegelImage(Image img)
        {
            Image image = img;
            image.RotateFlip(RotateFlipType.Rotate180FlipY);
            return image;
        }

        private void spiegelPictureBox(PictureBox pbox)
        {
            Image image = pbox.Image;
            image.RotateFlip(RotateFlipType.Rotate180FlipY);
            pbox.Image = image;
        }

        private void frm_play_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    switch (currentPlayer)
                    {
                        case Team.Player1:
                            if (player1_health > 0)
                            {
                                player1_laufeRechts = true;
                                tmr_animateImage.Start();
                            }
                            break;
                        case Team.Player2:
                            if (player2_health > 0)
                            {
                                player2_laufeRechts = true;
                                tmr_animateImage.Start();
                            }
                            break;
                    }
                    break;
                case Keys.Left:
                    switch (currentPlayer)
                    {
                        case Team.Player1:
                            if (player1_health > 0)
                            {
                                player1_laufeRechts = false;
                                tmr_animateImage.Start();
                            }
                            break;
                        case Team.Player2:
                            if (player2_health > 0)
                            {
                                player2_laufeRechts = false;
                                tmr_animateImage.Start();
                            }
                            break;
                    }
                    break;
                case Keys.Escape:
                    frm_options.Show();
                    break;
                case Keys.Space:
                    switch (currentPlayer)
                    {
                        case Team.Player1:
                            if (tmr_schiessen1.Enabled == false)
                            {
                                schuss1_nachRechts = true;
                                pbox_kugel1.Location = new Point(pnl_player1.Location.X + 70, pnl_player1.Location.Y + 80);
                                pbox_kugel1.Image = Properties.Resources.bulletrechts;
                            }
                            else
                            {
                                schuss1_nachRechts = false;
                                pbox_kugel1.Location = new Point(pnl_player1.Location.X - 30, pnl_player1.Location.Y + 80);
                                pbox_kugel1.Image = spiegelImage(Properties.Resources.bulletrechts);
                            }
                            tmr_schiessen1.Start();
                            break;
                        case Team.Player2:
                            if (tmr_schiessen2.Enabled == false)
                            {
                                schuss2_nachRechts = true;
                                pbox_kugel2.Location = new Point(pnl_player2.Location.X + 70, pnl_player2.Location.Y + 80);
                                pbox_kugel2.Image = Properties.Resources.bulletrechts;
                            }
                            else
                            {
                                schuss2_nachRechts = false;
                                pbox_kugel2.Location = new Point(pnl_player2.Location.X - 30, pnl_player2.Location.Y + 80);
                                pbox_kugel2.Image = spiegelImage(Properties.Resources.bulletrechts);
                            }
                            tmr_schiessen2.Start();
                            break;
                    }
                    break;
                case Keys.Up:
                    switch (currentPlayer)
                    {
                        case Team.Player1:
                            if (tmr_jump.Enabled == false)
                            {
                                player1_jump = true;
                                tmr_jump.Start();
                            }
                            break;
                        case Team.Player2:
                            if (tmr_jump.Enabled == false)
                            {
                                player2_jump = true;
                                tmr_jump.Start();
                            }
                            break;
                    }
                    break;
            }

            switch (currentPlayer)
            {
                case Team.Player1:
                    if (IsOutOfTable(pnl_player1))
                    {
                        if (tmr_animateImage.Enabled)
                        {
                            tmr_animateImage.Stop();
                        }
                        if (tmr_falldown1.Enabled = false)
                        {
                            player1_health = 0;
                            SetzeLebensAnzeige(pbox_health1, pbox_player1, player1_health, player1_image);
                            tmr_falldown1.Start();
                        }
                    }
                    break;
                case Team.Player2:
                    if (IsOutOfTable(pnl_player2))
                    {
                        if (tmr_animateImage.Enabled)
                        {
                            tmr_animateImage.Stop();
                        }
                        if (tmr_falldown2.Enabled = false)
                        {
                            player2_health = 0;
                            SetzeLebensAnzeige(pbox_health2, pbox_player2, player2_health, player2_image);
                            tmr_falldown2.Start();
                        }
                    }
                    break;
            }
        }

        private void frm_play_KeyUp(object sender, KeyEventArgs e)
        {
            tmr_animateImage.Stop();
            switch (currentPlayer)
            {
                case Team.Player1:
                    if (player1_health > 0)
                    {
                        switch (player1_image)
                        {
                            case PlayerImage.Potato:
                                pbox_player1.Image = Properties.Resources.p_normal;
                                break;
                            case PlayerImage.Melone:
                                pbox_player1.Image = Properties.Resources.m_normal;
                                break;
                            case PlayerImage.Onion:
                                pbox_player1.Image = Properties.Resources.o_normal;
                                break;
                        }
                    }
                    if (player1_laufeRechts == false)
                    {
                        spiegelPictureBox(pbox_player1);
                    }
                    break;
                case Team.Player2:
                    if (player2_health > 0)
                    {
                        switch (player2_image)
                        {
                            case PlayerImage.Potato:
                                pbox_player2.Image = Properties.Resources.p_normal;
                                break;
                            case PlayerImage.Melone:
                                pbox_player2.Image = Properties.Resources.m_normal;
                                break;
                            case PlayerImage.Onion:
                                pbox_player2.Image = Properties.Resources.o_normal;
                                break;
                        }
                    }
                    if (player1_laufeRechts == false)
                    {
                        spiegelPictureBox(pbox_player1);
                    }
                    break;
            }
        }

        private void UpdatePlayerStatus()
        {
            if (result != "")
            {
                int posX = 0;
                int posY = 0;
                int hp = 0;
                int shx = 0;
                int shy = 0;
                bool shr = true;

                foreach (string par in result.Split('|'))
                {
                    if (par.StartsWith("POSX:"))
                    {
                        posX = (int) par.Split(':').GetValue(1);
                    }
                    else if (par.StartsWith("POSY:"))
                    {
                        posY = (int) par.Split(':').GetValue(1);
                    }
                    else if (par.StartsWith("HP:"))
                    {
                        hp = (int) par.Split(':').GetValue(1);
                    }
                    else if (par.StartsWith("SHX:"))
                    {
                        shx = (int) par.Split(':').GetValue(1);
                    }
                    else if (par.StartsWith("SHY:"))
                    {
                        shy = (int) par.Split(':').GetValue(1);
                    }
                    else if (par.StartsWith("SHR:"))
                    {
                        if (par.Split(':').GetValue(1).Equals("true"))
                        {
                            shr = true;
                        }
                        else
                        {
                            shr = false;
                        }
                    }
                }
                switch (currentPlayer)
                {
                    case Team.Player1:
                        player2_position = new Point(posX, posY);
                        player2_health = hp;
                        pbox_kugel2.Location = new Point(shx, shy);
                        if (shr)
                        {
                            pbox_kugel2.Image = Properties.Resources.bulletrechts;
                        }
                        else
                        {
                            pbox_kugel2.Image = spiegelImage(Properties.Resources.bulletrechts);
                        }
                        break;
                    case Team.Player2:
                        player1_position = new Point(posX, posY);
                        player1_health = hp;
                        pbox_kugel1.Location = new Point(shx, shy);
                        if (shr)
                        {
                            pbox_kugel1.Image = Properties.Resources.bulletrechts;
                        }
                        else
                        {
                            pbox_kugel1.Image = spiegelImage(Properties.Resources.bulletrechts);
                        }
                        break;
                }
                if (player1_health == 0 || player2_health == 0)
                {
                    Thread.Sleep(500);
                    if (player1_health == 0)
                    {
                        MessageBox.Show("Der Server hat verloren!" + "\n" + "Der Client hat gewonnen!");
                    }
                    else
                    {
                        MessageBox.Show("Der Client hat verloren!" + "\n" + "Der Server hat gewonnen!");
                    }
                    this.Hide();
                    frm_start.Show();
                }
            }
            SetPlayerProbs();
        }

        private void SetPlayerProbs()
        {
            switch (currentPlayer)
            {
                case Team.Player1:
                    pnl_player2.Location = player2_position;
                    break;
                case Team.Player2:
                    pnl_player1.Location = player2_position;
                    break;
            }
            SetzeLebensAnzeige(pbox_health1, pbox_player1, player1_health, player1_image);
            SetzeLebensAnzeige(pbox_health2, pbox_player2, player2_health, player2_image);
        }

        private void SetzeLebensAnzeige(PictureBox playerHealthBox, PictureBox playerBox, int value, PlayerImage playerImage)
        {
            if (value == 0)
            {
                playerHealthBox.Image = Properties.Resources.hpbartot1;
                switch (playerImage)
                {
                    case PlayerImage.Potato:
                        playerBox.Image = Properties.Resources.p_die;
                        break;
                    case PlayerImage.Melone:
                        playerBox.Image = Properties.Resources.m_die;
                        break;
                    case PlayerImage.Onion:
                        playerBox.Image = Properties.Resources.m_die;
                        break;
                }
            }
            else if (value >= 1 && value <= 10)
            {
                playerHealthBox.Image = Properties.Resources.hpbar10;
            }
            else if (value >= 11 && value <= 20)
            {
                playerHealthBox.Image = Properties.Resources.hpbar20;
            }
            else if (value >= 21 && value <= 30)
            {
                playerHealthBox.Image = Properties.Resources.hpbar30;
            }
            else if (value >= 31 && value <= 40)
            {
                playerHealthBox.Image = Properties.Resources.hpbar40;
            }
            else if (value >= 41 && value <= 50)
            {
                playerHealthBox.Image = Properties.Resources.hpbar50;
            }
            else if (value >= 51 && value <= 60)
            {
                playerHealthBox.Image = Properties.Resources.hpbar60;
            }
            else if (value >= 61 && value <= 70)
            {
                playerHealthBox.Image = Properties.Resources.hpbar70;
            }
            else if (value >= 71 && value <= 80)
            {
                playerHealthBox.Image = Properties.Resources.hpbar80;
            }
            else if (value >= 81 && value <= 90)
            {
                playerHealthBox.Image = Properties.Resources.hpbar90;
            }
            else if (value >= 91 && value <= 100)
            {
                playerHealthBox.Image = Properties.Resources.hpbar100;
            }
        }

        private void ToggleSpielerPosition()
        {
            switch (currentPlayer)
            {
                case Team.Player1:
                    currentPlayer = Team.Player2;
                    pnl_player2.BringToFront();
                    break;
                case Team.Player2:
                    currentPlayer = Team.Player1;
                    pnl_player1.BringToFront();
                    break;
            }
        }

        private bool IsOutOfTable(Panel pbox)
        {
            return (pbox.Location.X < -(pbox.Width / 2) + 110) || (pbox.Location.X > ClientSize.Width - (pbox.Width / 2) - 90);
        }

        private void tmr_animateImage_Tick(object sender, EventArgs e)
        {

        }

        private void tmr_schiessen1_Tick(object sender, EventArgs e)
        {

        }

        private void tmr_schiessen2_Tick(object sender, EventArgs e)
        {

        }

        private void tmr_jump_Tick(object sender, EventArgs e)
        {

        }

        private void tmr_falldown1_Tick(object sender, EventArgs e)
        {

        }

        private void tmr_falldown2_Tick(object sender, EventArgs e)
        {

        }



    }
}
