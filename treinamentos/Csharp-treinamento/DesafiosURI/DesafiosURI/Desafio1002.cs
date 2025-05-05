using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosURI
{
    public class Desafio1002
    {
        public static void metodo()
        {
            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double area;

            area = n * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4"));
            
        }
    }
}
