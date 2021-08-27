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
    public partial class Almento : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=BUE205D19;Initial Catalog=tempdb;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        SqlCommand cmd = new SqlCommand();
        public Almento()
        {
            InitializeComponent();
        }

        private void btnAtualizarSalario_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE dbo.Funcionario Set Salario = '{txtNewSalario.Text}' WHERE Nome = '{txtFuncioProcu.Text}'";
            cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("atualizado");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Mostrar mostra = new Mostrar();
            mostra.FindForm().Hide();
            this.FindForm().Hide();
            form.Show();
        }
    }
}
