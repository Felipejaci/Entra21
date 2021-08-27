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

            //Pessoa02 pes = new Pessoa02();
            //Console.WriteLine("digite a pessoa nome e idade");
            //pes.Nome = CR();
            //while (true)
            //{
            //    try
            //    {
            //        pes.Idade = CRI();
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("apenas numeros!!!");
            //    }
            //}
            //Console.WriteLine("gostaria de trabalhar ou comer?");
            //string resp = CR();
            //while (resp != "comer" || resp != "trabalhar")
            //{
            //    if (resp == "comer")
            //    {
            //        Console.WriteLine("quantos quilos comeu?");
            //        pes.Comer = CRI();
            //        Pessoa02.Gula(pes.Comer);
            //        break;
            //    }
            //    else if (resp == "trabalhar")
            //    {
            //        Console.WriteLine("quantas horas trabalhou?");
            //        pes.Trabalhar = CRI();
            //        Pessoa02.Escravo(pes.Trabalhar);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("apenas trabalhar || comer");

            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("esta é a pessoa:");
            //Console.WriteLine("{0} | {1} \ndopamina: {2} \ndinheiro {3}", pes.Nome, pes.Idade, Pessoa02.Dopamina, Pessoa02.QuantDinhe);
            //Console.WriteLine();


            ////exec02 b) ---------------------------------------------------------------------

            //List<Cachorro> dog = new List<Cachorro>();
            //for (int i = 0; i < 2; i++)
            //{
            //    Cachorro doge = new Cachorro();
            //    Console.WriteLine("digite seus chorros");
            //    doge.Nome = CR();
            //    while (true)
            //    {
            //        Console.WriteLine("o que o cachorro fara?\ncomer == c || descasar == d");
            //        char resp = CRC();
            //        if (resp == 'd')
            //        {
            //            Console.WriteLine("quanto tempo seu cachorro descasou?");
            //            doge.Descansar = Cachorro.Conf(doge.Descansar = CRD());
            //            break;
            //        }
            //        else if (resp == 'c')
            //        {
            //            Console.WriteLine("quantos quilos seu cachorro comeu?");
            //            doge.Comer = Cachorro.Gula(doge.Comer = CRD());
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("apenas c || d");
            //        }
            //    }
            //    dog.Add(doge);
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("=============================");
            //foreach (var item in dog)
            //{
            //    Console.WriteLine(item.Nome);
            //    Console.WriteLine(item.Descansar);
            //    Console.WriteLine(item.Comer);
            //    Console.WriteLine();
            //}

            ////exec02 c) ---------------------------------------------------------------

            //Funcionario func = new Funcionario();
            //Console.WriteLine("digite o nome do funcionario");
            //func.Nome = CR();
            //Console.WriteLine("quanto dinheiro o funcionario");
            //Funcionario.DinheBolso = CRD();
            //if (Funcionario.DinheBolso < 1520)
            //{
            //    Funcionario.Escravo(Funcionario.DinheBolso);
            //}

            //Console.WriteLine();
            //Console.WriteLine(func.Nome);
            //Console.WriteLine("para chegar a 1520 de salario voce ainda presisa trabalhar {0:#} horas",Funcionario.DinheBolso);           

            ////lista02 exec01 a) -------------------------------------------------------------------
            
            //Cientifica calcu = new Cientifica();
            //Console.WriteLine("digite sua conta");
            //double nu1 = CRD();
            //double nu2 = 0;
            //char cont = CRC();
            //if (cont == 'R')
            //{
            //    nu1 = calcu.RaizNu(nu1);
            //}
            //else if (cont == 'P')
            //{
            //    Console.WriteLine("digite o fator da conta");
            //    nu2 = CRD();
            //    nu1 = calcu.PoteNu(nu1, nu2);
            //}
            //else
            //{
            //    nu2 = CRD();
            //    switch (cont)
            //    {
            //        case '+':
            //            nu1 = calcu.SomaNu(nu1, nu2);
            //            break;

            //        case '-':
            //            nu1 = calcu.SubNu(nu1, nu2);
            //            break;

            //        case 'x':
            //            nu1 = calcu.MultNu(nu1, nu2);
            //            break;

            //        case '/':
            //            nu1 = calcu.DiviNu(nu1, nu2);
            //            break;

            //        default:
            //            Console.WriteLine("Conta invalida!!!");
            //            break;
            //    }
            //}
            //Console.WriteLine("este é o resultado {0:#:##}",nu1);

            
            ////lista02 exec03 b) -------------------------------------------------------------------

            //Empresa02 emp = new Empresa02();

            //List<Funcionario02> func2 = new List<Funcionario02>();
            //func2.Add(new Funcionario02 { Nome = "jorge", Cargo = "peão", Salario = 1350.24, Conta = "1553435554", Saldo = -554 });
            //func2.Add(new Funcionario02 { Nome = "Cleitom", Cargo = "motoboy", Salario = 1630.24, Conta = "21333423455", Saldo = 1554 });
            //func2.Add(new Funcionario02 { Nome = "Dr.Hamilto", Cargo = "gerente", Salario = 2215.56, Conta = "2332223112", Saldo = 6522 });
            //emp.Funcionario = func2; 
            //{
            //    //List<Funcionario02> func = new List<Funcionario02>();
            //    //for (int i = 0; i < 3; i++) // colocar para 5
            //    //{
            //    //    PreecheFunc(func);
            //    //}
            //    //emp.Funcionario = func;
            //}
            //while (true)
            //{
            //    Console.WriteLine("      !BEM VINDO!");
            //    Console.WriteLine();
            //    Console.WriteLine("|  1 - aumento   |");
            //    Console.WriteLine("|  2 - demitir   |");
            //    Console.WriteLine("| 3 - fechamento |");
            //    Console.WriteLine("|    4 - sair    |");
            //    int resp = CRI();
            //    if (resp == 1)
            //    {
            //        {
            //            //foreach (var item in emp.Funcionario)
            //            //foreach (var item in emp.Funcionario)
            //            //{
            //            //    Console.WriteLine();
            //            //}
            //        }

            //        Console.WriteLine("de qual deseja aumentar o salario");
            //        for (int i = 0; i < emp.Funcionario.Count; i++)
            //        {
            //            Console.WriteLine("{0} {1}",i+1,emp.Funcionario[i].Nome);
            //        }
            //        resp = CRI() - 1;
            //        Console.WriteLine("quantos % de aumento");
            //        double aumento = CRD();
            //        emp.Funcionario[resp].Salario *= (emp.Funcionario[resp].Salario * (aumento / 100));//*= é ele mesmo 
            //        Console.WriteLine("conferindo...");
            //        Console.WriteLine(emp.Funcionario[resp].Salario);
            //        Console.WriteLine();
            //        Console.Clear();
            //    }
            //    else if (resp == 2)
            //    {
            //        Console.WriteLine("de qual deseja aumentar o salario");
            //        for (int i = 0; i < emp.Funcionario.Count; i++)
            //        {
            //            Console.WriteLine("{0} {1}", i + 1, emp.Funcionario[i].Nome);
            //        }
            //        resp = CRI() - 1;
            //        emp.Funcionario.RemoveAt(resp);
            //        Console.Clear();
            //    }
            //    else if (resp == 3)
            //    {
            //        double faturamento = 0;
            //        foreach (var item in emp.Funcionario)
            //        {
            //            if (item.Cargo == "peão")
            //            {
            //                faturamento += 4785.26;
            //            }
            //            else if (item.Cargo == "motoboy")
            //            {
            //                faturamento += 5324.82;
            //            }
            //            else
            //            {
            //                foreach (var item2 in emp.Funcionario)
            //                {
            //                    if (item2.Cargo != "gerente")
            //                    {
            //                        faturamento += 2485.64;
            //                    }
            //                }
            //            }
            //        }
            //        emp.Saldo += faturamento;

            //        for (int i = 0; i < emp.Funcionario.Count; i++)
            //        {
            //            emp.Funcionario[i].Saldo += emp.Funcionario[i].Salario;
            //            emp.Saldo -= emp.Funcionario[i].Salario;
            //            faturamento -= emp.Funcionario[i].Salario; 
            //        }
            //        if (faturamento < 0)
            //        {
            //            Console.WriteLine("prejuizo!!!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("deu lucro!!!");
            //            Console.WriteLine("{0:c}",faturamento);
            //        }
            //        Console.WriteLine();
            //        Console.Clear();
            //    }
            //    else if (resp == 3)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("erro apenas numeros");
            //    }
            //}
            
        }
        public static void PreecheFunc (List<Funcionario02> func)
        {
            Funcionario02 estag = new Funcionario02();
            Console.WriteLine("informaçoes pessoais");
            estag.Nome = CR();
            estag.Cargo = CR();
            estag.Salario = CRD();
            Console.WriteLine("DADOS BANCARIOS:");
            estag.Conta = CR();
            estag.Saldo = CRD();
            estag.SenhaConta = CRI();
            func.Add(estag);
        }
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static char CRCc()
        {
            return Convert.ToChar(Console.Read());
        }
        public static int CRI()
        {
            return Convert.ToInt32(CR());
        }
        public static double CRDd()
        {
            return Convert.ToDouble(Console.Read());
        }
        public static double CRD()
        {
            return Convert.ToDouble(CR());
        }
        public static char CRC()
        {
            return Convert.ToChar(CR());
        }
    }
}
