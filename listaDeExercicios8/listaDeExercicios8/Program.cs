using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace listaDeExercicios8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1 
            /*
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string nome, resposta;
            int poder;

            Console.WriteLine("Qual o nome do seu personagem 1: ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o poder do seu personagem 1: ");
            poder = int.Parse(Console.ReadLine());
            Personagem personagem1 = new Personagem(nome, poder);
            dic.Add(nome, poder);

            Console.WriteLine("Qual o nome do seu personagem 2: ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o poder do seu personagem 2: ");
            poder = int.Parse(Console.ReadLine());
            Personagem personagem2 = new Personagem(nome, poder);
            dic.Add(nome, poder);

            Console.WriteLine("Qual o nome do seu personagem 3: ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o poder do seu personagem 3: ");
            poder = int.Parse(Console.ReadLine());
            Personagem personagem3 = new Personagem(nome, poder);
            dic.Add(nome, poder);

            Console.WriteLine("Deseja saber quem possui o maior poder? s/n");
            resposta = Console.ReadLine();
            if (resposta == "s")
            {
                personagem1.maior_poder(personagem2, personagem3);

            }
            else
            {
                personagem1.exibir_dados();
                personagem2.exibir_dados();
                personagem3.exibir_dados();
            }
            */


            //ex2
            //string nome, tipo;

            //Console.WriteLine("Qual o tipo de animal?");
            //tipo = Console.ReadLine();
            //tipo = tipo.ToLower();
            //if (tipo != "peixe" && tipo != "gato" && tipo != "cachorro")
            //{
            //    Console.WriteLine("Insira um tipo valido!");
            //}
            //Console.WriteLine("QUal o nome do animal?");
            //nome = Console.ReadLine();
            //nome = nome.ToLower();
            //Animal animal1 = new Animal(tipo, nome);

            //Console.WriteLine("Qual o tipo de animal?");
            //tipo = Console.ReadLine();
            //tipo = tipo.ToLower();
            //if (tipo != "peite" && tipo != "gato" && tipo != "cachorro")
            //{
            //    Console.WriteLine("Insira um tipo valido!");
            //}
            //Console.WriteLine("QUal o nome do animal?");
            //nome = Console.ReadLine();
            //nome = nome.ToLower();
            //Animal animal2 = new Animal(tipo, nome);

            //Console.WriteLine("Qual o tipo de animal?");
            //tipo = Console.ReadLine();
            //tipo = tipo.ToLower();
            //if (tipo != "peixe" && tipo != "gato" && tipo != "cachorro")
            //{
            //    Console.WriteLine("Insira um tipo valido!");
            //}
            //Console.WriteLine("QUal o nome do animal?");
            //nome = Console.ReadLine();
            //nome = nome.ToLower();
            //Animal animal3 = new Animal(tipo, nome);


            ////ex3
            //List<Asteroide> lista_asteroide = new List<Asteroide>();
            //Random random = new Random();
            ////Asteroide asteroide1 = new Asteroide(0, 0, 1, 1, 1);
            ////lista_asteroide.Add(asteroide1);
            ////Asteroide asteroide2 = new Asteroide();
            ////asteroide2.Tamanho = 2;
            ////asteroide2.Posicao_x = 1;
            ////asteroide2.Posicao_y = 1;
            ////asteroide2.Velocidade = 2;
            ////asteroide2.Energia = 2;
            ////lista_asteroide.Add(asteroide2);
            //for (int i=0; i<50; i++)
            //{
            //    Asteroide asteroide = new Asteroide();
            //    asteroide.Posicao_x = random.Next(0, 100);
            //    asteroide.Posicao_y = random.Next(0, 100);
            //    asteroide.Tamanho = random.Next(1,10);
            //    asteroide.Velocidade = random.Next(1,5);
            //    asteroide.Energia = random.Next(1,5);
            //    lista_asteroide.Add(asteroide);
            //}


            //foreach (Asteroide i in lista_asteroide)
            //{
            //    Console.WriteLine("Asteroide");
            //    Console.WriteLine(i.Posicao_x + " " + i.Posicao_y + " " + i.Tamanho + " " + i.Velocidade + " " + i.Energia);

            //}


            //ex4
            //Item_cenario item1 = new Item_cenario();
            //string resposta1;
            //double resposta2;

            //Console.WriteLine("Qual a descricao do item?\n");
            //resposta1 = Console.ReadLine();
            //item1.Descricao = resposta1;

            //Console.WriteLine("gerando a data de criacao do item...");
            //item1.Gerar_data();

            //Console.WriteLine("Qual a altura do item?");
            //resposta2 = double.Parse(Console.ReadLine());
            //item1.Altura = resposta2;

            //Console.WriteLine("____________________________");
            //item1.Mostrar_informacao();
            //item1.Mostrar_tempo_criado();


            //ex5
            //Random random = new Random();

            //List<Objetos> lista_objetos = new List<Objetos>();
            //int resposta1;
            //Console.WriteLine("Quantos objetos voce deseja cadastrar na lista?\n");
            //resposta1 = int.Parse(Console.ReadLine());
            //for (int i = 0; i < resposta1; i++)
            //{

            //    Objetos objeto = new Objetos(random.Next(1, 100), random.Next(1, 100));
            //    lista_objetos.Add(objeto);
            //}
            //foreach (Objetos i in lista_objetos)
            //{
            //    Console.WriteLine("__________");
            //    i.ExibirInformacao();
            //}


            //ex6
            List<Funcionario> lisa_funcionario = new List<Funcionario>();
            int resposta;
            while (true)
            {
                Console.WriteLine("1-Cadastrar funcionario\n2-Consultar a lista de funcionarios\n3-Aumentar o salario\n4-Demitir funcionario\n5-SAIR");
                resposta = int.Parse(Console.ReadLine());
                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("Qual o nome do funcionario");
                        
                        break;
                }
                
            }
        }
    }
}