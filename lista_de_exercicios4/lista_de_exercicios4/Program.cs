using System.Runtime.ExceptionServices;

namespace lista_de_exercicios4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            /*
            int[] vetor = new int[10];
            int par=0, impar=0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um valor");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine("Numeros pares: " + par +
                "\nNumeros impares: " + impar);
            */


            //ex2
            /*
            int[] lista1 = new int[20], lista2 = new int[20], soma = new int[20];
            for (int i = 0; i < lista1.Length; i++)
            {
                Console.WriteLine("Digite um valor: ");
                lista1[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < lista1.Length; i++)
            {
                Console.WriteLine("Digite um valor: ");
                lista2[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < lista1.Length; i++)
            {
                soma[i] = lista1[i] + lista2[i];
            }

            for(int i = 0; i< lista1.Length; i++)
            {
                Console.WriteLine(soma[i]);
            }
            */


            //ex3
            /*
            int[] lista = new int[20], primos = new int[20];
            int divisores=0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um valor: ");
                lista[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i<3; i++)
            {
                for (int y = 1; y <= lista[i]; y++)
                {
                    if (lista[i] % y == 0)
                    {
                        divisores++;

                    }

                }
                if (divisores == 2)
                {
                    Console.WriteLine("o numero na posicao: " + i + " é primo");
                   
                }
                divisores = 0;
            }
            */


            //ex 4
            /*
            int[] lista1 = new int[10], lista2 = new int[10], resultado = new int[10];

            for (int i = 0; i < lista1.Length + lista2.Length; i++)
            {
                if (i >= 10)
                {
                    Console.WriteLine("Digite um valor pra lista 2");
                    lista2[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Digite um valor pra lsita 1");
                    lista1[i] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < lista1.Length; i++)
            {
                resultado[i] = lista1[i] * lista2[i];

            }
            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine("O resultado da multiplicaco entre os indices " + i + " é de: " + resultado[i]);
            }
            */


            //ex 5
            /*
            int[] lista = new int[80];
            int menor=0, posicao = 0;
            for(int i = 0; i< 4; i++)
            {
                Console.WriteLine("Digite um valor inteiro: ");
                lista[i] = int.Parse(Console.ReadLine());

            }
            menor = lista[0];
            for(int i = 0; i< 4; i++)
            {
                if (lista[i] < menor)
                {
                    menor = lista[i];
                    posicao = i;
                }

            }
            Console.WriteLine("O menor numero é: " + menor +
                "\nNo indice: " + posicao);
            */


            //ex 6
            int[] lista = new int[10],listai = new int[10];
            int controle = 0;

            for(int i = 0; i< lista.Length; i++)
            {
                Console.WriteLine("Digite um valor pra lista:");
                lista[i] = int.Parse(Console.ReadLine());
            }
            for (int i = (lista.Length-1); i > 0; i--)
            {
                listai[controle] = lista[i];
                controle++;
            }
            for(int i = 0; i< lista.Length; i++)
            {
                Console.WriteLine(listai[i]);
            }


        }
    }
}