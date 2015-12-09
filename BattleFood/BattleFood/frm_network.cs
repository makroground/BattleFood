using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleFood
{
    public partial class frm_network : Form
    {
        string ip;
        public frm_network()
        {
            InitializeComponent();
        }
        //Baut eine Verbindung auf - sendet eigene IP mit, für Rückverbindung
        private void btn_connect_Click(object sender, EventArgs e)
        {
            frm_play f = new frm_play();
            ip = txt_sendip.Text;
            f.networkConnection.Start();
            f.networkConnection.ConnectToIP(ip);
            f.networkConnection.SendString("IP:" + f.networkConnection.getOwnIP);

            this.Hide();
            
            f.Show();
            

        }
        //Erstellt einen Host und baut eine Rückverbindung auf
        private void btn_host_Click(object sender, EventArgs e)
        {
            frm_play f = new frm_play();
            f.networkConnection.Start();
            f.isServer = true;
            this.Hide();
            f.Show();
        }
    }
}
