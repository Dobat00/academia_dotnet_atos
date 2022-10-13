using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios7
{
    internal class livro
    {
        public string nome;
        public string genero;
        public string quantidade_paginas;
        public livro(string g, string qp,string n)
        {
            this.genero = g;
            this.quantidade_paginas = qp;
            this.nome = n;
        }
        public void exibir_dados()
        {
            Console.WriteLine("Nome do livro: " + nome);
            Console.WriteLine("Genero do livro: " + genero);
            Console.WriteLine("Quantidade de paginas: "+ quantidade_paginas);
        }
    }
}
