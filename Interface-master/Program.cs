using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Pessoa> people = new List<Pessoa>();
            //while (true)
            //{
            //    Console.WriteLine("insira uma pessoa ou apenas aperte enter para encerrar");
            //    Pessoa pes = new Pessoa();
            //    pes.Nome = CR();
            //    if (pes.Nome == "")
            //    {
            //        Console.WriteLine("Agradecemos pelo uso, volte sempre");
            //        break;
            //    }
            //    pes.Idade = Convert.ToInt32(CR());
            //    pes.Cpf = CR();
            //    bool insere = true;
            //    foreach (var item in people)
            //    {
            //        if (item.Cpf == pes.Cpf)
            //        {
            //            insere = false;
            //            break;
            //        }
            //    }
            //    if (insere)
            //    {
            //        Console.WriteLine("Pessoa adicionada");
            //        people.Add(pes);
            //    }
            //    else
            //    {
            //        Console.WriteLine("CPF ja existente, pessoa não adicionada");
            //    }
            //    MostraPessoa(people);
            //}

            ////exec02 ----------------------------------------------------------------------------------
            //List<Hotel> hoteis = new List<Hotel>();
            //Random rand = new Random();
            //List<int> maisVagas = new List<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Hotel hot = new Hotel();
            //    hot.Nome = "hotel " + (i + 1);
            //    hot.QtdQuartos = rand.Next(20, 50 + 1);
            //    hot.QtdQuartosOcupados = rand.Next(0, hot.QtdQuartos + 1);
            //    maisVagas.Add(hot.QtdQuartos - hot.QtdQuartosOcupados);
            //    hoteis.Add(hot);
            //}
            //while (true)
            //{
            //    foreach (var item in hoteis)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine(item.Nome);
            //        Console.WriteLine(item.QtdQuartos);
            //        Console.WriteLine(item.QtdQuartosOcupados);
            //        Console.WriteLine("<------------->");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("qual hotel gostaria de se hospedar?");
            //    int resp = CRI();
            //    if (hoteis[resp].QtdQuartos == hoteis[resp].QtdQuartosOcupados)
            //    {
            //        Console.WriteLine("este hotel todos os quatos estão ocupados");
            //        SelectNu(hoteis, maisVagas);
            //        Console.WriteLine("sugiro que escolha este hotel:");
            //        Console.WriteLine();
            //        Console.WriteLine(hoteis[0].Nome);
            //        Console.WriteLine(hoteis[0].QtdQuartos);
            //        Console.WriteLine(hoteis[0].QtdQuartosOcupados);
            //    }
            //    else
            //    {
            //        Console.WriteLine("voce escolheu o " + hoteis[resp].Nome);
            //        Console.WriteLine("foi agendado para dia 19/07/21");
            //        break;
            //    }
            //}
        }
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CRI()
        {
            return Convert.ToInt32(CR());
        }
        public static void MostraPessoa(List<Pessoa> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine();
                Console.WriteLine("Nome : {0}",item.Nome);
                Console.WriteLine("Idade : {0}",item.Idade);
                Console.WriteLine(@"CPF : {0:000\.000\.000\-00}",Convert.ToInt64(item.Cpf));
                Console.WriteLine("<-------------->");
            }
        }
        public static void SelectNu(List<Hotel> lista, List<int> quantVagas)
        {

            for (int i = 0; i < quantVagas.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (quantVagas[j - 1] < quantVagas[j])
                    {
                        int a;
                        a = quantVagas[j];
                        quantVagas[j] = quantVagas[j - 1];
                        quantVagas[j - 1] = a;

                        Hotel b;
                        b = lista[j];
                        lista[j] = lista[j - 1];
                        lista[j - 1] = b;
                    }
                }
            }
        }
    }
}
