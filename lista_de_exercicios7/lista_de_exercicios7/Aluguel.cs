using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios7
{
    internal class Aluguel
    {
        public int valor_diario;
        public DateTime inicio;
        public DateTime termino;
        public bool seguro;
        public Carro carro;
        public Cliente cliente;
        public void exibir_dados()
        {
            Console.WriteLine("Nome do cliente: " + cliente.getnome());
            Console.WriteLine("Idade do cliente: " + cliente.getidade()) ;
            Console.WriteLine("Marca do carro: " + carro.marca);
            Console.WriteLine("Modelo do carro: " + carro.modelo);
            Console.WriteLine("Placa do carro: " + carro.placa);
            Console.WriteLine("Valor diario" + valor_diario);
            Console.WriteLine("Seguro: sim");
            Console.WriteLine("Data de inicio: "+inicio);
            Console.WriteLine("Data de termino: " + termino);
        }
    }
}
