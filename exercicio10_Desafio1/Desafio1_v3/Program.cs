namespace Desafio1_v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Util util = new Util();
            List<Aluno> listaAlunos = new List<Aluno>();
            List<Pessoa> listaPessoas = new List<Pessoa>();
            List<Pessoa> pessoasRemovidas = new List<Pessoa>();
            List<string> tipoPessoa = new List<string>();
            List<string> listaCursos = new List<string>();


    
            util.AdicionarCursos(@"C:\Users\Dobat\source\repos\Desafio1_v3\alunos.txt", listaCursos);
            util.AdicionarTipo(@"C:\Users\Dobat\source\repos\Desafio1_v3\alunos.txt", tipoPessoa);
            util.AdicionarTodosAlunos(@"C:\Users\Dobat\source\repos\Desafio1_v3\alunos.txt", listaPessoas, listaAlunos,tipoPessoa,listaCursos);
            util.RemoverAlunosDePessoas(listaAlunos, listaPessoas,pessoasRemovidas);
            util.MostrarPessoas(pessoasRemovidas);
            Console.WriteLine("______________________");
            util.MostrarAlunos(listaAlunos);
   
        }
    }
}