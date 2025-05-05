using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosURI
{
    public class Desafio1153
    {
        public static void metodo()
        {

            int N = int.Parse(Console.ReadLine());
            int ene = N;
            int i;

            for (i = 1; (ene-i)>=1; i++)
            {
                N = N * (ene - i);
            }

            Console.WriteLine(N);
        }
        
    }
}
