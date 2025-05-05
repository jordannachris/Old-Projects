using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosURI
{
    public class Desafio1074
    {
        public static void metodo()
        {
            int N = int.Parse(Console.ReadLine());
            int i;

            for (i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X % 2 == 0)
                {
                    if (X == 0)
                    {
                        Console.WriteLine("NULL");
                    }

                    else
                    {
                        if (X < 0)
                        {
                            Console.WriteLine("EVEN NEGATIVE");
                        }

                        if (X > 0)
                        {
                            Console.WriteLine("EVEN POSITIVE");
                        }
                    }
                }

                if (X % 2 != 0)
                {
                    if (X < 0)
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }

                    if (X > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
            }
        }
    }
}
