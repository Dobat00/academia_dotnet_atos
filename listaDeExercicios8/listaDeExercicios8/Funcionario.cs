using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios8
{
    abstract class Funcionario
    {
        private string nome;
        private string departamento;
        private double salario;
        private string dataEntradaNoBanco;
        private string rg;
        private bool status;
        
        //getters e setters
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }
        public string DataEntradaNoBanco { get; set; }
        public string Rg { get; set; }
        public bool Status { get; set; }

        //Construtores
        public Funcionario(String nome, string departamento, double salario, string dataDeEntrada, string rg, bool status)
        {
            this.Nome = nome;
            this.Departamento = departamento;
            this.Salario = salario;
            this.DataEntradaNoBanco = dataDeEntrada;
            this.Rg = rg;
            this.Status = status;
        }

        public abstract void ExecutaTrabalho()
        {

        }

        public void Bonifica(double valor)
        {
            this.Salario = this.Salario + valor;
        }

        public void Demite()
        {
            this.Status = !this.Status;
        }


    }
}
