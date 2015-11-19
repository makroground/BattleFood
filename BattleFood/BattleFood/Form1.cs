using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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


        }
    }
}
