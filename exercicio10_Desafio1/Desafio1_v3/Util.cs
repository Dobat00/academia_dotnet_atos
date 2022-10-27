using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_v3
{
    internal class Util
    {
        public Util()
        {

        }

        public void AdicionarTipo(string arquivo,List<string> listaTipo)
        {
            StreamReader leitor2 = new StreamReader(arquivo);
            string[] dadosLinha;
            string linha2;
            while (!leitor2.EndOfStream)
            {
                linha2 = leitor2.ReadLine();
                dadosLinha = linha2.Split("-");
                if (dadosLinha[0] == "X")
                {
                    listaTipo.Add("X");

                }
                else if (dadosLinha[0] == "Z")
                {
                    listaTipo.Add("Z");
                }
                else if (dadosLinha[0] == "Y")
                { 
                    listaTipo.Add("Y");

                }
            }
            listaTipo.Add("X");
            listaTipo.Add("X");

        }

        public void AdicionarCursos(string arquivo, List<string> listaCurso)
        {
            StreamReader leitor2 = new StreamReader(arquivo);
            string[] dadosLinha;
            string linha2;
            while (!leitor2.EndOfStream)
            {
                linha2 = leitor2.ReadLine();
                dadosLinha = linha2.Split("-");
                if (dadosLinha[0] == "Y")
                {
                    listaCurso.Add(dadosLinha[3]);
                }
            }
        }



        public void AdicionarTodosAlunos(string arquivo,List<Pessoa> listaPessoa,List<Aluno> listaAluno,List<string> listaTipo,List<string>listaCurso)
        {
            StreamReader leitor = new StreamReader(arquivo);
            string[] dadosLinha;
            string linha;
            int auxPessoa = 0;
            int auxTipo = 2;
            int auxCurso = 0;
            while (!leitor.EndOfStream)
            {
                linha = leitor.ReadLine();
                dadosLinha = linha.Split("-");
                if (dadosLinha[0] == "X")
                {

                    continue;
                }
                else if (dadosLinha[0]=="Z" && listaTipo[auxTipo] == "X")
                {
                    Pessoa pessoa = new Pessoa(dadosLinha[1], dadosLinha[2], dadosLinha[3], dadosLinha[4], dadosLinha[5], aluno: false);
                    listaPessoa.Add(pessoa);

                }
                else if (dadosLinha[0] == "Z" && listaTipo[auxTipo] == "Z")
                {
                    Pessoa pessoa = new Pessoa(dadosLinha[1], dadosLinha[2], dadosLinha[3], dadosLinha[4], dadosLinha[5],aluno: false);
                    listaPessoa.Add(pessoa);
                    auxTipo++;
                    auxPessoa++;

                }
                else if (dadosLinha[0] == "Z" && listaTipo[auxTipo] == null)
                {
                    Pessoa pessoa = new Pessoa(dadosLinha[1], dadosLinha[2], dadosLinha[3], dadosLinha[4], dadosLinha[5], aluno: false);
                    listaPessoa.Add(pessoa);
                    
                }
                else if (dadosLinha[0] == "Z" && listaTipo[auxTipo] == "Y")
                {
                    Pessoa pessoa = new Pessoa(dadosLinha[1], aluno: true) ;
                    listaPessoa.Add(pessoa);
                    Aluno aluno = new Aluno(listaPessoa[auxPessoa].Nome, listaCurso[auxCurso]);
                    listaAluno.Add(aluno);
                    //remove.pessoa
                    auxPessoa++;
                    auxTipo++;
                    auxTipo++;
                    auxCurso++;
                }
                else if (dadosLinha[0]=="Y")
                {
                    continue;
                }
            }
        }


        public void MostrarAlunos(List<Aluno> lista)
        {
            int total_alunos = 0; 
            foreach(Aluno aluno in lista)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Curso: " + aluno.Curso);
                Console.WriteLine("____________________________________");
                total_alunos++;
            }
            Console.WriteLine("Foram criados " + total_alunos + " objetos do tipo ALUNO");
        }

        public void MostrarPessoas(List<Pessoa> lista)
        {
            foreach(Pessoa pessoa in lista)
            {
                Console.WriteLine("Pessoa: " + pessoa.Nome);
            }
        }
        
        public void MostrarTipos(List<string> lista)
        {
            foreach(string i in lista)
            {
                Console.WriteLine(i);
            }
        }

        public void MostrarCursos(List<string> lista)
        {
            foreach (string i in lista)
            {
                Console.WriteLine(i);
            }
        }
        
        public void RemoverAlunosDePessoas(List<Aluno> listaAluno, List<Pessoa> listaPessoa, List<Pessoa> PessoasRemovidas)
        {
            int contador = 0;
            for(int i =0; i < listaPessoa.Count; i++)
            {
                if (listaPessoa[i].aluno == false)
                {
                    PessoasRemovidas.Add(listaPessoa[i]);
                    
                }
            }
            for (int i = 0; i < PessoasRemovidas.Count; i++)
            {
                contador++;
            }
            Console.WriteLine("Foram gerados " + contador + " objetos do tipo Pessoa");

        }
    }
}
