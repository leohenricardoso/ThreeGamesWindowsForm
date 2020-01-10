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
    public partial class frmPong : Form
    {

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer gameOverMusic = new System.Media.SoundPlayer();
        private System.Timers.Timer aTimer;
        PongGame g;

        public frmPong()
        {
            InitializeComponent();
            player.SoundLocation = "pingPong.wav";
            player.Play();
            btnVoltarMenu.Visible = false;
            lblGameOver.Visible = false;
            g = new PongGame((Size)this.ClientSize);

            // Criando timer com intervalo de 2 seg.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 10;
            lblPress.Visible = true;
            lblPause.Visible = false;

            aTimer.Elapsed += EventoBola; // Adiciona event handler
            //aTimer.Enabled = true; // starta o timer
            fimJogo(); // Esse método precisa rodar no timer -Leo
        }

        private void EventoBola(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (g.stopGame > 0)
            {
                // comeca o jogo de novo
                g.stopGame = 0;
                aTimer.Interval = 10;
                g.resetBall();
            }

            g.update_pos(); // atualiza a posicao da bola e da raquete

            if (g.stopGame > 0)
            {
                // para o jogo e comeca de novo
                aTimer.Enabled = false;
                /*aTimer.Interval = 2000;
                aTimer.Enabled = true;*/
            }

            this.Invalidate();
        }

        void bancoDados() // Metodo do banco de dados -Leo
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            frmNicknamePong nick = new frmNicknamePong();

            Conexao c = new Conexao();

            int jogo = menu.recuperaGame();
            string nomeJogador1 = nick.recuperaNick1();
            string nomeJogador2 = nick.recuperaNick2();


            MySqlCommand cmd3 = new MySqlCommand("insert into jogador_pingpong (nome_jogador1, score_jogador1, nome_jogador2, score_jogador2) values (@nomeJogador1, @score1, @nomeJogador2, @score2)");
            cmd3.Parameters.Add(new MySqlParameter("@nomeJogador1", nomeJogador1));
            cmd3.Parameters.Add(new MySqlParameter("@score1", g.pontosP1));
            cmd3.Parameters.Add(new MySqlParameter("@nomeJogador2", nomeJogador2));
            cmd3.Parameters.Add(new MySqlParameter("@score2", g.pontosP2));

            c.Abrir();
            c.Executar(cmd3);
            c.Fechar();
        }

        public void gameOver()
        {
            if (fimJogo())
            {
                player.Stop();
                gameOverMusic.SoundLocation = "gameOver.wav";
                gameOverMusic.Play();
                btnVoltarMenu.Visible = true;
                lblGameOver.Visible = true;
                lblPause.Visible = false;
                lblPress.Visible = false;
                aTimer.Enabled = false;
                timer1.Enabled = false;
                bancoDados();
            }
        }

        private void pongForm_sobeBola(object sender, KeyEventArgs e)
        {
            g.update_key(e, true);
        }

        private void pongForm_desceBola(object sender, KeyEventArgs e)
        {
            g.update_key(e, false);
        }

        public bool fimJogo() // Criei esse metodo bool para podermos parar o jogo quando alguem faze
        {
            if (g.pontosP1 == 5)
            {
                return true;
            }
            else if (g.pontosP2 == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PongForm_Paint(object sender, PaintEventArgs e)//nomes e placar
        {
            frmNicknamePong nick = new frmNicknamePong();
            g.paint(e);
            scoreLabel.Text = nick.recuperaNick1().ToString() + " [" + g.pontosP1 + "]   vs   [" + g.pontosP2 + "] " + nick.recuperaNick2().ToString();
            scoreLabel.Visible = (g.stopGame > 0);
        }

        private void JogoPong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!fimJogo())
            {
                if (e.KeyChar == ' ')
                {
                    if (aTimer.Enabled == false)
                    {
                        aTimer.Enabled = true;
                        lblPress.Visible = false;
                        lblPause.Visible = false;
                    }
                    else
                    {
                        aTimer.Enabled = false;
                        lblPause.Visible = true;
                    }

                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            fimJogo();
            gameOver();
        }

        private void BtnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class PongGame
    {
        private Player p1;
        private Player p2;
        private Ball b;
        public int pontosP1 = 0;
        public int pontosP2 = 0;
        public int stopGame = 0;

        public PongGame(Size clientSize)
        {
            int wall_offset = 100;
            Size tamanhoPlayer = new Size(20, 100);
            Size tamanhoBola = new Size(20, 20);

            p1 = new Player(
                new Rectangle(wall_offset, clientSize.Height / 2 - tamanhoPlayer.Height / 2, tamanhoPlayer.Width, tamanhoPlayer.Height),
                clientSize,
                Keys.W,
                Keys.S);
            p2 = new Player(
                new Rectangle(clientSize.Width - wall_offset - tamanhoPlayer.Width,
                clientSize.Height / 2 - tamanhoPlayer.Height / 2, tamanhoPlayer.Width, tamanhoPlayer.Height),
                clientSize,
                Keys.Up,
                Keys.Down);
            b = new Ball(
                new Rectangle(wall_offset, clientSize.Height - wall_offset, tamanhoBola.Width, tamanhoBola.Height),
                clientSize);
        }



        public void update_pos()
        {
            stopGame = b.update_pos(p1, p2);
            if (stopGame > 0)
            {
                if (stopGame == 1)
                {
                    pontosP1++;
                }
                else if (stopGame == 2)
                {
                    pontosP2++;
                }
                return;
            }
            p1.update_pos(b);
            p2.update_pos(b);
        }

        public void resetBall()
        {
            b.reset(); // coloca a bola no centro com velocidade aleatoria
        }

        public void update_key(KeyEventArgs e, bool down)
        {
            // atualizando o movimento das raquetes
            p1.update_key(e.KeyCode, down);
            p2.update_key(e.KeyCode, down);
        }

        public void paint(PaintEventArgs e)
        {
            // bruxa os jogadores e a bola
            e.Graphics.FillRectangle(Brushes.MidnightBlue, p2.r);
            e.Graphics.FillRectangle(Brushes.BlueViolet, p1.r);
            e.Graphics.FillRectangle(Brushes.DarkRed, b.r);
        }
    }

    class Player
    {
        public Rectangle r;
        public bool mov_up = false;
        public bool mov_down = false;
        Keys upKey;
        Keys downKey;
        Size enclosing;
        int speed = 7;

        public Player(Rectangle r, Size enclosing, Keys upKey, Keys downKey)
        {
            this.r = r;
            this.enclosing = enclosing;
            this.upKey = upKey;
            this.downKey = downKey;
        }

        public void update_pos(Ball b)
        {
            if (mov_up && mov_down)
            {
                return;
            }
            else if (mov_up)
            {
                if (r.Top - speed >= 0)
                {
                    r.Y -= speed;
                    if (this.r.IntersectsWith(b.r))
                    {
                        r.Y += speed; // volta
                    }
                }
                else
                {
                    r.Y = 0;
                }
            }
            else if (mov_down)
            {
                if (r.Bottom + speed <= enclosing.Height)
                {
                    r.Y += speed;
                    if (this.r.IntersectsWith(b.r))
                    {
                        r.Y -= speed;
                    }
                }
                else
                {
                    r.Y = enclosing.Height - r.Height;
                }
            }
        }

        public void update_key(Keys key, bool down)
        {
            if (key == upKey)
            {
                mov_up = down;
            }
            else if (key == downKey)
            {
                mov_down = down;
            }
        }
    }

    class Ball
    {
        public Rectangle r;
        int dx;
        int dy;
        Size enclosing;
        Rectangle top_wall;
        Rectangle bot_wall;
        int speed = 10;

        public Ball(Rectangle r, Size enclosing)//copiado
        {
            this.r = r;
            this.enclosing = enclosing;
            int wall_thickness = 100;
            top_wall = new Rectangle(0, -wall_thickness, enclosing.Width, wall_thickness);//copiado
            bot_wall = new Rectangle(0, enclosing.Height, enclosing.Width, wall_thickness);
            reset();
        }

        public void reset()
        {
            /* coloca a bola no meio com velocidade aleatoria */
            Random rnd = new Random();
            r.X = enclosing.Width / 2;//posicao da bola na metade do enclosing
            r.Y = enclosing.Height / 2;
            int umOuOutro = rnd.Next(-7, 7);
            if (umOuOutro > 0)
            {
                umOuOutro = speed;
            }
            else
            {
                umOuOutro = -speed;
            }
            dx = umOuOutro;
            dy = rnd.Next(-3, 3 - 0);
        }

        public int update_pos(Player p1, Player p2)
        {
            /* atualiza posicao da bola */
            r.X += dx;
            r.Y += dy;

            /* determina se a bola passou */
            if (r.Left < 0)
            {
                return 2;
            }
            else if (r.Right > enclosing.Width)
            {
                return 1;
            }

            /* quando a bola toca no topo ou no chao */
            if (r.IntersectsWith(top_wall) || r.IntersectsWith(bot_wall))
            {
                dy = -dy;
            }

            if (r.IntersectsWith(p1.r)) // balanca com player 1
            {
                bounceWith(p1);
            }
            else if (r.IntersectsWith(p2.r)) // balanca com player 2
            {
                bounceWith(p2);
            }
            return 0;

        }

        private void bounceWith(Player p)
        {
            dx = -dx;

            if (dx > 0 && r.Left + dx < p.r.Right)
            {
                // se bater no topo ou na bunda do player 1
                dx = -Math.Abs(dx);
                dy = -dy;
            }
            else if (dx < 0 && r.Right + dx > p.r.Left)
            {
                // se bater no topo ou na bunda do player 2
                dx = Math.Abs(dx);
                dy = -dy;
            }
            else
            {
                // pinga no canto superior do player
                //pingar com movimento vertical do jogador
                if (p.mov_down && !p.mov_up)
                {
                    if (dy > 0)
                    {
                        // Player down bola down
                        dy += 1;
                    }
                    else
                    {
                        // playerdown bolaups
                        dy += 1;
                        if (dy == 0)
                        {
                            dy = -1;
                        }
                        else
                        {
                            dx = Math.Sign(dx) * (Math.Abs(dx) + 1);
                        }
                    }
                }
                else if (p.mov_up && !p.mov_down)
                {
                    if (dy > 0)
                    {
                        // playercima bolacima
                        dy += -1;
                        if (dy == 0)
                        {
                            dy = 1;
                        }
                        else
                        {
                            dx = Math.Sign(dx) * (Math.Abs(dx) + 1);
                        }
                    }
                    else
                    {
                        // Player cimabola cima
                        dy += -1;
                    }
                }
            }
        }


    }
}
