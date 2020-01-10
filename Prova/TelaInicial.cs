using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prova
{
    public partial class TelaInicial : Form
    {

        #region Atributos

        int aceleracao = 20;

        int limE = 40, limSup = 40;

        int limInf = 0, limD = 0;

        
        int score = 0;

        int L;
        int T;
        System.Media.SoundPlayer FujaMusic = new System.Media.SoundPlayer();
        System.Media.SoundPlayer gameOverMusic = new System.Media.SoundPlayer();

        private List<ImgGame> listaBolas;

        Random rd = new Random();

        #endregion

        #region Eventos

        private void TmpBolaDeFogo_Tick(object sender, EventArgs e)
        {

            foreach (ImgGame b in listaBolas)
                MoverFogo(b);

            GameOver();


        }

        private void TmBonecoAndar_Tick(object sender, EventArgs e)
        {

            if (L > 0) { L--; }
            if (T > 0) { T--; }
            if (L < 0) { L++; }
            if (T < 0) { T++; }

            Boneco.Left += L;
            Boneco.Top += T;

        }

        private void TelaInicial_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 3;
            if (e.KeyCode == Keys.Right) { L += speed; Boneco.Image = Prova.Properties.Resources.char_right_1; }
            if (e.KeyCode == Keys.Left) { L -= speed; Boneco.Image = Prova.Properties.Resources.char_left_1; }
            if (e.KeyCode == Keys.Down) { T += speed; Boneco.Image = Prova.Properties.Resources.char_down_1; }
            if (e.KeyCode == Keys.Up) { T -= speed; Boneco.Image = Prova.Properties.Resources.char_up_1; ; }

        }

        private void TmBordasPersonagem_Tick(object sender, EventArgs e)
        {
            if (Boneco.Location.X >= limD) { L /= -1; Boneco.Left = limD - 10; }
            if (Boneco.Location.X <= limE) { L /= -1; Boneco.Left = limE; }
            if (Boneco.Location.Y >= limInf) { T /= -1; Boneco.Top = limInf - 10; }
            if (Boneco.Location.Y <= limSup) { T /= -1; Boneco.Top = limSup; }
        }

        private void TmAumentaNivel_Tick(object sender, EventArgs e)
        {
            if (listaBolas.Count < 5)
                AdicionarBolas();
            else
                tmAumentaNivel.Stop();
        }

        private void ImgTopo_Paint(object sender, PaintEventArgs e)
        {
            using (TextureBrush brush = new TextureBrush(Properties.Resources.paredeH))
            {
                e.Graphics.FillRectangle(brush, imgTopo.ClientRectangle);
            }
        }

        private void ImgRodape_Paint(object sender, PaintEventArgs e)
        {
            using (TextureBrush brush = new TextureBrush(Properties.Resources.paredeH))
            {
                e.Graphics.FillRectangle(brush, imgRodape.ClientRectangle);
            }
        }

        private void ImgEsq_Paint(object sender, PaintEventArgs e)
        {
            using (TextureBrush brush = new TextureBrush(Properties.Resources.paredeH))
            {
                e.Graphics.FillRectangle(brush, imgEsq.ClientRectangle);
            }
        }

        private void ImgDir_Paint(object sender, PaintEventArgs e)
        {
            using (TextureBrush brush = new TextureBrush(Properties.Resources.paredeH))
            {
                e.Graphics.FillRectangle(brush, imgDir.ClientRectangle);
            }
        }

        private void TelaInicial_Resize(object sender, EventArgs e)
        {
            limInf = this.Height - 140;
            limD = this.Width - 135;
            
        }

        #endregion

        #region Métodos

        public TelaInicial()
        {
            this.listaBolas = new List<ImgGame>();
            InitializeComponent();
            FujaMusic.SoundLocation = "fujaMusic.wav";
            FujaMusic.Play();


            limInf = this.Height - 140;
            limD = this.Width - 135;

            frmNickname nick = new frmNickname();

            string nomeJogador = nick.recuperaNick();

            lbNick.Text = nomeJogador;



            AdicionarBolas();
            AdicionarBolas();
        }

        public void AdicionarBolas()
        {

            totalBolas++;

            ImgGame bola = new ImgGame();

            
            bola.Image = global::Prova.Properties.Resources.fireball;
            bola.Location = NovaPosicao();
            bola.Name = "imgBola" + totalBolas.ToString();
            bola.Size = new System.Drawing.Size(72, 60);
            bola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            bola.BackColor = Color.Transparent;
            bola.TabIndex = 0;
            bola.TabStop = false;
            bola.velocidadeHorizontal = 0;
            bola.velocidadeVertical = 0;
            bola.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            bola.velocidadeHorizontal = aceleracao;
            bola.velocidadeVertical = aceleracao;

            bola.velocidadeHorizontal = aceleracao;
            bola.velocidadeVertical = aceleracao;
       
            ((System.ComponentModel.ISupportInitialize)(bola)).BeginInit();
            this.Controls.Add(bola);
            ((System.ComponentModel.ISupportInitialize)(bola)).EndInit();

            listaBolas.Add(bola);

        }

        public Point NovaPosicao()
        {

            Point p = new Point();

            do
            {

                p = new Point(rd.Next(limE, limD), rd.Next(limSup, limInf));

            } while (Math.Sqrt(Math.Pow((Boneco.Left - p.X), 2) + Math.Pow((Boneco.Top - p.Y), 2)) < 20);

            return p;

        }

        public void GameOver()
        {

            bool fim = false;

            foreach (ImgGame b in listaBolas)
                if (Boneco.Bounds.IntersectsWith(b.Bounds))
                {
                    fim = true;
                    break;
                }

            if (fim)
            {
                FujaMusic.Stop();
                gameOverMusic.SoundLocation = "gameOver.wav";
                gameOverMusic.Play();
                tmpBolaDeFogo.Enabled = false;
                tmBonecoAndar.Enabled = false;
                tmBordasPersonagem.Enabled = false;
                tmAumentaNivel.Enabled = false;
                tmScore.Enabled = false;
                bancoDados();


                //btnVoltaMenu.Visible = true;
                new frmGameOver().ShowDialog();
                this.Close();
            }
            
        }

        private void TmScore_Tick(object sender, EventArgs e)
        {
           
            score++;
            scoreBolinha.Text = score.ToString();
        }

        private void BtnVoltaMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MoverFogo(ImgGame x)
        {

            if (x.Top > limInf)
                x.velocidadeVertical = rd.Next(0, aceleracao) * -1;


            if (x.Top < limSup)
                x.velocidadeVertical = rd.Next(0, aceleracao);

            if (x.Left > limD)
                x.velocidadeHorizontal = rd.Next(0, aceleracao) * -1;


            if (x.Left < limE)
                x.velocidadeHorizontal = rd.Next(0, aceleracao);

            x.Top += x.velocidadeVertical;
            x.Left += x.velocidadeHorizontal;

        }

        void bancoDados()
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            frmNickname nick = new frmNickname();

            Conexao c = new Conexao();

            int jogo = menu.recuperaGame();
            string nomeJogador = nick.recuperaNick();

            

            MySqlCommand cmd = new MySqlCommand("select * from jogador_bolinha where nome_jogador = @nomeJogador");
            cmd.Parameters.Add(new MySqlParameter("@nomeJogador", nomeJogador));

            c.Abrir();
            MySqlDataReader reader = c.Pesquisar(cmd);


            if (reader.HasRows)
            {
                c.Fechar();

                MySqlCommand cmd4 = new MySqlCommand("select * from jogador_bolinha where nome_jogador = @nomeJogador");
                cmd4.Parameters.Add(new MySqlParameter("@nomeJogador", nomeJogador));
                c.Abrir();
                MySqlDataReader r = c.Pesquisar(cmd4);

                r.Read();
                int scoreSalvo = r.GetInt32(2);

                if (scoreSalvo < score)
                {
                    c.Fechar();
                    MySqlCommand cmd2 = new MySqlCommand("update jogador_bolinha set score_jogador = @score where nome_jogador = @nomeJogador");
                    cmd2.Parameters.Add(new MySqlParameter("@score", score));
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
                MySqlCommand cmd3 = new MySqlCommand("insert into jogador_bolinha(nome_jogador, score_jogador) values (@nomeJogador, @score)");
                cmd3.Parameters.Add(new MySqlParameter("@nomeJogador", nomeJogador));
                cmd3.Parameters.Add(new MySqlParameter("@score", score));

                c.Abrir();
                c.Executar(cmd3);
                c.Fechar();
            }

        }

        #endregion

    }
}
