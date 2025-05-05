using System;
using PrimeiroPrograma.Modelos;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            /***EXERCICIO 1
            Console.WriteLine("Digite três números: ");
            string n1 = Console.ReadLine(); //toda entrada é no formato de string
            string n2 = Console.ReadLine(); // mas tudo é string? e os números?
            string n3 = Console.ReadLine(); 

            double num1 = double.Parse(n1); //converte string em double
            double num2 = double.Parse(n2); //converte string em double
            double num3 = double.Parse(n3); //converte string em double

            Console.WriteLine("A multiplicação é: " + (num1 * num2 * num3));
            **/

            /***EXERCICIO 2***/
            Cliente clienteA = new Cliente();
            clienteA.Nome = "Douglas";
            clienteA.Sobrenome = "Fernandes";
            Console.WriteLine(clienteA.NomeCompleto());

            var clienteB = new Cliente(); //var - tipo implícito 
            clienteB.Nome = "Jordanna";
            clienteB.Sobrenome = "Costa";
            Console.WriteLine(clienteB.NomeCompleto());
            Cliente clienteC = new Cliente()
            {
                Nome = "João",
                Sobrenome = "Pedro"
            }; //atribuir as propriedades na criação
            Console.WriteLine(clienteC.NomeCompleto());
            
        }
    }
}
