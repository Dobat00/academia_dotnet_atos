using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListaExercicios9
{
    internal class Util
    {
        public static void GravarPessoaNoArquivo(Pessoa pessoa, string nomeArquivo )
        {
            StreamWriter writer = new StreamWriter(nomeArquivo, append: true);
            writer.WriteLine(pessoa.Nome + ";" + pessoa.Email);
            writer.Flush();
            writer.Close();
        }
    }
}
