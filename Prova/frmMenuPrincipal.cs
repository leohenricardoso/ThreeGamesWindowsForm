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
    public partial class frmMenuPrincipal : Form
    {

        System.Media.SoundPlayer MusicMenu = new System.Media.SoundPlayer();

        public static int game = 0;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        public int recuperaGame()
        {
            return game;
        }

        private void BtnCarRacing_Click(object sender, EventArgs e)
        {
            game = 3;
            MusicMenu.SoundLocation = "musicaMenu.wav";
            MusicMenu.Play();
            frmNickname nick = new frmNickname();
            nick.ShowDialog();
                      
        }

        private void BtnPingPong_Click(object sender, EventArgs e)
        {
            game = 2;
            MusicMenu.SoundLocation = "musicaMenu.wav";
            MusicMenu.Play();
            frmNicknamePong nick = new frmNicknamePong();
            nick.ShowDialog();
        }

        private void BtnFuga_Click(object sender, EventArgs e)
        {
            game = 1;
            MusicMenu.SoundLocation = "musicaMenu.wav";
            MusicMenu.Play();
            frmNickname nick = new frmNickname();
            nick.ShowDialog();
        }

        private void BtnPlacar_Click(object sender, EventArgs e)
        {
            MusicMenu.SoundLocation = "musicaMenu.wav";
            MusicMenu.Play();
            frmScore fScore = new frmScore();
            fScore.ShowDialog();
        }
    }
}
