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
    public partial class Exec03 : Form
    {
        public Exec03()
        {
            InitializeComponent();
        }

        private void Exec03_Load(object sender, EventArgs e)
        {
            AtualizaDG();
        }
        private void AtualizaDG()
        {
            dgMercado.Rows.Clear();
            string select = "SELECT * from dbo.Produto";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                dgMercado.Rows.Add(vetor);
            }
            dr.Close();
            DBFunction.Connection.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string select = $"SELECT * from dbo.Produto WHERE idProduto = '{txtID.Text}'";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString()};
                dgCarrinho.Rows.Add(vetor);
            }
            dr.Close();
            DBFunction.Connection.Close();
            txtID.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double precototal = 0;
            for (int i = 0; i < dgCarrinho.Rows.Count; i++)
            {
                precototal += Convert.ToDouble(dgCarrinho.Rows[i].Cells[2].Value.ToString());
            }
            MessageBox.Show(precototal.ToString());
        }
    }
}
