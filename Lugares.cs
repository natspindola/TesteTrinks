using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTrinks
{
        public class Lugares
        {
            public Lugares() { }

            public string Nome { get; set; }
            public int Valor { get; set; }

            public Lugares(int valor, string nome)
            {
                this.Valor = valor;
                this.Nome = nome;
            }
        }

}
