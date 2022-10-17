namespace exercicio_asteroide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Asteroide> lista_asteroide = new List<Asteroide>();
            Asteroide asteroide1 = new Asteroide(0, 0, 1, 1, 1);
            lista_asteroide.Add(asteroide1);
            Asteroide asteroide2 = new Asteroide();
            asteroide2.Tamanho = 2;
            asteroide2.Posicao_x = 1;
            asteroide2.Posicao_y = 1;
            asteroide2.Velocidade = 2;
            asteroide2.Energia = 2;
            lista_asteroide.Add(asteroide2);


            foreach (Asteroide i in lista_asteroide)
            {
                Console.WriteLine("Asteroide");
                Console.WriteLine(i.Posicao_x + " "+ i.Posicao_y +" "+ i.Tamanho + " "+ i.Velocidade +" "+ i.Energia);            }

        }
    }
}