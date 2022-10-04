using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Aulas_dotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aula dia 23/09/2022
            //EXEMPLO 19
            //Dados 3 numeros, verificar se é possivel a formacao de um triangulo isoceles, equilatero ou escaleno
            /*
            int lado1, lado2, lado3;
            Console.WriteLine("Digite um valor do lado1:\n");
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor do lado2:\n");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor do lado3:\n");
            lado3 = int.Parse(Console.ReadLine());

            if ((lado1 < lado2 + lado3) && (lado2 < lado3 + lado1) && (lado3 < lado1 + lado2))
            {
                Console.WriteLine("É possivel a formacao de um triangulo");
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("\n e o triangulo sera equilatero");
                }
                else if (lado1 == lado2 || lado2 == lado3)
                {
                    Console.WriteLine("\n e o triangulo é isoceles");
                }
                else if (lado1 != lado2 && lado2 != lado3)
                {
                    Console.WriteLine("\n e o triangulo é escaleno");
                }
            }
            else
            {
                Console.WriteLine("Nao é possivel a formacao de um triangulo");
            }
            */


            //aula 27/09/22
            /*
            int soma = 0;
            for (int i = 56; i < 127; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine(soma);
            */

            //contar quantos numeros pares existem entre 55 e 127
            /*
            int contagem = 0;
            for (int i = 56; i < 127; i++)
            {
                if (i%2 == 0)
                {
                    contagem++;
                }

            }
            Console.WriteLine(contagem);
            */

            //contar os numeros impares e somar os pares de 55 ate 127
            /*
            int contagem = 0, soma = 0;
            for (int i = 56; i < 127; i++)
            {
                if (i%2 == 0)
                {
                    soma = soma + i;
                }
                else
                {
                    contagem = contagem + 1;
                }
            }
            Console.WriteLine(contagem);
            Console.WriteLine(soma);
            */

            //o mesmo exercicio, porem com os limites de "i" informado pelo usuario;
            /*
            int y, z;
            Console.WriteLine("Qual o valor inicial de i?");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor final de i?");
            z = int.Parse(Console.ReadLine());
            if(z < y)
            {
                Console.WriteLine("Por favor, o final deve ser maior que o inicio: ");
            }
            else
            {
                int contagem = 0, soma = 0;
                for (int i = y + 1; i < z; i++)
                {
                    if (i % 2 == 0)
                    {
                        soma = soma + i;
                    }
                    else
                    {
                        contagem = contagem + 1;
                    }
                }
                Console.WriteLine(contagem);
                Console.WriteLine(soma);
            */


            //loop while exemplo
            /*
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++
            }
            */


            //loop do while
            /*
            int valor = -1;
            do
            {
                Console.WriteLine("Digite um valor:");
                valor++;
            } while (valor < 0);
            */


            //ex: Contar quantos valores pares o usuario digitou, até ele digitar um valor negativo:
            /*
            int valor = 0, controle = 0, contador = 0;
            while (controle == 0)
            {
                Console.WriteLine("Digite um valor (um valor negativo para parar o programa): \n");
                valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0 && valor != 0)
                {
                    contador = contador + 1;
                }
                else if (valor < 0)
                {
                    controle = 1;
                }
            }
            Console.WriteLine("O numero de numeros pares é: " + contador);
            */


            //aula dia 29/09/22
            //VETORES
            //exemplo 1
            /*int i;
            int[] b = new int[5];
            Console.WriteLine("Leitura dos valores");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o valor " + i + ":");
                b[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor indice " + i + " é igual a " + b[i]);

            }
            */


            //exemplo 2
            /*
            double[] notas = new double[50];
            double media;
            int i;

            Console.WriteLine("LEITURA DOS VALORES");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Digite a nota do aluno " + i + ":");
                notas[i] = double.Parse(Console.ReadLine());

            }
            media = 0;
            Console.WriteLine("Calculo da media sendo feito...");
            for (int i = 0; i < 50; i++)
            {
                media = media + notas[i];
            }
            media = media / 50;
            Console.WriteLine("Mostrando a media...");
            Console.WriteLine("A media das notas é de: " + media);
            */


            //exemplo 3
            //achar o maior valor de um vetor
            /*
            int[] lista = new int[10];
            int maior, posicao=0;
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Digite um valor para lista");
                lista[i] = int.Parse(Console.ReadLine());


            }
            maior = lista[0];
            for (int i = 0; i< lista.Length; i++)
            {
                if (lista[i]< maior)
                {
                    maior = lista[i];
                    posicao = i;
                }
            }
            Console.WriteLine("O menor valor da lista é: " + maior + " e ele se encontra na posicao: " + posicao);*/


            //aula 03/10/22
            //MATRIZES
        }   
    }
}