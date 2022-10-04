using System.Runtime.InteropServices;
using System.Xml;

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
            int joao= 0, zeca= 0, branco= 0, nulo = 0;
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
                else if (resposta == "fim")
                {
                    Console.WriteLine("Votos em JOAO: " + joao +
                        "\nVotos em ZECA: " + zeca +
                        "\nVotos em BRANCO: " + branco);
                    if (joao > zeca)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("o vencedor foi Joao" +
                            "\nVotos nulos: " + nulo+
                            "\nTotal de votos: " + joao + zeca + nulo + branco);
                    }
                    else if (zeca > joao)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("o vencedor foi Zeca" +
                            "\nVotos nulos: " + nulo +
                            "\nTotal de votos: " + joao + zeca + nulo + branco);
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dos dois candidatos venceram");
                    }
                    break;

                }
                else
                {
                    nulo = nulo + 1;
                }
            }
            */


            //exercicio 5 (modificar o exercicio anterior)


            //exercicio 6
            /*
            int idade;
            while (true)
            {
                Console.WriteLine("Qual a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade > 0)
                {
                    Console.WriteLine("A sua idade é: " + idade);
                    break;
                }
                else
                {
                    continue;
                }
            }
            */


            //exercicio 7
            /*
            string nome, numeros = "0123456789";
            float salario;
            int idade;
            while (true)
            {
                Console.WriteLine("Qual o seu nome?\n");
                nome = Console.ReadLine();
                if (nome == " " || nome == "")
                {
                    Console.WriteLine("Por favor, digite um nome valido");
                    break;
                }
                else
                {
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        if (nome.Contains(numeros[i]))
                        {
                            Console.WriteLine("Nome invalido.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Digite sua idade: ");
                            idade = int.Parse(Console.ReadLine());
                            if (idade <= 0)
                            {
                                Console.WriteLine("Digite uma idade valida");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Digite o seu salario: ");
                                salario = float.Parse(Console.ReadLine());
                                if (salario <= 0)
                                {
                                    Console.WriteLine("Valor invalido");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Salario: " + salario +
                                        "\nNome: " + nome +
                                        "\nIdade: " + idade);
                                    break;
                                }
                            }
                        }
                    }

                }
            }
            */


            //exercicio 8
            /*
            bool controle = true;
            int valor;
            string resposta;
            while (controle)
            {
                Console.WriteLine("Digite um numero inteiro:\n");
                valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0)
                {
                    Console.WriteLine("É um numero par");
                }
                else
                {
                    Console.WriteLine("É um numero impar");
                }
                Console.WriteLine("Deseja repetir o programa? s/n");
                resposta = Console.ReadLine();
                resposta = resposta.ToLower();
                if (resposta == "s")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            */


            //ex 9
            /*
            int g1=0, g2=0, g3=0, sem_filhos = 0 , filhos;
            for (int i = 0; i <30; i++)
            {
                Console.WriteLine("Quantos filhos voce tem?");
                filhos = int.Parse(Console.ReadLine());
                if (filhos >= 1 && filhos <= 3)
                {
                    g1++;
                }
                else if(filhos >= 4 && filhos <= 7)
                {
                    g2++;
                }
                else if(filhos >=8)
                {
                    g3++;
                }
                else
                {
                    sem_filhos++;
                }
                Console.WriteLine("Pessoas entre 1 e 3 filhos: " + g1 +
                    "\nPessoas entre 4 e 7 filhos: " + g2 +
                    "\nPessoas com mais de 8 filhos:" + g3 +
                    "\nPessoas sem filhos: " + sem_filhos);
            }
            */


            //ex 10
            /*
            string nome, resposta;
            int homem=0, mulher=0, menos_30=0, mais_60=0, media_idade_mulheres=0,idade;
            for (int i = 0; i< 50; i++)
            {
                Console.WriteLine("Qual o seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Qual o seu sexo? m/f: ");
                resposta = Console.ReadLine();
                resposta = resposta.ToLower();
                if(resposta == "m")
                {
                    homem++;
                }
                else
                {
                    mulher++;
                }
                Console.WriteLine("Qual a sua idade?: ");
                idade = int.Parse(Console.ReadLine());

                if(idade <= 30)
                {
                    menos_30++;
                }
                else if(idade >= 60)
                {
                    mais_60++;
                }
            }
            */


            //ex11
            /*
            bool check = true;
            int nota, alto=0, baixo=0, soma=0,total_alunos=0,media;
            while (check)
            { 
                Console.WriteLine("Digite a nota do aluno (digite -1 para sair): ");
                nota = int.Parse(Console.ReadLine());
                total_alunos++; 
                soma = soma + nota;
                if(nota == -1)
                {
                    break;
                }
                else if (nota > alto)
                {
                    alto = nota;
                }
                else if (nota < baixo)
                {
                    baixo = nota;
                }
            }
            media = soma / total_alunos;
            Console.Write("A nota mais alta foi: " + alto+
                "\nA nota mais baixa foi: " + baixo+
                "\nA media geral foi de: "+media);
            */


            //ex12
            /*
            int soma=0;
            for (int i = 0; i <= 100; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine("A soma dos 100 primeiros numeros é de: " + soma);
            */


            //ex13
            /*
            int soma = 0;
            for (int i = 0; i <= 500; i++)
            {
                if (i % 2 ==0)
                {
                    soma = soma + i;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("A soma dos numeros pares, de 1 a 500 é de: " + soma);
            */


            //ex 14
            /*
            double resultado;
            for(int i = 0; i<= 10;i++)
            {
                resultado = Math.Pow(2, i);
                Console.WriteLine("A potencia de 2 elevado a " + i + " é de: " + resultado);
            }
            */


            //ex 15
            /*
            double nota1=0, nota2=0, nota3=0, nota4=0, media=0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Qual a nota do aluno? :");
                Console.WriteLine(i);
                if (i == 0)
                {
                    nota1 = double.Parse(Console.ReadLine());
                }
                else if (i == 1)
                {
                    nota2 = double.Parse(Console.ReadLine());
                }
                else if (i == 2)
                {
                    nota3 = double.Parse(Console.ReadLine());
                }
                else if (i == 3)
                {
                    nota4 = double.Parse(Console.ReadLine());
                }

            }
            media = ((nota1 * 2) + (nota2 * 1) + (nota3 * 2) + (nota4 * 4) / 9);
            Console.WriteLine("A media do aluno foi de: " + media);
            if (media >= 7)
            {
                Console.WriteLine("O aluno passou!")
            }
            else
            {
                Console.WriteLine("O aluno NAO passou");
            }
            */


            //ex 16
            /*
            int resultado = 0, valor= 0, i = 0;
            Console.WriteLine("Digite um valor inteiro (ate 50)\n");
            valor = int.Parse(Console.ReadLine());
            if(valor > 50)
            {
                Console.WriteLine("Valor invalido!");
            }
            else
            {
                while(resultado< 250)
                { 
                    resultado = valor + (valor * (3 * i));
                    if (resultado <= 250)
                    {
                        Console.WriteLine("O resultado esta em: " + resultado);
                        i++;
                    }
                    else if (resultado >= 250)
                    {
                        Console.WriteLine("O resultado final é de: " + resultado);
                        i++;
                    }
                    
                    
                }
            }
            */


            //ex17
            /*
            int resultado;
            for (int i = 15; i< 200; i++)
            {
                resultado = i * i;
                Console.WriteLine("O quadrado de " + i + " é: " + resultado);
            }
            */


            //ex18
            /*
            Random rnd = new Random();
            double bas = rnd.Next(1, 1000), exp= rnd.Next(1,1000), resultado;
            resultado = Math.Pow(bas, exp);
            Console.WriteLine("Base: " + bas +
                "\nExpoente: " + exp +
                "\nPotencia: " + resultado);
            */


            //ex19
            /*
            bool check = true;
            double salario_total = 0, salario, media_salario = 0, media_filhos=0, maior_salario = 0;
            int filhos_total=0, filhos, populacao = 0,menos_100=0;
            while (check)
            {
                Console.WriteLine("Qual o seu salario?(Digite um valor negativo para finalizar o programa): ");
                salario = double.Parse(Console.ReadLine());
                if (salario > 0)
                {
                    salario_total = salario_total + salario;
                    populacao++;
                    if(salario > maior_salario)
                    {
                        maior_salario = salario;
                    }
                    if(salario <= 100)
                    {
                        menos_100++;
                    }
                }
                else if (salario < 0)
                {
                    break;
                }
         
                Console.WriteLine("Quantos filhos voce tem?");
                filhos = int.Parse(Console.ReadLine());
                filhos_total = filhos + filhos_total;
                populacao++;

            }
            media_filhos = filhos_total / populacao;
            media_salario = salario_total / populacao;
            menos_100 = populacao * (menos_100 / 100);
            Console.WriteLine("Media de filhos: " + media_filhos +
                "\nMedia salarial: " + media_salario +
                "\nMaior salario: " + maior_salario +
                "\n% da populacao que recebe menos que 100 reais: " + menos_100);
            */


            //ex20
            
            bool check = true;
            string sexo,olhos, cabelo;
            int idade, homem=0, mulher=0, loiro=0, castanho=0, preto=0, olho_azul=0, olho_verde=0, olho_castanho=0, maior_idade = 0, pessoas=0;

            while (check)
            {
                Console.WriteLine("Qual o seu sexo?(m: masculino/f: feminino) ");
                sexo = Console.ReadLine();
                sexo = sexo.ToLower();
                if (sexo == "m")
                {
                    homem++;
                }
                else
                {
                    mulher++;
                }
                Console.WriteLine("Qual a cor dos seus olhos?(a:azuis / v: verdes / c:castanhos) ");
                olhos = Console.ReadLine();
                olhos = olhos.ToLower();
                if(olhos == "a")
                {
                    olho_azul++;
                }
                else if(olhos == "v")
                {
                    olho_verde++;
                }
                else
                {
                    olho_castanho++;
                }
                Console.WriteLine("Qual a cor dos seus cabelos? (l: louro/ c:castanho/ p:preto)");
                cabelo = Console.ReadLine();
                cabelo = cabelo.ToLower();
                if (cabelo == "l")
                {
                    loiro++;
                }
                else if (cabelo == "c")
                {
                    castanho++;
                }
                else
                {
                    preto++;
                }
                Console.WriteLine("Qual a sua idade?(digite 0 para sair)");
                idade = int.Parse(Console.ReadLine());
                if (idade > 18 && idade < 35)
                {
                    if (olhos == "v" && cabelo == "l")
                    {
                        pessoas++;
                    }
                }
                else if (idade == 0)
                {
                    break;
                }
                else if(idade > maior_idade)
                {
                    maior_idade = idade;
                }
                Console.WriteLine("Processando...");

            }
            Console.WriteLine("A maior idade dos habitantes: " + maior_idade +
                "\nPessoas com cabelo loiro e olhos verdes, entre 18 e 35 anos de idade: " + pessoas);
        }
    }
}
                    