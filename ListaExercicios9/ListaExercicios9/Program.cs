namespace ListaExercicios9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            List<Pessoa>listaDePessoas = new List<Pessoa>();
            int resposta;
            string nome, email;
            string[] subs;
            try
            {
                while (true)
                {
                    Console.WriteLine("1-Cadastrar nova pessoa\n2-Consultar a lista de pessoas\n3-SAIR");
                    resposta = int.Parse(Console.ReadLine());
                    switch (resposta)
                    {
                        case 1:
                            Console.WriteLine("Qual o nome COMPLETO da pessoa?");
                            nome = Console.ReadLine();
                            subs = nome.Split(" ");
                            if (subs.Length > 1)
                            {
                                Console.WriteLine("Qual o email?");
                                email = Console.ReadLine();
                                //foreach (Pessoa pessoa in listaDePessoas)
                                //{
                                //    if (pessoa.Email == email)
                                //    {
                                //        Console.WriteLine("Email ja registrado!");
                                //    }
                                //    else
                                //    {
                                        Console.WriteLine("Email valido.");
                                        nome = nome.ToLower();
                                        email = email.ToLower();
                                        Pessoa pessoa1 = new Pessoa(nome, email);
                                        listaDePessoas.Add(pessoa1);
                                        Util.GravarPessoaNoArquivo(pessoa1, @"C:\Users\Dobat\source\repos\ListaExercicios9\pessoas.csv");
                                        Console.WriteLine("Pessoa registrada com sucesso!");
                                //    }
                                //}
                            }
                            else
                            {
                                Console.WriteLine("Nome invalido, o nome precisa ser COMPLETO"); 
                            }
                            break;
                        case 2:
                            Console.WriteLine("aisjdioajsd");
                            break;
                        case 3:
                            Console.WriteLine("Saindo...");
                            return;
                        default:
                            break;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}