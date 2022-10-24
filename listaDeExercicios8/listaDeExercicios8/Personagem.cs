using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios8
{
    internal class Personagem
    {
        private string nome { get; set; }
        private int poder { get; set; }

        public Personagem()
        {

        }
        public Personagem(string nome, int poder)
        {
            this.nome = nome;
            this.poder = poder;
        }

        public void exibir_dados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Poder: " + this.poder);
        }

        public void maior_poder(Personagem esse,Personagem aquele)
        {
            if(this.poder > esse.poder && this.poder > aquele.poder)
            {
                Console.WriteLine("O " + this.nome + " possui o maior poder");

            }
            else if(esse.poder > this.poder && esse.poder > aquele.poder)
            {
                Console.WriteLine("O " + esse.nome + " possui o maior poder");

            }
            else
            {
                Console.WriteLine("O " + aquele.nome + " possui o maior poder");
            }
        }
    }
}
