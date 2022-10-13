using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios7
{
    internal class Cliente
    {
        private string nome;
        private int idade;
        public void setnome (string nome)
        {
            this.nome = nome;
        }

        public void setidade(int idade)
        {
            this.idade = idade;
        }
        
        public string getnome()
        {
            return nome;
        }
        public int getidade()
        {
            return idade;
        }
    }
}
