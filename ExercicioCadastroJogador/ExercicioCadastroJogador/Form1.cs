namespace ExercicioCadastroJogador
{
    public partial class Form1 : Form
    {
        List<Jogador> listaJogador = new List<Jogador>();
        public Form1()
        {
            InitializeComponent();
            popularListaJogador(listaJogador, "C:\\Users\\Dobat\\source\\repos\\ExercicioCadastroJogador\\jogador.csv");
        }

        private void button_enviar_Click(object sender, EventArgs e)
        {
            string[] dados;
            string nome;
            nome = textBox_nomeDoJogador.Text.ToUpper();


            if(existeNome(listaJogador,nome) == true)
            {
                MessageBox.Show("Esse nome ja existe");
            }
            else
            {
                textBox_listaJogadores.AppendText(nome + Environment.NewLine);
                Jogador jogador = new Jogador(nome, criarEmail(nome));
                textBox_listaEmail.AppendText(criarEmail(nome) + Environment.NewLine);
                listaJogador.Add(jogador);
                gravarJogadorArquivo(jogador, "C:\\Users\\Dobat\\source\\repos\\ExercicioCadastroJogador\\jogador.csv");
                //foreach(Jogador jogador1 in listaJogador)
                //{
                //    MessageBox.Show(jogador1.Nome);
                //}
            }
            textBox_nomeDoJogador.Clear();

        }

        private bool existeNome(List<Jogador> lista,string nome)
        {
            bool existe = false;
            foreach (Jogador jogador in lista)
            {
                if(jogador.Nome == nome)
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
            }
            return existe;
        }

        private string criarEmail(string nome) { 
            string []dados;
            string email;
            dados = nome.Split(" ");
            email = dados[0] + "." + dados[1] + "@ufn.edu.br";
            return email;
        }

        private void gravarJogadorArquivo(Jogador jogador, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true); //abre o arquivo para escrita
            escritor.WriteLine(jogador.Nome + ";" + jogador.Email);
            escritor.Flush();
            escritor.Close();
        }

        private void popularListaJogador(List<Jogador> listaJogador, string NomeArquivo)
        {
            string linha;
            string[] dados;
            StreamReader leitor = new StreamReader(NomeArquivo);
            while (!leitor.EndOfStream)
            {
                linha = leitor.ReadLine();
                dados = linha.Split(";");
                Jogador jogador = new Jogador(dados[0], dados[1]);
                listaJogador.Add(jogador);
            }
            leitor.Close();
        }
    }
}