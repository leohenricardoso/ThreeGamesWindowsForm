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
    public partial class frmScore : Form
    {
        public frmScore()
        {
            InitializeComponent();
            CarregarListaCar();
            CarregarListaPong();
            CarregarListaFireBoll();
        }

        public void CarregarListaCar()
        {

            Conexao c = new Conexao();
            c.Abrir();
            MySqlCommand cmd =  new MySqlCommand("select * from jogador_car order by score_jogador desc");


            MySqlDataReader reader = c.Pesquisar(cmd);

            dgvCar.Rows.Clear();           
            while (reader.Read())
            {
                dgvCar.Rows.Add(                   
                    reader.GetString(1),
                    reader.GetInt32(2)
                    );
            }
            c.Fechar();

        }

        public void CarregarListaPong()
        {

            Conexao c = new Conexao();
            c.Abrir();
            MySqlCommand cmd = new MySqlCommand("select * from jogador_pingpong order by id_jogo desc");


            MySqlDataReader reader = c.Pesquisar(cmd);

            dgvPong.Rows.Clear();
            while (reader.Read())
            {
                dgvPong.Rows.Add(
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetInt32(4),
                    reader.GetString(3)                   
                    );
            }
            c.Fechar();

        }

        public void CarregarListaFireBoll()
        {

            Conexao c = new Conexao();
            c.Abrir();
            MySqlCommand cmd = new MySqlCommand("select * from jogador_bolinha order by score_jogador desc");


            MySqlDataReader reader = c.Pesquisar(cmd);

            dgvFireBoll.Rows.Clear();
            while (reader.Read())
            {
                dgvFireBoll.Rows.Add(
                    reader.GetString(1),
                    reader.GetInt32(2)
                    );
            }
            c.Fechar();

        }

    }
}
