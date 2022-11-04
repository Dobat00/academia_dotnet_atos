using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCadastroJogador
{
    internal class Jogador
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public Jogador(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public Jogador(string nome)
        {
            Nome = nome;
        }
    }
}
