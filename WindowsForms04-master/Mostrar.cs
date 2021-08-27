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
    public partial class Mostrar : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=BUE205D19;Initial Catalog=tempdb;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        SqlCommand cmd = new SqlCommand();
        public Mostrar()
        {
            InitializeComponent();
        }

        private void lstMostra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            List<Func> funcionario = new List<Func>();
            string select = $"SELECT Nome,Cargo,Salario from dbo.Funcionario";
            cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Func fun = new Func(Convert.ToString(dr["Nome"]), Convert.ToString(dr["Cargo"]), Convert.ToInt32(dr["Salario"]));
                funcionario.Add(fun);
            }
            foreach (var item in funcionario)
            {
                lstMostra.Items.Add("#================)");
                lstMostra.Items.Add("| "+item.Nome);
                lstMostra.Items.Add("| "+item.Cpf);
                lstMostra.Items.Add("| "+item.Salario);
                lstMostra.Items.Add("#================)");
                lstMostra.Items.Add("");
            }
        }
    }
}
