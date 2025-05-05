using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosURI
{
    public class Desafio1160
    {

        static int calculaCrescimento(int P, double G)
        {
            double crescimento = P * (G / 100);
            int c = Convert.ToInt32(crescimento);
            return c;
        }

        public static void metodo()
        {

            int T = int.Parse(Console.ReadLine());


            for (int i = 0; i < T; i++)
            {
               
                string entrada = Console.ReadLine().Trim();

                string[] dados = entrada.Split(' ');

                int PA = int.Parse(dados[0]);
                int PB = int.Parse(dados[1]);
                double G1 = double.Parse(dados[2]);
                double G2 = double.Parse(dados[3]);


                


                int anos = 0;

                while (PA <= PB)
                {
                    anos++;
                    PA = PA + calculaCrescimento(PA,G1);
                    PB = PB + calculaCrescimento(PB,G2);

                }

                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");

                    //Environment.Exit(0);
                    //break;
                }
                else
                {
                    Console.WriteLine(anos + " anos.");
                }

            } //fim do FOR

        } //fim do METODO

    }
}
