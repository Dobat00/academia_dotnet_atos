using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios8
{
    internal class Item_cenario
    {
        DateTime _date = DateTime.Now;
        private string descricao;
        private DateTime criacao;
        private double altura;
        public DateTime data_criacao;
        //construtor
        public Item_cenario()
        {

        }
        
        //getters e setters
        public string Descricao { get; set; }
        public DateTime Criacao { get; set; }
        public double Altura { get; set; }


        //metodos
        public void Mostrar_informacao()
        {
            Console.WriteLine("Descricao: "+this.Descricao+"\nData de criacao: "+ this.Criacao + "\nAltura: "+ this.Altura);
        }

        public void Mostrar_tempo_criado()
        {
            int Diferenca;
            Diferenca = _date.Minute - this.Criacao.Minute;
            Console.WriteLine("O item foi criado ja faz: " +  Diferenca);
        }

        public void Gerar_data()
        {

            this.Criacao = _date;
        }
    }
}
