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
            /*
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
            */


            //ex 7
            /*
            int[] lista = new int[10], lista2 = new int[10];
            int controle = 0;
            for (int i= 0; i < lista.Length; i++)
            {
                Console.WriteLine("Digite um valor pra lista");
                lista[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < lista.Length - 1; i++)
            {
                if (lista[i] % 2 == 0)
                {
                    lista2[0] = lista[i];
                }
            }
            */

            //ex 8
            /*
            int[] lista = new int[30], menor_que_zero = new int[30];
            int controle = 0;

            for(int i = 0; i< lista.Length; i++)
            {
                Console.WriteLine("DIgite um valor pra lista");
                lista[i] = int.Parse(Console.ReadLine());
            }


            for(int i = 0; i < lista.Length; i++)
            {
                if (lista[i] < 0)
                {
                    menor_que_zero[0] = lista[i];
                    controle++;
                }
                
            }


            for(int i = 0; i< menor_que_zero.Length; i++)
            {
                Console.WriteLine(menor_que_zero [i]);
            }
            */


            //ex 9
            /*
            int[] lista = new int[10], crescente = new int[10];
            int menor;

            for (int i = 0; i< lista.Length; i++)
            {
                Console.WriteLine("Digite um valor pra lista: \n");
                lista[i] = int.Parse(Console.ReadLine());
            }
            menor = lista[0];

            for (int i = 0; i < lista.Length; i++)
            {
                for(int j = 0; j< lista.Length; i++)
                {
                    if (lista[i] < lista[j])
                    {
                        menor = lista[i];
                    }
                    else
                    {
                        menor = lista[j];
                    }
                }
                crescente[i] = menor;
            }

            for (int i = 0; i< crescente.Length; i++)
            {
                Console.WriteLine(crescente[i]);
            }
            */


            //ex10
            /*
            int[] vetor = new int[20];
            int tamanho=0;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                Console.WriteLine("Digite um valor para o vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0;i< vetor.Length-1; i++)
            {
                if (vetor[i] == 0)
                {
                    tamanho++;
                }
            }
            if (tamanho > 0)
            {
                int[] vetor2 = new int[tamanho];
                for (int i = 0; i < vetor2.Length; i++)
                {
                    vetor2[i] = 2;
                }
                Console.WriteLine("Vetor 2:\n");
                for (int i = 0; i < vetor2.Length; i++)
                {
                    Console.WriteLine(vetor2[i]);
                }
            }
            Console.WriteLine("Vetor 1:\n ");
            for (int i = 0;i< vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            */

            //ex11
            /*
            int[] vetor = new int[5];
            for (int i = 0; i <= vetor.Length - 1; i++)
            {
                Console.WriteLine("Digite um valor para o vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vetor invertido: ");
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(vetor[i]);
            }
            */


            //ex12
            /*
            int[] vetor = new int[10];
            int valor;
            for (int i = 0; i <= vetor.Length -1; i++)
            {
                Console.WriteLine("Qual o valor que deseja colocar:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Qual valor deseja procurar? ");
            valor = int.Parse(Console.ReadLine());
            for (int i = 0; i<= vetor.Length; i++)
            {
                if (vetor[i]== valor)
                {
                    Console.WriteLine(valor + " se encontra no vetor! Na posicao "+ i);
                }
                else
                {
                    Console.WriteLine("o valor nao foi encontrado");
                }
            }
            */


            //ex13
            /*
            int[] vetor = new int[10];
            int dois = 0, quatro = 0, oito = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("DIgite o valor que deseja colocar: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == 2)
                {
                    dois++;
                }
                else if (vetor[i] == 4)
                {
                    quatro++;
                }
                else if (vetor[i] == 8)
                {
                    oito++;
                }
            }
            Console.WriteLine("Quantidades de 2: " + dois +
                "Quantidades de 4: " + quatro +
                "Quantidades de 8: " + oito);
            */


            //ex14
            /*
            int[] vetor = new int[50];
            int resposta;
            Console.WriteLine("Digite um codigo(0 = fim/ 1= mostrar o vetor/2= mostrar o vetor invertido: "):
            resposta = int.Parse(Console.ReadLine());
            if (resposta == 0)
            {
                break;
            }
            else if(resposta == 1)
            {
                for(int i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
            else if(resposta == 2)
            {
                for(int i = vetor.Length-1; i >= 0; i--)
                {
                    Console.WriteLine(vetor[i]);
                }
            }




            

            //ex de ordenacao 
            /*
            int[] vetor = new int[5] { 10, 7, 3, 4, 2 };
            int aux = 0;
            for (int i = 0; i< 5; i++)
            {
                for (int j=0; j<4; j++)
                {
                    if (vetor[j + 1] < vetor[j])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            for (int i = 0; i< 5; i++)
            {
                Console.WriteLine("vetor[" + i + "]= " + vetor[i]);
            }
            */


            //ex 16
            /*
            int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] y = new int[10] { 1, 6, 30, 4, 5, 60, 7, 9, 10, 11 };
            int[] uniao = new int[20];
            int[] diferenca = new int[10];
            int[] interseccao = new int[10];
            Console.WriteLine("UNIÃO");
            x.CopyTo(uniao, 0);
            int auxU = 10;
            for (int j = 0; j < x.Length; j++)
            {
                if (y[i] == x[j])
                {
                    break;
                }
                if (j == (x.Length - 1))
                {
                    uniao[auxU] = y[i];
                    auxU++;
                }
            }
        
            for (int i = 0; i<auxU; i++)
            {
                Console.WriteLine(uniao[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("DIFERENÇA");
            int auxD = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        break;
                    }
                    if(j == (y.Length-1))
                    {
                        diferenca[auxD] = x[i];
                        auxD++;
                    }
                }
            }
            for (int i = 0; i < auxD; i++)
            {
                Console.WriteLine(diferenca[i]);
            }
            Console.WriteLine("");


            Console.WriteLine("INTERSECÇÃO");
            int auxI = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        interseccao[auxI] = x[i];
                        auxI++;
                        break;
                    }
                }
            }
            for (int i = 0; i < auxI; i++)
            {
                Console.WriteLine(interseccao[i]);
            }
            Console.WriteLine("");
            */


        }
    }
}