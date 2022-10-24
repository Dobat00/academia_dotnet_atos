using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios8
{
    internal class Objetos
    {
        private int x;
        private int y;

        public int X { get; set; }
        public int Y { get; set; }
        public Objetos()
        {

        }
        public Objetos(int valor1, int valor2)
        {
            this.X = valor1;
            this.Y = valor2;
        }

        public void ExibirInformacao()
        {
            Console.WriteLine("Posicao no eixo x: " + this.X + "\nPosicao no eixo y: " + this.Y);
        }
    }
}
