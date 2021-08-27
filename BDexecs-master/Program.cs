using System;
using System.Data.SqlClient;

namespace BDexecs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source = BUE205D19; Initial Catalog = master; User ID = guest01; Password = ***********
            SqlConnection conn = new SqlConnection("Data Source=BUE205D19;Initial Catalog=tempdb;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            SqlCommand cmd;

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Insira o {0}° cliente", i + 1);
            //    string nome = Console.ReadLine();
            //    string cpf = Console.ReadLine();
            //    int idade = int.Parse(Console.ReadLine());
            //    string insert = $"INSERT into dbo.Pessoa (Nome,CPF,Idade) values ('{nome}','{cpf}',{idade})";
            //    cmd = new SqlCommand(insert, conn);// preparação do insert
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}
            //// update
            //string update = "UPDATE dbo.Pessoa Set Nome = 'Joao' , Idade = 25 WHERE idPessoa = 1";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //// delete
            //string delete = "DELETE from dbo.Pessoa WHERE Nome = 'Carlos'";
            //cmd = new SqlCommand(delete, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //// Select
            //string select = "SELECT * FROM dbo.Pessoa";
            //cmd = new SqlCommand(select, conn);

            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["idPessoa"]);
            //    Console.WriteLine(dr[1]);
            //    Console.WriteLine(dr[2]);
            //    Console.WriteLine(dr["Idade"]);
            //    Console.WriteLine("-------------//---------------®");
            //}
            //dr.Close();
            //conn.Close();

            //exec03/exec05-----------------------------------------------------------------------------------------------

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("insira o " + (i + 1) + "° Funcionario");
            //    string nome = Console.ReadLine();
            //    string cargo = Console.ReadLine();
            //    int salario = int.Parse(Console.ReadLine());
            //    string insert = $"INSERT into dbo.Funcionario (Nome,Cargo,Salario) values ('{nome}','{cargo}',{salario})";
            //    cmd = new SqlCommand(insert, conn);// preparação do insert
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}

            //string select = "SELECT * FROM dbo.Funcionario WHERE Salario > 3000";
            //cmd = new SqlCommand(select, conn);
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["idFuncionario"]);
            //    Console.WriteLine(dr[1]);
            //    Console.WriteLine(dr[2]);
            //    Console.WriteLine(dr["Salario"]);
            //    Console.WriteLine("-------------//---------------®");
            //}
            //dr.Close();
            //conn.Close();
            //string update = "UPDATE dbo.Funcionario SET Salario = 3000 WHERE Salario < 3000";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            ////exec04/exec06-------------------------------------------------------------------------------------------

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("insira o " + (i + 1) + "° Email");
            //    string email = Console.ReadLine();
            //    string insert = $"INSERT into dbo.Emails (EnderecoEmail) values ('{email}')";
            //    cmd = new SqlCommand(insert, conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}
            //string select = "SELECT * FROM dbo.Emails WHERE EnderecoEmail LIKE '%autlook%'";
            //cmd = new SqlCommand(select, conn);
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["idFuncionario"]);
            //    Console.WriteLine(dr[1]);
            //    Console.WriteLine("-------------//---------------®");
            //}
            //dr.Close(); 
            //conn.Close();
            //string delete = "DELETE from dbo.Emails WHERE NOT LIKE EnderecoEmail = '%autlook%'";
            //cmd = new SqlCommand(delete, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            ////lista02 /-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-
            ///

            ////exec01

            ////+- incompleto
            //while (true)
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("\t\t        ** MENU **");
            //    Console.WriteLine("\t\t#-------------------------#");
            //    Console.WriteLine("\t\t|    1 - ADICIONAR - 1    |");
            //    Console.WriteLine("\t\t|     2 - REMOVER - 2     |");
            //    Console.WriteLine("\t\t|    3 - ATUALIZAR - 3    |");
            //    Console.WriteLine("\t\t|     4 - MOSTRAR - 4     |");
            //    Console.WriteLine("\t\t|     5 - COMPRA - 5      |");
            //    Console.WriteLine("\t\t|      6 - SAIR - 6       |");
            //    Console.WriteLine("\t\t#-------------------------#");
            //    Console.WriteLine();
            //    int choice = Convert.ToInt32(Console.ReadLine());

            //    if (choice == 1)
            //    {
            //        Console.Clear();

            //        Console.WriteLine("qual o nome");
            //        string name = Console.ReadLine();

            //        Console.WriteLine("qual o preco");
            //        int price = int.Parse(Console.ReadLine());

            //        Console.WriteLine("qual a quantidade em estoque");
            //        int qtdestoque = int.Parse(Console.ReadLine());

            //        string insert = $"INSERT into dbo.Produto (Nome,Preco,QtdEstoque) values ('{name}','{price}','{qtdestoque}')";
            //        cmd = new SqlCommand(insert, conn);
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //        Console.WriteLine("\nprecione enter para continuar");
            //        Console.ReadLine();
            //        Console.Clear();
            //    }
            //    else if (choice == 2)
            //    {
            //        Console.Clear();

            //        string select = "SELECT Nome from dbo.Produto";
            //        cmd = new SqlCommand(select, conn);

            //        conn.Open();
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            Console.WriteLine(dr[0]);
            //        }
            //        dr.Close();
            //        conn.Close();

            //        Console.WriteLine("\nQual produto deseja excluir");
            //        string deleteProd = Console.ReadLine();

            //        string delete = $"DELETE from dbo.Produto WHERE Nome = '{deleteProd}'";
            //        cmd = new SqlCommand(delete, conn);
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //        Console.WriteLine("\nprecione enter para continuar");
            //        Console.ReadLine();
            //        Console.Clear();
            //    }
            //    else if (choice == 3)
            //    {
            //        Console.Clear();

            //        string select = "SELECT * from dbo.Produto";
            //        cmd = new SqlCommand(select, conn);

            //        conn.Open();
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            Console.WriteLine();
            //            Console.WriteLine("#=================)");
            //            Console.WriteLine("|id        : " + dr["idProduto"]);
            //            Console.WriteLine("|nome      : " + dr[1]);
            //            Console.WriteLine("|preco     : " + dr[2]);
            //            Console.WriteLine("|quantidade: " + dr[3]);
            //            Console.WriteLine("#=================)");
            //        }
            //        dr.Close();
            //        conn.Close();
            //        Console.WriteLine();

            //        Console.WriteLine("qual pruduto deseja atualizar?");
            //        string prodUpdate = Console.ReadLine();
            //        Console.WriteLine("insira os novos dados");
            //        Console.WriteLine("nome:");
            //        string name = Console.ReadLine();
            //        Console.WriteLine("preco:");
            //        int price = int.Parse(Console.ReadLine());
            //        Console.WriteLine("quantidade estoque:");
            //        int qtdEsto = int.Parse(Console.ReadLine());

            //        string update = $"UPDATE dbo.Produto set Nome = '{name}', Preco = {price}, QtdEstoque = {qtdEsto} WHERE Nome = '{prodUpdate}'";
            //        cmd = new SqlCommand(update, conn);
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //        Console.WriteLine("\nprecione enter para continuar");
            //        Console.ReadLine();
            //        Console.Clear();
            //    }
            //    else if (choice == 4)
            //    {
            //        Console.Clear();

            //        string select = "SELECT * from dbo.Produto";
            //        cmd = new SqlCommand(select, conn);

            //        conn.Open();
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            Console.WriteLine();
            //            Console.WriteLine("#=================)");
            //            Console.WriteLine("| id        : " + dr["idProduto"]);
            //            Console.WriteLine("| nome      : " + dr[1]);
            //            Console.WriteLine("| preco     : " + dr[2]);
            //            Console.WriteLine("| quantidade: " + dr[3]);
            //            Console.WriteLine("#=================)");
            //        }
            //        dr.Close();
            //        conn.Close();
            //        Console.WriteLine();

            //        Console.WriteLine("\nprecione enter para continuar");
            //        Console.ReadLine();
            //        Console.Clear();
            //    }
            //    else if (choice == 5)
            //    {
            //        Console.Clear();

            //        string select = "SELECT * from dbo.Produto";
            //        cmd = new SqlCommand(select, conn);

            //        conn.Open();
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            Console.WriteLine();
            //            Console.WriteLine("#=================)");
            //            Console.WriteLine("| id        : " + dr["idProduto"]);
            //            Console.WriteLine("| nome      : " + dr[1]);
            //            Console.WriteLine("| preco     : " + dr[2]);
            //            Console.WriteLine("| quantidade: " + dr[3]);
            //            Console.WriteLine("#=================)");
            //        }
            //        dr.Close();
            //        conn.Close();
            //        Console.WriteLine();

            //        Console.WriteLine("qual produto deseja comprar?");
            //        string prodCompra = Console.ReadLine();

            //        string update = $"UPDATE dbo.Produto set QtdEstoque = 1 - QtdEstoque WHERE Nome = '{prodCompra}'";
            //        cmd = new SqlCommand(update, conn);
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        conn.Close();
            //        string select2 = "SELECT Preco from dbo.Produto";
            //        cmd = new SqlCommand(select2, conn);
            //        conn.Open();
            //        SqlDataReader dr2 = cmd.ExecuteReader();
            //        while (dr2.Read())
            //        {
            //            if (dr["Preco"] == 0)
            //            {

            //            }
            //        }
            //        conn.Close();

            //    }
            //    else if (choice == 6)
            //    {
            //        Console.Clear();

            //        Console.WriteLine("           Obrigado por usar o nosso sistema");
            //        Console.WriteLine();
            //        Console.WriteLine("precione enter para sair");
            //        Console.ReadLine();
            //        break;
            //    }
            //}
        }
    }
}
