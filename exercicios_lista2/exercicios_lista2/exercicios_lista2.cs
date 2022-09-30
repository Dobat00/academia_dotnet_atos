using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace exercicios_lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 1
            /*
            int lado1, lado2, lado3;
            Console.WriteLine("Digite o valor do base\n");
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado 2\n");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado 3\n");
            lado3 = int.Parse(Console.ReadLine());
            
            if(lado1 != 0 && lado2 != 0 && lado3 != 0)
            {
                if (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado3 + lado1 > lado2)
                {
                    lado1 = ((lado1 * lado2)/2);
                    Console.WriteLine("A area do triangulo é de: " + lado1);
                }
            }
            else
            {
                Console.WriteLine("Digite um numero diferente de zero!");
            }
            */


            //EXERCICIO 2
            /*
            int valor;
            Console.WriteLine("Digite um valor");
            valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("é um numero par");
            }
            else
            {
                Console.WriteLine("é um numero impar");
            }
            */


            //EXERCICIO 3
            /*
            int valor1, valor2, valor3, valor4;
            float media;

            Console.WriteLine("Digite o valor 1:\n");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2:\n");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 3:\n");
            valor3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 4:\n");
            valor4 = int.Parse(Console.ReadLine());

            media = (valor1 + valor2 + valor3 + valor4) / 4;
            Console.WriteLine("A media dos valores é de: " + media);

            if (valor1 > media)
            {
                Console.WriteLine(valor1 + " é maior que a media");
            }
            if (valor2> media)
            {
                Console.WriteLine(valor2 + " é maior que a media");
            }
            if (valor3 > media)
            {
                Console.WriteLine(valor3 + " é maior que a media");
            }
            if (valor4 > media)
            {
                Console.WriteLine(valor4 + " é maior que a media");
            }
            */


            //EXERCICIO 4
            /*
            float salario1, tempo1, salario2, tempo2;


            Console.WriteLine("Qual o seu salario por hora? (professor 1):\n");
            salario1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas voce trabalhou? (professor 1):\n");
            tempo1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Qual o seu salario por hora? (professor 2):\n");
            salario2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas voce trabalhou? (professor 2):\n");
            tempo2 = float.Parse(Console.ReadLine());

            salario1 = tempo1 * salario1;
            salario2 = tempo2 * salario2;

            if (salario1> salario2)
            {
                Console.WriteLine("O professor 1 esta com o salario maior");
            }
            else if (salario1 == salario2)
            {
                Console.WriteLine("Ambos estao com o mesmo salario");
            }
            else
            {
                Console.Write("O professor 2 esta com o salario maior");
            }
            */


            //EXERCICICO 5
            /*
            float nota1, nota2, exame;
            Console.WriteLine("Digite a primeira nota: \n");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota; \n");
            nota2 = float.Parse(Console.ReadLine());

            if ((nota1 + nota2) / 2 > 7.0) 
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("Digite a nota do exame: \n");
                exame = float.Parse(Console.ReadLine());    
                if ((exame + ((nota1 + nota2)/2)) /2 >= 5)
                {
                    Console.WriteLine("APROVADO!");
                }
                else
                {
                    Console.WriteLine("REPROVADO!");
                }
            */


            //EXERCICIO 6
            /*
            string nome;
            float altura, peso, imc;
            Console.WriteLine("Qual o seu nome?: \n");
            nome = Console.ReadLine();
            nome = nome.ToUpper();
            Console.WriteLine("Qual o seu peso?: \n");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura?: \n");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc > 18 && imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc > 25 && imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc > 30 && imc < 35)
            {
                Console.WriteLine("Obesidade");
            }
            else
            {
                Console.WriteLine("Obesidade de grau serio");
            }
            */


            //EXERCICICO 7
            /*
            String frase = "";
            String palavra = "";
            Console.WriteLine("Digite uma frase: \n");
            frase = Console.ReadLine();
            Console.WriteLine("Digite uma palavra: \n");
            palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("Essa palavra existe na frase:");
            }
            else
            {
                Console.WriteLine("Essa palavra nao existe na frase");
            }
            */


            //EXERCICIO 8
            /*
            string nome;
            int codigo, vendas;
            float salario;
            Console.WriteLine("Qual o seu codigo:\n");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu nome:\n");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o total de vendas?:\n");
            vendas = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu salario?:\n");
            salario = float.Parse(Console.ReadLine());

            if (vendas > 500)
            {
                salario = ((vendas * 5) / 100) + salario;
                Console.WriteLine("O seu salario final sera: " + salario);
            }
            else if (vendas > 1000)
            {
                salario = ((vendas * 7) / 100) + salario;
                Console.WriteLine("O seu salario final sera: " + salario);
            }
            else if (vendas > 5000)
            {
                salario = ((vendas * 10) / 100) + salario;
                Console.WriteLine("O seu salario final sera: " + salario);
            }
            */


            //EXERCICIO 9
            /*
            float valor1, valor2, valor3;
            Console.WriteLine("Digite o valor 1\n");
            valor1 = float.Parse(Console.ReadLine());
            if (valor1 < 65)
            {
                Console.WriteLine("risco de hipoglicemia");
            }
            else if (valor1 > 250)
            {
                Console.WriteLine("risco de hiperglicemia");
            }


            Console.WriteLine("Digite o valor 2\n");
            valor2 = float.Parse(Console.ReadLine());
            if (valor2 < 65)
            {
                Console.WriteLine("risco de hipoglicemia");
            }
            else if (valor2 > 250)
            {
                Console.WriteLine("risco de hiperglicemia");
            }


            Console.WriteLine("Digite o valor 3\n");
            valor3= float.Parse(Console.ReadLine());
            if (valor3 < 65)
            {
                Console.WriteLine("risco de hipoglicemia");
            }
            else if (valor3 > 250)
            {
                Console.WriteLine("risco de hiperglicemia");
            }
            */


            //Exercicio 10 
            /*
            string nome1, nome2;
            int idade1, idade2;
            float altura1, altura2;
            Console.WriteLine("Qual o nome do atleta 1?\n");
            nome1 = Console.ReadLine();
            Console.WriteLine("Qual o nome do atleta 2?\n");
            nome2 = Console.ReadLine();

            Console.WriteLine("Qual a altura do atleta 1\n");
            altura1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a altura do atleta 2\n");
            altura2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a idade do atleta 1\n");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a idade do atleta 2\n");
            idade2 = int.Parse(Console.ReadLine());

            if (idade1< idade2 && altura1 > altura2)
            {
                Console.WriteLine(nome1 + "\n" + altura1 + "\n" + idade1);
            }
            else if(idade2 < idade1 && altura2 > altura1)
            {
                Console.WriteLine(nome2 + "\n" + altura2 + "\n" + idade2);
            }
            */


            //exercicio 11
            /*
            int horas, minutos;
            Console.WriteLine("Que horas sao? : \n");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos minutos sao?: \n");
            minutos = int.Parse(Console.ReadLine());

            if (horas > 0 || horas < 24)
            {
                if (minutos > 0 || minutos < 60)
                {
                    Console.WriteLine("horas validas");
                }
                else
                {
                    Console.WriteLine("horas invalidas");
                }
            }
            else
            {
                Console.WriteLine("horas invalidas");
            }
            */


            //exercicio 12
            /*
            int codigo;
            float horas, extra, salario;
            Console.WriteLine("Qual o seu codigo?\n");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas voce trabalhou?\n");
            horas = float.Parse(Console.ReadLine());

            if (horas > 50)
            {
                salario = 50 * 10;
                horas = horas - 50;
                extra = horas * 20;
                Console.WriteLine("O seu salario ficara: " + salario +
                    "\nO seu extra ira ser de: " + extra);

            }
            else
            {
                extra = 0;
                salario = horas * 10;
                Console.WriteLine("O seu salario sera de: " + salario +
                    "\nO seu extra sera de: " + extra);
            }
            */


            //exercicio 13
            /*
            double altura, peso_mulher, peso_homem;
            Console.WriteLine("Qual a sua altura? (metros) : ");
            altura = float.Parse(Console.ReadLine());

            peso_mulher = (62.1 * altura) - 44.7;
            peso_homem = (72.7 * altura) - 58;

            Console.WriteLine("O seu peso ideal, caso voce seja:" +
                "\nHOMEM: "+peso_homem+
                "\nMULHER: "+peso_mulher);
            */


            //exercicio 14
            /*
            double arquivo, velocidade,tempo_de_download;
            Console.WriteLine("Qual o tamanho do seu arquivo (em MB): ");
            arquivo = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a velocidade da sua internet (em Mb/s): ");
            velocidade = double.Parse(Console.ReadLine());

            tempo_de_download = arquivo / velocidade;
            tempo_de_download = tempo_de_download / 60;
            Console.WriteLine("O seu arquivo levara: " + tempo_de_download + " minutos");
            */


            //exercicio 15
            /*
            double tamanho, quantidade_tinta;
            Console.WriteLine("Qual o tamanho em metros quadrados que voce vai pintar?: ");
            tamanho = double.Parse(Console.ReadLine());
            quantidade_tinta = tamanho / 3;
            if (quantidade_tinta < 18)
            {
                Console.WriteLine("voce vai precisar de 1 lata de tinta" +
                    "\npreco: 80 reais");
            }
            else
            {
                quantidade_tinta = quantidade_tinta / 18;
                Console.WriteLine("Voce vai precisar de "+ quantidade_tinta +
                    "\npreco: " + quantidade_tinta * 80);

                
            }
            */


            //exercicio 16
            /*
            int time1 = 0, time2 = 0;
            Console.WriteLine("Quantos gols marcou o time da casa?:\n");
            time1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos gols marcou o time de fora?\n");
            time2 = int.Parse(Console.ReadLine());

            if(time2 - time1 >= 2)
            {
                Console.WriteLine("O time de fora se classificou!");
            }
            else
            {
                Console.WriteLine("Os times irao se enfretar em um novo jogo");
            }
            */


            //exercicio 17
            /*
            int lado1, lado2, lado3;
            Console.WriteLine("Qual o valor do lado do triangulo: \n");
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do lado do triangulo: \n");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do lado do triangulo: \n");
            lado3 = int.Parse(Console.ReadLine());

            if (lado1 <= lado2 + lado3 && lado2 <= lado3 + lado1 && lado3 <= lado2 + lado1)
            {
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("É um triangulo equilatero.");
                }
                else if (lado1 != lado2 && lado1 != lado3)
                {
                    Console.WriteLine("É um triangulo escaleno.");
                }
                else
                {
                    Console.WriteLine("É um triangulo isoceles");
                }

            }
            else
            {
                Console.WriteLine("nao é possivel formar um triangulo!");
            }
            */


            //ex 18 
            /*
            int a, b, c, maior = 0, menor=0 , meio= 0 ;
            Console.WriteLine("Digite um valor");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor");
            c = int.Parse(Console.ReadLine());

            if (a >b && a > c)
            {
                maior = a;
                if (b > c)
                {
                    meio = b;
                    menor = c;
                }
                else
                {
                    meio = c;
                    menor = b;
                }
            }
            else if (b > c && b > a)
            {
                maior = b;
                if (a > c)
                {
                    meio = a;
                    menor = c;

                }
                else
                {
                    meio = c;
                    menor = a;
                }
            }
            else
            {
                maior = c;
                if (a > b)
                {
                    meio = a;
                    menor = b;
                }
                else
                {
                    meio = b;
                    menor = a;
                }
            }
            Console.WriteLine("o maior numero é: " + maior);
            Console.WriteLine("A ordem crescente é: " + menor + " " + meio + " " + maior);
            */
   
            

            //ex 19 (modificar o ex 18)


            //ex 20
            /*
            Random random = new Random();
            int numero = 0, vidas = 3, tentativa;
            numero = random.Next(0, 10);
            Console.WriteLine("Tente adivinhar o numero!");
            tentativa = int.Parse(Console.ReadLine());
            if (tentativa > numero)
            {
                Console.WriteLine("MENOS");
            }
            else if (tentativa < numero)
            {
                Console.WriteLine("MAIS");
            }
            else if (tentativa == numero)
            {
                Console.WriteLine("ACERTOU!");
            }
            */
        }  
    }
}