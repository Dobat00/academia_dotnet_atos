using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios7
{
    internal class Controle_remoto
    {
        public Televisao tv =  new Televisao();
        public int Aumentar_valume()
        {
            tv.volume++;
            Console.WriteLine(tv.volume);
            return tv.volume;
        }
        public int Diminuir_volume()
        {
            tv.volume--;
            Console.WriteLine(tv.volume);
            return tv.volume;
        }
        public int Subir_canal()
        {
            tv.canal++;
            Console.WriteLine(tv.canal);
            return tv.canal;
        }
        public int Diminuir_canal()
        {
            tv.canal--;
            Console.WriteLine(tv.canal);
            return tv.canal;
        }
        public int Exibir_informacoes()
        {
            Console.WriteLine("Canal: " + tv.canal + "\nVolume: " + tv.volume);
            return tv.canal;
            return tv.volume;


        }
    }
}
