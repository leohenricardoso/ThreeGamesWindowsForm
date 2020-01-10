using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class frmNicknamePong : Form
    {
        public static string player1;
        public static string player2;
        public frmNicknamePong()
        {
            InitializeComponent();
        }

        public string recuperaNick1()
        {
            return player1;
        }
        public string recuperaNick2()
        {
            return player2;
        }

        private void BtnComecarPong_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();

            player1 = txtPlayer1.Text;
            player2 = txtPlayer2.Text;

            if (menu.recuperaGame() == 2)
            {
                frmPong pong = new frmPong();
                pong.ShowDialog();
            }

            this.Close();
        }
    }
}
