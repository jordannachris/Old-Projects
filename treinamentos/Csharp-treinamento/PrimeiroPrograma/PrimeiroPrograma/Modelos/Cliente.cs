using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Modelos
{
    //[modificador de acesso] - [class] - [identificador]
    public class Cliente
    {
        public Cliente()
        { } //construtor simples
        public Cliente(int idade)
        {
            this.idade = idade; //this.idade para diferencia o campo do parametro
        }
        private int idade; // campo - field
        public string Nome { get; set; } // propriedade - property
        public string Sobrenome { get; set; } // propriedade - property
                                              //[modificador de acesso] - [Tipo de retorno] - [identificador]
        public string FaltaQuantosAnosPara(int idadeAlvo)
        {
            int diferenca = idadeAlvo - idade;
            if (diferenca >= 0)
                return "Falta(m) " + diferenca + " Anos(s)";
            else
            {
                return "Já passou da idade";
            }
        }
        //[modificador de acesso] - [Tipo de retorno] - [identificador]
        public string NomeCompleto()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
