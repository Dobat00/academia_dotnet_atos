namespace exercicios_lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1
            /*
            int valor, contador = 0;
            string escolha;
            while (true)
            {
                Console.WriteLine("Digite um valor (inteiro e positivo)\n");
                valor = int.Parse(Console.ReadLine());
                if (valor < 0)
                {
                    Console.WriteLine("por favor, digite um valor valido ");
                    continue;
                }
                else
                {
                    for (int i = 1; i <= valor; i++)
                    {
                        if (i % 2 == 0)
                        {
                            contador++;
                        }
                    }
                    Console.WriteLine("existem " + contador + " numeros pares entre 1 e " + valor);
                    Console.WriteLine("Deseja digitar outro numero? s/n \n");
                    escolha = Console.ReadLine();
                    if (escolha == "s")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
            */



            //exercicio 2 (modificar o exercicio anterior)


            //exercicio 3
            /*
            int valor, divisores = 0;
            while (true)
            {
                Console.WriteLine("Digite um valor (digite 0 para sair do programa)\n");
                valor = int.Parse(Console.ReadLine());
                if (valor == 0)
                {
                    break;
                }
                else
                {
                    for(int i = 1; i <= valor; i++)
                    {
                        if(valor % i == 0)
                        {
                            divisores++;
                        }
                    }
                    if(divisores == 2)
                    {
                        if (valor % 2 == 0)
                        {
                            Console.WriteLine("o numero " + valor + " é primo e par");
                        }
                        else
                        {
                            Console.WriteLine("o numero " + valor + " é primo e impar");

                        }
                    }
                    if(divisores != 2)
                    {
                        if (valor % 2 == 0)
                        {
                            Console.WriteLine("O numero " + valor + " nao é primo e é par");
                        }
                        else
                        {
                            Console.WriteLine("O numero " + valor + " nao é primo e é impar");

                        }
                    }
                    
                }
            }
            */


            //exercicio 4
            /*
            int joao= 0, zeca= 0, branco= 0;
            string resposta;
            while (true)
            {
                Console.WriteLine("Em qual candidato voce deseja votar? (JOAO, ZECA, BRANCO) (Digite FIM para finalizar o programa)");
                resposta = Console.ReadLine();
                resposta = resposta.ToLower();
                if (resposta == "joao")
                {
                    joao = joao + 1;
                }
                else if ( resposta == "zeca")
                {
                    zeca = zeca + 1;
                }
                else if ( resposta == "branco")
                {
                    branco = branco + 1;
                }
                else
                {
                    Console.WriteLine("Votos em JOAO: " + joao +
                        "\nVotos em ZECA: " + zeca +
                        "\nVotos em BRANCO: " + branco);
                    break;

                }
            

                
            }
            */


            //exercicio 5
        }
    }
}