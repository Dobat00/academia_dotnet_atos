using System.Runtime.CompilerServices;

namespace lista_de_exercicios7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            /*
            string g, qp, n;
            
            Console.WriteLine("Qual o genero do livro?:");
            g = Console.ReadLine();
            Console.WriteLine("Quantas paginas tem o livro?");
            qp = Console.ReadLine();
            Console.WriteLine("Qual o nome do livro?");
            n = Console.ReadLine();
            livro livro = new livro(g, qp, n);
            livro.exibir_dados();
            */


            //ex 2
            /*
            string nome, olhos, cabelos;
            int idade;
            double altura;

            Console.WriteLine("Qual o seu nome?\n");
            nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade?\n");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a cor dos seus olhos?\n");
            olhos = Console.ReadLine();
            Console.WriteLine("Qual a cor dos seus cabelos?\n");
            cabelos = Console.ReadLine();
            Console.WriteLine("Qual a sua altura?\n");
            altura = double.Parse(Console.ReadLine());
            Pessoa pessoa = new Pessoa(nome, idade, olhos, cabelos, altura);

            pessoa.exibir_dados();
            */


            //ex 3
            /*
            Cliente c = new Cliente();
            Console.WriteLine("Qual o nome do cliente?\n");
            c.setnome(Console.ReadLine());
            Console.WriteLine("Qual a idade do cliente?\n");
            c.setidade(int.Parse(Console.ReadLine()));

            Carro carro = new Carro();
            Console.WriteLine("Qual o marca do carro?\n");
            carro.marca = Console.ReadLine();
            Console.WriteLine("Qual o modelo do carro?\n");
            carro.modelo = Console.ReadLine();
            carro.placa = "2040doi10";

            Aluguel aluguel = new Aluguel();
            aluguel.inicio = new DateTime(2022, 10, 10, 14, 0, 0);
            aluguel.termino = new DateTime(2022, 10, 15, 14, 0, 0);
            aluguel.carro = carro;
            aluguel.cliente = c;
            aluguel.exibir_dados();
            */


            //ex 4
            /*
            Familia pessoa_filho = new Familia();
            pessoa_filho.idade = 22;
            pessoa_filho.nome = "Matheus";

            Familia pessoa_mae = new Familia();
            pessoa_mae.idade = 50;
            pessoa_mae.nome = "marcia";

            Familia pessoa_pai = new Familia();
            pessoa_pai.idade = 50;
            pessoa_pai.nome = "milton";

            Familia pessoa_avo_pai = new Familia();
            pessoa_avo_pai.idade = 90;
            pessoa_avo_pai.nome = "antonio";

            pessoa_pai.pai = pessoa_avo_pai;
            pessoa_filho.pai = pessoa_pai;
            pessoa_filho.mae = pessoa_mae;
            */


            //ex 5
            /*
            Produtos produto1 = new Produtos();
            produto1.nome = "arroz";
            produto1.preco = 10;
            produto1.estoque = 500;

            Produtos produto2 = new Produtos();
            produto2.nome = "feijao";
            produto2.preco = 10;
            produto2.estoque = 500;

            Cliente_mercado cliente = new Cliente_mercado();
            cliente.pagamento = "cartao";
            cliente.produtos = "arroz";
            cliente.quantidade = 3;
            cliente.preco_total();
            */


            //ex 7
            /*
            int capacidade, andares, resposta;
            Elevador elevador1 = new Elevador();
            Console.WriteLine("Qual a capacidade de pessoas do elevador?");
            capacidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos andares tem o predio?");
            andares = int.Parse(Console.ReadLine());

            elevador1.inicializa(capacidade, andares);
            while (true)
            {
                Console.WriteLine("1-Entra\n2-Sai\n3-Sobe\n4-Desce\n5-SAIR");
                resposta = int.Parse(Console.ReadLine());
                if (resposta == 1)
                {
                    elevador1.entra();
                }
                else if (resposta == 2)
                {
                    elevador1.sai();
                }
                else if(resposta == 3)
                {
                    elevador1.sobe();

                }
                else if(resposta == 4)
                {
                    elevador1.desce();

                }
                else if(resposta == 5)
                {
                    Console.WriteLine("Finalizando!");
                    break;
                }
            }
            */


            //ex 8 
            int opcao;
            Controle_remoto controle = new Controle_remoto();

            while (true)
            {
                Console.WriteLine("1- aumentar volume\n2-diminuri volume\n3-canal acima\n4-canal abaixo\n5-mostrar canal/volume\n6-DESLIGAR");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    controle.Aumentar_valume();
                }
                else if (opcao == 2)
                {
                    controle.Diminuir_volume();
                }
                else if (opcao == 3)
                {
                    controle.Subir_canal();
                }
                else if (opcao == 4)
                {
                    controle.Diminuir_canal();
                }
                else if(opcao == 5)
                {
                    controle.Exibir_informacoes();
                }
                else if (opcao == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um valor valido!");
                }
                
            }
            


        }
    }
}