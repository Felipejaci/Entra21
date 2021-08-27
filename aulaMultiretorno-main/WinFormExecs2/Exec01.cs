﻿using System;
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
    public partial class Exec01 : Form
    {
        public Exec01()
        {
            InitializeComponent();
        }

        private void Exec01_Load(object sender, EventArgs e)
        {
            cbNomes.Items.Clear();
            List<string> elements = DBFunction.GenericUnitSelect("Nome","pessoa");


            foreach (var item in elements)
            {
                cbNomes.Items.Add(item);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            dgPessoa.Rows.Clear();
            string select = $"SELECT * from dbo.pessoa WHERE Nome = '{cbNomes.Text}'";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                dgPessoa.Rows.Add(vetor);
            }
            dr.Close();
            DBFunction.Connection.Close();
        }

        private void Exec01_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
