using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_v3
{
    internal class Aluno : Pessoa
    {
        public string Curso { get; set; }
        public string Matricula { get; set; }
        public string CodigoDoCurso { get; set; }


        public Aluno()
        {

        }

        public Aluno(string nome, string telefone, string cidade, string rg, string cpf, string matricula, string codigodocurso, string curso)
        {
            Nome = nome;
            Telefone = telefone;
            Cidade = cidade;
            Rg = rg;
            Cpf = cpf;
            Curso = curso;
            Matricula = matricula;
            CodigoDoCurso = codigodocurso;
        }
        public Aluno(string nome, string curso)
        {
            Nome = nome;
            Curso = curso;
        }
    }
}
