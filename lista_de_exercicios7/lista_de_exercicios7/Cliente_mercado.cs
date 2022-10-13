using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lista_de_exercicios7
{
    internal class Cliente_mercado
    {
        public Produtos produtos;
        public int quantidade;
        public double total;
        public string pagamento;

        public void preco_total()
        {
            this.total = produtos.preco * quantidade;
        }
    }
}
