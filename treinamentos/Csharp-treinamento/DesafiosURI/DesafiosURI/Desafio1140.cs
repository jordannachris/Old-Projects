using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosURI
{
	public class Desafio1140
	{
		public static void metodo()
		{
			string fraseInicial = Console.ReadLine();


			while (fraseInicial != "*")
			{
				bool teste = true;
				int i;

				string[] fraseSeparada = fraseInicial.ToLower().Split(' ');


				for (i = 0; i < fraseSeparada.Length; i++)
				{
					if (i != 0)
					{
						/*fraseSeparada[i][0] -- o [i] vai aumentando e passando de palavra em palavra,
						enquanto o [0] sempre refere-se à primeira letra de cada palavra*/

						/*fraseSeparada[i - 1][0] -- enquanto o primeiro vai passando pelas palavras, esse segundo ajuda 
						 a fazer a comparação da "palavra atual" com a palavra que está uma posição atrás [i-1],
						já o [0] sempre refere-se à primeira letra da palavra anterior*/

						if (fraseSeparada[i][0] != fraseSeparada[i - 1][0])
						{
							teste = false;
							break;
						}

					}
				}
				if (teste == true)
				{
					Console.WriteLine("Y");
				}
				if (teste == false)
				{
					Console.WriteLine("N");

				}
				fraseInicial = Console.ReadLine();
			}
		}
	}
}