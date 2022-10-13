using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios7
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public string olhos;
        public string cabelos;
        public double altura;
        public Pessoa(string nome, int idade, string olhos, string cabelos, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.olhos = olhos;
            this.cabelos = cabelos;
            this.altura = altura;
        }
        public void exibir_dados()
        {
            Console.WriteLine(nome+ idade+ olhos+ cabelos+altura);
        }
    }
}
