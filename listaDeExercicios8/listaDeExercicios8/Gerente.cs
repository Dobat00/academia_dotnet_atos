using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios8
{
    internal class Gerente : Funcionario
    {
        public Gerente()
        {

        }
        public Gerente(String nome, string departamento, double salario, string dataDeEntrada, string rg, bool status) : base(nome, departamento, salario, dataDeEntrada, rg, status) { }
        public override void ExecutaTrabalho()
        {
            Console.WriteLine("Gerente: Gerencia o estabelecimento, e os demais funcionarios");
        }
    }
}
