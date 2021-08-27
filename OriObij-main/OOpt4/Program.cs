using System;
using System.Collections.Generic;

namespace OOpt4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa pes = new Pessoa();
            //Console.WriteLine("por favor insira uma pessoa");
            //pes.Nome = CR();
            //pes.Cpf = CR();
            //pes.Idade = Convert.ToInt32(CR());
            //pes.Rua = CR();
            //pes.Numero = CR();
            //pes.Cidade = CR();
            //pes.Estado = CR();

            //Console.WriteLine("========================================");

            //Console.WriteLine("{0} | {1} | {2}", pes.Nome, pes.Idade, pes.Cpf);
            //Console.WriteLine("{0} | {1} | {2} | {3}", pes.Rua,pes.Numero,pes.Cidade,pes.Estado);


            ////exec01 B) -----------------------------------------------------------------------------------

            //Empresa emp = new Empresa();
            //Console.WriteLine("insira os dados da empresa");
            //emp.Nome = CR();
            //emp.QuantFunc = Convert.ToInt32(CR());
            //emp.Rua = CR();
            //emp.Numero = CR();
            //emp.Cidade = CR();
            //emp.Estado = CR();

            //Console.WriteLine("====================");

            //Console.WriteLine("esta é a empresa:");
            //Console.WriteLine("{0} \nquantidade de funcionarios: {1}",emp.Nome,emp.QuantFunc);
            //Console.WriteLine();
            //Console.WriteLine("este é o endereco da mesma:");
            //Console.WriteLine("{0} | {1} | {2} | {3}",emp.Rua,emp.Numero,emp.Cidade,emp.Estado);

            ////exec01 C) ----------------------------------------------------------------------------------

            //List<Habitacao> hab = new List<Habitacao>();
            //int i = 0;
            //while (true)
            //{
            //    i++;
            //    Console.WriteLine("insira o tipo de habitação e o dono");
            //    Habitacao habi = new Habitacao();
            //    habi.TipeHabi = CR();
            //    habi.NomeDono = CR();
            //    Console.WriteLine("insira o endereco");
            //    habi.Rua = CR();
            //    habi.Numero = CR();
            //    habi.Cidade = CR();
            //    habi.Estado = CR();
            //    hab.Add(habi);
            //    if (i == 2)
            //    {
            //        Console.WriteLine("encheu os eapaços");
            //        break;
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("+++++++++++++++++++++++++");
            //Console.WriteLine();

            //foreach (var item in hab)
            //{
            //    Console.WriteLine(item.TipeHabi);
            //    Console.WriteLine(item.NomeDono);
            //    Console.WriteLine();
            //    Console.WriteLine("este é o endereco:");
            //    Console.WriteLine("{0} | {1} | {2} | {3}",item.Rua,item.Numero,item.Cidade,item.Estado);
            //    Console.WriteLine();
            //}

            ////exec02 ---------------------------------------------------------------------------------------







        }
        public static string CR()
        {
            return Console.ReadLine();
        }
    }
}
