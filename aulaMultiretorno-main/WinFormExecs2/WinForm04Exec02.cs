using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExecs2
{
    public partial class WinForm04Exec02 : Form
    {
        public WinForm04Exec02()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void WinForm04Exec02_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void WinForm04Exec02_Load(object sender, EventArgs e)
        {
            rbEntrar.Checked = true;
            AtualizaCB();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (rbEntrar.Checked == true)
            {
                string update = $"UPDATE dbo.Vagas SET CarroPlaca = '{txtPlaca.Text}',ConfereVaga = 1 WHERE NomeVaga = '{cbVagasLivres.Text}'";
                DBFunction.Executa(update);
                MessageBox.Show("Adicionado");
                txtPlaca.Clear();
                AtualizaCB();
            }
            else if (rbSair.Checked == true)
            {
                string update = $"UPDATE dbo.Vagas SET CarroPlaca = ' ',ConfereVaga = 0 WHERE CarroPlaca = '{cbPlacas.Text}'";
                DBFunction.Executa(update);
                MessageBox.Show("Retirado");
                txtPlaca.Clear();
                AtualizaCB();
            }
        }
        private void AtualizaCB()
        {
            cbVagasLivres.Items.Clear();
            cbPlacas.Items.Clear();
            string select = $"SELECT * from dbo.Vagas";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr[3]) == 0)
                {
                    cbVagasLivres.Items.Add(dr[1]);
                }
                else
                {
                    if (dr[2].ToString() == " ")
                    {

                    }
                    else
                    {
                        cbPlacas.Items.Add(dr[2]);
                    }
                }
            }
            dr.Close();
            DBFunction.Connection.Close();
        }

        private void rbEntrar_CheckedChanged(object sender, EventArgs e)
        {
            cbPlacas.Visible = false;
            cbVagasLivres.Visible = true;
            txtPlaca.Visible = true;
            lblPlaca.Visible = true;
        }

        private void rbSair_CheckedChanged(object sender, EventArgs e)
        {
            cbPlacas.Visible = true;
            cbVagasLivres.Visible = false;
            txtPlaca.Visible = false;
            lblPlaca.Visible = false;
        }
    }
}
