using MySql.Data.MySqlClient;
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
    public partial class frmCarRacing : Form
    {
        static int vel = 5;
        int gamespeed = vel;
        int scoreCollected = 0;        
        bool pause = true;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer gameOverMusic = new System.Media.SoundPlayer();


        public frmCarRacing()
        {
            InitializeComponent();
            gameOver.Visible = false;
            lblPause.Visible = true;
            btnReiniciar.Visible = false;

            player.SoundLocation = "musicaCar.wav";

            player.Play();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gamespeed);
            score(gamespeed);
            enemy(2);
            fimJogo();
            pausar(pause);
            nick();
        }

        void bancoDados() {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            frmNickname nick = new frmNickname();

            Conexao c = new Conexao();

            int jogo = menu.recuperaGame();
            string nomeJogador = nick.recuperaNick();

            MySqlCommand cmd = new MySqlCommand("select * from jogador_car where nome_jogador = @nomeJogador");
            cmd.Parameters.Add(new MySqlParameter("@nomeJogador", nomeJogador));

            c.Abrir();
            MySqlDataReader reader = c.Pesquisar(cmd);
            

            if (reader.HasRows)
            {
                c.Fechar();

                MySqlCommand cmd4 = new MySqlCommand("select * from jogador_car where nome_jogador = @nomeJogador");
                cmd4.Parameters.Add(new MySqlParameter("@nomeJogador", nomeJogador));
                c.Abrir();
                MySqlDataReader r = c.Pesquisar(cmd4);

                r.Read();
                int scoreSalvo = r.GetInt32(2);

                if(scoreSalvo < scoreCollected)
                {
                    c.Fechar();
                    MySqlCommand cmd2 = new MySqlCommand("update jogador_car set score_jogador = @score where nome_jogador = @nomeJogador");
                    cmd2.Parameters.Add(new MySqlParameter("@score", scoreCollected));
                    cmd2.Parameters.Add(new MySqlParameter("@nomeJogador", nomeJogador));

                    c.Abrir();
                    c.Executar(cmd2);
                    c.Fechar();
                }

                c.Fechar();
            }
            else
            {
                c.Fechar();
                MySqlCommand cmd3 = new MySqlCommand("insert into jogador_car (nome_jogador, score_jogador) values (@nomeJogador, @score)");
                cmd3.Parameters.Add(new MySqlParameter("@nomeJogador", nomeJogador));
                cmd3.Parameters.Add(new MySqlParameter("@score", scoreCollected));

                c.Abrir();
                c.Executar(cmd3);
                c.Fechar();
            }

        }

        void pausar(bool pause)
        {
            this.pause = pause;

            if (pause == true)
            {
                gamespeed = 0;
                lblPause.Visible = true;
            }
            else
            {
                gamespeed = vel;
                lblPause.Visible = false;
            }
        }
        void enemy(int speed)
        {
            Random rnd = new Random();
            int rand = rnd.Next(3, 7);
            int rand2 = rnd.Next(25, 350);

            if (gamespeed != 0)
            {
                if (enemy1.Top >= 500)
                {
                    enemy1.Top = 0;
                    enemy1.Left = rand2;
                }
                else
                {
                    enemy1.Top += rand + 2;
                }

                if (enemy2.Top >= 500)
                {
                    enemy2.Top = 0;
                    enemy2.Left = rand2;
                }
                else
                {
                    enemy2.Top += rand;
                }

                if (enemy3.Top >= 500)
                {
                    enemy3.Top = 0;
                    enemy3.Left = rand2;
                }
                else
                {
                    enemy3.Top += rand + 1;
                }
            }
        }

        void nick() {
            frmNickname nick = new frmNickname();
            lblNick.Text = "Nick: " + nick.recuperaNick().ToString();
        }

        void score(int speed)
        {
            if (point1.Top >= 500)
            {
                point1.Top = 0;

                scoreCollected++;
                lblScore.Text = "Score: " + scoreCollected.ToString();
            }
            else
            {
                point1.Top += speed;
            }

            if (point2.Top >= 500)
            {
                point2.Top = 0;

                scoreCollected++;
                lblScore.Text = "Score: " + scoreCollected.ToString();
            }
            else
            {
                point2.Top += speed;
            }
        }

        bool fimJogo()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds) || car.Bounds.IntersectsWith(enemy2.Bounds) || car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                player.Stop();
                gameOverMusic.SoundLocation = "gameOver.wav";
                gameOverMusic.Play();
                timer1.Enabled = false;
                gameOver.Visible = true;
                btnReiniciar.Visible = true;
                bancoDados();

                

                return true;
            }        
            return false;
        }
        void moveLine(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }

        private void FrmCarRacing_KeyDown(object sender, KeyEventArgs e)
        {
            if (fimJogo())
            {
                gamespeed = 0;
            }

            if (e.KeyCode == Keys.A && gamespeed != 0)
            {

                if (car.Left > 20)
                {
                    car.Left += -10;
                }
            }
            
            if (e.KeyCode == Keys.D && gamespeed != 0)
            {
                if (car.Right < 370)
                {
                    car.Left += 10;
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if(pause == true)
                {

                   // player.Play();
                    pause = false;
                }
                else
                {
                  //  player.Stop();
                    pause = true;
                }
            }
        }

       

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
