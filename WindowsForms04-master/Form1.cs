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

namespace WindowsForms04
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=BUE205D19;Initial Catalog=tempdb;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        SqlCommand cmd = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string insert = $"INSERT into dbo.Funcionario (Nome,Cargo,Salario) values ('{txtNome.Text}','{txtCpf.Text}','{txtSalario.Text}')";
            cmd = new SqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Adicionado Com sucesso");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar mostra = new Mostrar();
            mostra.Show();
        }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            Almento almen = new Almento();
            this.FindForm().Hide();
            almen.Show();
            Mostrar mostra = new Mostrar();
            mostra.Show();
        }
    }
}
