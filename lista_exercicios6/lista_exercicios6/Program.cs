namespace lista_exercicios6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            
            bool check = true;
            List<string> lista = new List<string>();
            string nome;
            string[] dados_nome;
            List<string> sobrenomes = new List<string>();
            while (check)
            {
                Console.WriteLine("Digite um nome e um sobrenome (digite 'sair' para sair do programa)\n");
                nome = Console.ReadLine().ToUpper();
                dados_nome = nome.Split(" ");
                if (lista.Contains(nome))
                {
                    Console.WriteLine("Esse nome ja existe na lista!");
                    continue;
                }
                else if (dados_nome.Length <=1)
                {
                    Console.WriteLine("Digite pelo menos o nome e um sobrenome");
                }
                else if (dados_nome.Length > 1)
                {
                    Console.WriteLine("Nome valido, e adicionado a lista!");
                    lista.Add(nome);
                    sobrenomes.Add(dados_nome[1]);
                }
                
                else if ( nome == "SAIR")
                {
                    lista.Sort();
                    for (int i = 0; i < sobrenomes.Count; i++)
                    {
                        Console.WriteLine(sobrenomes[i]);
                    }
                    Console.WriteLine("\nPessoas da mesma familia:\n");
                    for (int i = 0; i< sobrenomes.Count; i++)
                    {
                        if (nome.Contains(sobrenomes[i]))
                        {
                            Console.WriteLine(nome[i]);
                        }
                    }
                    break;
                }
            }
            


            //ex2
            /*
            List<int> lista = new List<int>();
            Random random = new Random();
            int numero, valor;
            Console.WriteLine("Quantos numeros deseja colocar na lista?");
            valor = int.Parse(Console.ReadLine());
            for(int i = 0; i< valor; i++)
            {
                numero = random.Next(0, 1000);
                lista.Add(numero);

            }
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            */


            //ex3
            /*
            bool check = true;
            int resposta;
            string email;
            string[] dados_emails;
            List<string> dominios = new List<string>();
            List<string> emails = new List<string>();
            while (check)
            {
                Console.WriteLine("1-Cadastrar email\n2-Listar\n3-Sair");
                resposta = int.Parse(Console.ReadLine());
                if (resposta == 1)
                {
                    Console.WriteLine("Qual o email que deseja cadastrar?");
                    email = Console.ReadLine();
                    if (!email.Contains("@"))
                    {
                        Console.WriteLine("Digite um email valido.");
                    }
                    else
                    {
                        dados_emails = email.Split("@");
                        emails.Add(email);
                        dominios.Add(dados_emails[1]);
                    }


                }
                else if(resposta == 2)
                {
                    Console.WriteLine("\nEmails\n");
                    for(int i = 0; i < emails.Count(); i++)
                    {
                        Console.WriteLine(emails[i]);
                    }
                    Console.WriteLine("\nDominios\n");
                    for (int i = 0; i < dominios.Count(); i++)
                    {
                        Console.WriteLine(dominios[i]);
                    }
                }
                else if(resposta == 3)
                {
                    Console.WriteLine("FINALIZANDO");
                    break;
                }
                else
                {
                    Console.WriteLine("valor invalido!!");
                }
            }
            */


            //ex4
            /*
            List<string> moedas = new List<string>();
            bool check = true;
            int resposta;
            string nome_moeda;
            while (check)
            {
                Console.WriteLine("1-Listar criptomoeda\n2-Mostara a lista de criptomoedas\n3-Deletar\n4-Sair");
                resposta = int.Parse(Console.ReadLine());
                if (resposta == 1)
                {
                    Console.WriteLine("Digite o nome da moeda\n");
                    nome_moeda = Console.ReadLine().ToUpper();
                    if (moedas.Contains(nome_moeda))
                    {
                        Console.WriteLine("Nome ja existe na lista! Digite outro.");
                    }
                    else if (nome_moeda.Contains(" "))
                    {
                        Console.WriteLine("Nome da moeda invalido!");
                    }
                    else
                    {
                        moedas.Add(nome_moeda);
                    }
                }
                else if(resposta == 2)
                {
                    for (int i = 0; i < moedas.Count; i++)
                    {
                        Console.WriteLine(moedas[i]);
                    }
                }
                else if(resposta == 3)
                {
                    Console.WriteLine("Qual o nome da moeda que deseja apagar?");
                    nome_moeda = Console.ReadLine();
                    if (moedas.Contains(nome_moeda))
                    {
                        moedas.Remove(nome_moeda);
                        Console.WriteLine("Nome removido com sucesso");
                    }
                }
                else if (resposta == 4)
                {
                    break;
                }
                
            }
            */


            //ex 5
            /*
            Random random = new Random();
            int numero,numero_lista;
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();
            Console.WriteLine("Quantos numeros voce deseja: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                numero_lista = random.Next(100, 200);
                lista1.Add(numero_lista);
            }
            for (int i = 0; i< numero; i++)
            {
                numero_lista = random.Next(100, 200);
                lista2.Add(numero_lista);
            }
            for (int i= 0; i < lista1.Count; i++)
            {
                if (lista1.Contains(lista2[i]))
                {
                    Console.WriteLine(lista2[i]);
                }
            }
            */


            //ex 6
            //MODIFICAR O EX 1
        }
    }
}