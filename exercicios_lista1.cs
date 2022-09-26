using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace academia_atos_dotnet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXPLICACAO DA AULA
            /*int num; 
            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("positivo!");
            }
            if(num < 0 )
            {
                Console.WriteLine("Negativo!");
            }
            else
            {
                Console.WriteLine("zero");
            */


            //EXERCICIO 1
            /*int a, b;
            Console.WriteLine("Digite um valor para A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para B:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("A média aritmetica entre A e B é de: " + (a + b) / 2);
            */


            //EXERCICICO 2
            /*int a, b, c, d;
            Console.WriteLine("Digite um valor pra A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor pra B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor pra C");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor pra D");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("A media aritmetica dos quatro valores é de: " + (a + b + c + d) / 4);
            */


            //EXERCICIO 3
            /*int a, b, aux;
            a = 1;
            b = 0;
            aux = a;
            Console.WriteLine("o valor de A é: " + a);
            Console.WriteLine("o valor de B é: " + b);
            a = b;
            b = aux;
            Console.WriteLine("o valor de A ficou: " + a);
            Console.WriteLine("o valor de B ficou: " + b);
            */

            //EXERCICIO 4
            /*int dia, mes, ano;
            Console.WriteLine("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mes");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine(dia + "/" + mes + "/" + ano);
            Console.WriteLine(ano + "/" + mes + "/" + dia);
            Console.WriteLine(ano % 100 + "/" + mes + "/" + dia);
            */

            //EXERCICIO 5
            /*int combustivel, distancia, quantidade;
            Console.WriteLine("Qual a distancia percorrida?: ");
            distancia = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos litros foram gastos?: ");
            combustivel = int.Parse(Console.ReadLine());
            quantidade = distancia / combustivel;
            Console.WriteLine("a media de combustivel gasto no seu trajeto foi de: " + quantidade);
            */


            //EXERCICIO 6
            /*int codigo1, codigo2, quantidade1, quantidade2;
            float valor1, valor2, tributo, resultado1, resultado2;
            Console.WriteLine("Qual o codigo do produto A: ");
            codigo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o codigo do produto B:");
            codigo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual a quantidade do produto A:");
            quantidade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade do produto B:");
            quantidade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do produto A:");
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do produto B:");
            valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da tributacao (em %) em cima do produto?");
            tributo = float.Parse(Console.ReadLine());

            resultado1 = (tributo * valor1) / 100;
            resultado1 = (resultado1 + valor1) * quantidade1;
            resultado2 = (tributo * valor2) / 100;
            resultado2 = (resultado2 + valor2) * quantidade2;

            Console.WriteLine("O valor total do produto A ira ficar." + resultado1);
            Console.WriteLine("O valor total do produto B ira ficar." + resultado2);
            */


            //EXERCICIO 7
            /*
            int vendedor, porcentagem;
            float salario, total_vendas;
            Console.WriteLine("Qual o seu numero de vendedor\n");
            vendedor = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu salario\n");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual foi o total em vendas?\n");
            total_vendas = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a porcentagem que voce ganhar em cima das vendas?\n");
            porcentagem = int.Parse(Console.ReadLine());

            total_vendas = salario + ((porcentagem * total_vendas) / 100);
            Console.WriteLine("O total que voce ira receber é de: " + total_vendas);
            */


            //EXERCICIO 8
            /* 
            float temp, temp_final;
            Console.WriteLine("Qual a temperatura em graus celsius? ");
            temp = float.Parse(Console.ReadLine());

            temp_final = (9 * temp + 160) / 5;
            Console.WriteLine("A conversao de temperatura ficara: "+temp_final);
            */


            //EXERCICIO 9
            /*
            float valor, prest1, prest2, entrada;
            Console.WriteLine("Qual o valor do produto?");
            valor = float.Parse(Console.ReadLine());
            prest1 = valor / 3;
            prest2 = valor / 3;
            entrada = valor / 3 + 1;

            Console.WriteLine("O valor de entrada sera: " + entrada + "\nO valor das parcelas sera de: " + prest1);
            */


            //EXERCICIO 10 
            /*
            double saque = 0;

            int nota100 = 0, nota50 = 0, nota20 = 0, nota10 = 0, nota5 = 0, nota2 = 0;

            Console.WriteLine("Qual o valor total? \n");
            saque = double.Parse(Console.ReadLine());

            nota100 = (int)(saque / 100);
            Console.WriteLine("Notas de 100: " + nota100);
            saque = saque - (nota100 * 100);

            nota50 = (int)(saque / 50);
            Console.WriteLine("Notas de 50: " + nota100);
            saque = saque - (nota50 * 50);

            nota20 = (int)(saque / 20);
            Console.WriteLine("Notas de 20: " + nota100);
            saque = saque - (nota20 * 20);

            nota10 = (int)(saque / 10);
            Console.WriteLine("Notas de 10: " + nota100);
            saque = saque - (nota10 * 10);

            nota5 = (int)(saque / 5);
            Console.WriteLine("Notas de 5: " + nota100);
            saque = saque - (nota100 * 5);

            nota2 = (int)(saque / 2);
            Console.WriteLine("Notas de 2: " + nota100);
            saque = saque - (nota2 * 2);
            */



            //EXERCICIO 11
            /*
            int total, brancos, nulos, validos;
            Console.WriteLine("Qual o numero  TOTAL de eleitores?:\n");
            total = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o numero de votos em branco?\n");
            brancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o numero de votos nulos?\n");
            nulos = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o numero de votos validos?\n");
            validos = int.Parse(Console.ReadLine());

            brancos = brancos * 100 / total;
            nulos = nulos * 100 / total;
            validos = validos * 100 / total;

            Console.WriteLine("Total de elitores: " + total +
            "\nVotos em branco: " + brancos + "%" +
            "\nVotos nulos: " + nulos + "%" +
            "\nVotos validos: " + validos + "%");
            */


            //EXERCICICO 12
            /*
            float comb = 6.90f,dist_i, dist_f, comb_gasto, valor_recebido, media_consumo, lucro, dist_total;
            
            Console.WriteLine("Qual a distancia do comeco do dia?: ");
            dist_i = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a distancia no FINAL do dia?:");
            dist_f = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantos litros de combustivel foram gastos?: ");
            comb_gasto = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantos reais no total voce recebeu hoje?:");
            valor_recebido = float.Parse(Console.ReadLine());

            dist_total = dist_f - dist_i;
            media_consumo = dist_total / comb_gasto;
            lucro = valor_recebido - (dist_total * comb);

            Console.WriteLine("A media de consumo de combustivel foi de: " + media_consumo +
               "\nO lucro do dia foi de: " + lucro);
            */


            //EXERCICIO 13
            float salario_minimo, preco_de_custo, bicicletas_vendidas;
            Console.WriteLine("Qual o valor do salario minimo?");
            salario_minimo = float.Parse(Console.ReadLine());
            salario_minimo = salario_minimo * 2;
            Console.WriteLine("Qual o preco de custo de cada bicicleta?");
            preco_de_custo = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantas dessa bicicleta voce vendeu?");
            bicicletas_vendidas = float.Parse(Console.ReadLine());

            preco_de_custo = ((preco_de_custo * 50) / 100) + preco_de_custo;
            preco_de_custo = ((preco_de_custo * 15) / 100);
            salario_minimo = preco_de_custo + salario_minimo;

            Console.WriteLine("Seu salario ficara: " + salario_minimo);

            
        }

    }
}
