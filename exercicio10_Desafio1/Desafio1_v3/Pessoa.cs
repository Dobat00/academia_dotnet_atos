using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_v3
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public bool aluno { get; set; }

        public Pessoa()
        {

        }
        public Pessoa(string nome, string telefone, string cidade, string rg, string cpf, bool aluno)
        {
            Nome = nome;
            Cidade = cidade;
            Telefone = telefone;
            Rg = rg;
            Cpf = cpf;
            this.aluno = aluno;
        }
        public Pessoa(string nome,bool aluno)
        {
            this.aluno= aluno;
            Nome = nome;
        }
    }
}
