using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios7
{
    internal class Elevador
    {
        public int andar_atual = 0;
        public int andares;
        public int capacidade;
        public int pessoas = 0;

        public Elevador()
        {

        }

        public void inicializa(int capacidade, int andares)
        {
            this.capacidade = capacidade;
            this.andares = andares; 
            Console.WriteLine("Elevador inicializando");
        }
        public void entra()
        {
            if (this.pessoas < this.capacidade)
            {
                Console.WriteLine("Uma pessoa entrou no elevador");
                this.pessoas++;
                Console.WriteLine("Tem " + this.pessoas + " no elevador");
            }
            else
            {
                Console.WriteLine("Desculpe, o elevador esta cheio!");

            }
        }

        public void sai()
        {
            if (this.pessoas != 0)
            {
                Console.WriteLine("Uma pessoa saiu do elevador");
                this.pessoas--;
                Console.WriteLine("Tem " + this.pessoas + " no elevador");
            }
            else
            {
                Console.WriteLine("Nao há ninguem no elevador");
            }
        }
        
        
        public void sobe()
        {
            if (this.andar_atual < this.andares)
            {
                Console.WriteLine("Subindo!");
                this.andar_atual++;
                Console.WriteLine("Estamos no andar: " + this.andar_atual);
            }
            else
            {
                Console.WriteLine("ja estamos no ultimo andar!");
            }

        }


        public void desce()
        {
            if (this.andar_atual == 0)
            {
                Console.WriteLine("Ja estamos no terreo");
            }
            else
            {
                Console.WriteLine("Descendo!");
                this.andar_atual--;
                Console.WriteLine("estamos no andar: " + this.andar_atual);
            }
        }

    }
}
