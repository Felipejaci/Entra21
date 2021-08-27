using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExecs2
{
    public partial class Exec03WinForm05 : Form
    {
        public Exec03WinForm05()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Exec03WinForm05_Load(object sender, EventArgs e)
        {
            AtualizeDG();
        }

        private void AtualizeDG()
        {
            List<string[]> lista = DBFunction.GenericSelectAll("Historico");
            DGHistorico.Rows.Clear();
            foreach (var item in lista)
            {
                DGHistorico.Rows.Add(item);
            }
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double valorLiquido = 0, novoSaldo = 0,despesas = 0, ganhos = 0;
            bool lucrou = true;

            double valor = Convert.ToDouble(DGHistorico.Rows[DGHistorico.Rows.Count - 1].Cells[1].Value.ToString());

            despesas = Convert.ToDouble(txtDespesas.Text);
            ganhos = Convert.ToDouble(txtGanhos.Text);

            //CalculaMes(valor, despesas, ganhos, valorLiquido, out novoSaldo, out lucrou);

            string insert = $"INSERT into dbo.Historico (ValorEmCaixa, DespesasMes, GanhosMes, ValorLiquido, SeLucrou) values ({novoSaldo},{despesas},{ganhos},{valorLiquido},{lucrou})";
        }

        //private void CalculaMes(double saldoAtual, double despesas,double ganho, double valorLiquido,out double novoSaldo,out bool deuLucro)
        //{
        //    valorLiquido = ganho - despesas;
        //    novoSaldo = saldoAtual - valorLiquido;
        //    if (valorLiquido > 0)
        //    {
        //    }
        //    else
        //    {
                    
        //    }
        //}
    }
}
