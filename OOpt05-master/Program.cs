using System;
using System.Collections.Generic;

namespace OOpt05
{
    class Program
    {
        static void Main(string[] args)
        {
            ////exec01 ------------------------------------------------------------------------

            //Empresa emp = new Empresa();
            //Console.WriteLine("Preencha a Empreza");
            //emp.Nome = CR();
            //emp.Idade = CRI();
            //emp.Saldo = CRD();
            //emp.Funcionarios = CRI();
            //emp.Cnpj = CR();
            //emp.Rua = CR();
            //emp.Cep = CR();
            //emp.Cidade = CR();
            //emp.Estado = CR();
            //emp.Pais = CR();
            //// formatar o CNPJ @"{0:00\.000\.000\/0000\-00}"
            //if (emp.Funcionarios > 8)
            //{
            //    Console.WriteLine(@"{0}  {1}  {2:00\.000\.000\/0000\-00}", emp.Nome, emp.Idade, Convert.ToInt64(emp.Cnpj));
            //    Console.WriteLine("{0:c}  {1}", emp.Saldo, emp.Funcionarios);
            //    Console.WriteLine("{0}  {1}  {2}", emp.Rua, emp.Cep, emp.Cidade);
            //    Console.WriteLine("{0}  {1}", emp.Estado, emp.Pais);
            //}
            //else
            //{
            //    Console.WriteLine("Micro empresa");
            //}

            ////exec01 b) -------------------------------------------------------------------------------

            //List<Carro> carr = new List<Carro>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Carro car = new Carro();
            //    Console.WriteLine("insira o carro");
            //    car.Modelo = CR();
            //    car.Cavalos = CRI();
            //    Console.WriteLine("insira informações do dono");
            //    car.Nome = CR();
            //    car.Idade = CRI();
            //    car.Cpf = CR();
            //    Console.WriteLine("insira o endereco");
            //    car.Rua = CR();
            //    car.Cep = CR();
            //    car.Cidade = CR();
            //    car.Estado = CR();
            //    car.Pais = CR();
            //    carr.Add(car);
            //}

            //BestCar(carr);

            //Console.WriteLine();
            //Console.WriteLine("=================================");
            //foreach (var item in carr)
            //{
            //    Console.WriteLine(item.Modelo);
            //    Console.WriteLine(item.Cavalos);
            //    Console.WriteLine(item.Nome);
            //    Console.WriteLine(item.Idade);
            //    Console.WriteLine(item.Cpf);
            //    Console.WriteLine(item.Rua);
            //    Console.WriteLine(item.Cep);
            //    Console.WriteLine(item.Cidade);
            //    Console.WriteLine(item.Estado);
            //    Console.WriteLine(item.Pais);
            //    Console.WriteLine();
            //}

            ////exec02 a) --------------------------------------------------------------------

            //List<Funcionario> func = new List<Funcionario>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Funcionario cio = new Funcionario();
            //    Console.WriteLine("insira os dados do funcionario");
            //    cio.Nome = CR();
            //    cio.Idade = CRI();
            //    cio.Cpf = CR();
            //    Console.WriteLine("coloque seu cargo e salario");
            //    cio.Cargo = CR();
            //    cio.Salario = CRD();
            //    Console.WriteLine("coloque seu endereco");
            //    cio.Rua = CR();
            //    cio.Cep = CR();
            //    cio.Cidade = CR();
            //    cio.Estado = CR();
            //    func.Add(cio);
            //}

            //Console.WriteLine();
            //Console.WriteLine("=====================================");

            //int cond = 1;
            //foreach (var item in func)
            //{
            //    if (item.Salario < 1800)
            //    {
            //        cond = 0;
            //    }
            //}

            //if (cond == 1)
            //{
            //    foreach (var item in func)
            //    {
            //        Console.WriteLine(item.Nome);
            //        Console.WriteLine(item.Idade);
            //        Console.WriteLine(item.Cpf);
            //        Console.WriteLine(item.Cargo);
            //        Console.WriteLine(item.Salario);
            //        Console.WriteLine(item.Rua);
            //        Console.WriteLine(item.Cep);
            //        Console.WriteLine(item.Cidade);
            //        Console.WriteLine(item.Estado);
            //        Console.WriteLine();
            //    }
            //}
            //else if (cond == 0)
            //{
            //    foreach (var item in func)
            //    {
            //        if (item.Salario < 1800)
            //        {
            //            Console.WriteLine(item.Nome);
            //            Console.WriteLine(item.Idade);
            //            Console.WriteLine(item.Cpf);
            //            Console.WriteLine(item.Cargo);
            //            Console.WriteLine(item.Salario);
            //            Console.WriteLine(item.Rua);
            //            Console.WriteLine(item.Cep);
            //            Console.WriteLine(item.Cidade);
            //            Console.WriteLine(item.Estado);
            //            Console.WriteLine();
            //        }
            //    }
            //}

            ////exec02 b) -------------------------------------------------------

            //Mae mama = new Mae();
            //Console.WriteLine("insira os dados");
            //Console.WriteLine("nome, idade e cpf");
            //mama.Nome = CR();
            //mama.Idade = CRI();
            //mama.Cpf = CR();
            //Console.WriteLine("conjugue e quantos filhos");
            //mama.Conjugue = CR();
            //mama.QuantFilho = CRI();
            //Console.WriteLine("endereco rua, cep, cidade e estado");
            //mama.Rua = CR();
            //mama.Cep = CR();
            //mama.Cidade = CR();
            //mama.Estado = CR();

            //Console.WriteLine();
            //Console.WriteLine("=======================================");
            //while (true)
            //{
            //    Console.WriteLine("seus dados:");
            //    Console.WriteLine();
            //    Console.WriteLine(mama.Nome);
            //    Console.WriteLine(mama.Idade);
            //    Console.WriteLine(mama.Cpf);
            //    Console.WriteLine(mama.Conjugue);
            //    Console.WriteLine(mama.QuantFilho);
            //    Console.WriteLine(mama.Rua);
            //    Console.WriteLine(mama.Cep);
            //    Console.WriteLine(mama.Cidade);
            //    Console.WriteLine(mama.Estado);

            //    Console.WriteLine();

            //    Console.WriteLine("gostaria de alterar algo");
            //    string resp = CR();
            //    if (resp == "sim")
            //    {
            //        Console.WriteLine("qual gostaria de alterar?");
            //        resp = CR();
            //        switch (resp)
            //        {
            //            case "nome":
            //                Console.WriteLine("pelo que gostaria de alterar?");
            //                mama.Nome = CR();
            //                Console.WriteLine();
            //                break;

            //            case "idade":
            //                Console.WriteLine("pelo que gostaria de alterar?");
            //                mama.Idade = CRI();
            //                Console.WriteLine();
            //                break;

            //            case "cpf":
            //                Console.WriteLine("pelo que gostaria de alterar?");
            //                mama.Cpf = CR();
            //                Console.WriteLine();
            //                break;

            //            case "conjugue":
            //                Console.WriteLine("pelo que gostaria de alterar?");
            //                mama.Conjugue = CR();
            //                Console.WriteLine();
            //                break;

            //            case "filhos":
            //                Console.WriteLine("pelo que gostaria de alterar?");
            //                mama.QuantFilho = CRI();
            //                Console.WriteLine();
            //                break;

            //            case "rua":
            //                Console.WriteLine("pelo que gostaria de alterar?");
            //                mama.Rua = CR();
            //                Console.WriteLine();
            //                break;

            //            case "cep":
            //                Console.WriteLine("pelo que gostaria de alterar?");
            //                mama.Cep = CR();
            //                Console.WriteLine();
            //                break;

            //            case "cidade":
            //                Console.WriteLine("pelo que gostaria de alterar?");
            //                mama.Cidade = CR();
            //                Console.WriteLine();
            //                break;

            //            case "estado":
            //                Console.WriteLine("pelo que gostaria de alterar?");
            //                mama.Estado = CR();
            //                Console.WriteLine();
            //                break;

            //            default:
            //                Console.WriteLine("esta opção não existe");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}










        }
        public static void SortManual(List<Ciclista> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j < 0; j--)
                {

                }
            }
        }
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CRI()
        {
            return Convert.ToInt32(CR());
        }
        public static double CRD()
        {
            return Convert.ToDouble(CR());
        }
        public static void BestCar(List<Carro> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (list[j - 1].Cavalos < list[j].Cavalos)
                    {
                        var a = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = a; 
                    }
                }
            }
        }
       
    }
}
