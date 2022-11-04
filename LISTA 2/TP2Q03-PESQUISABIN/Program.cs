using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            string dados = "", findNome = "";
            JogadorPrin[] jogadores = new JogadorPrin[30];
            // Insere dados
            do
            {
                dados = Console.ReadLine();
                if (dados.ToUpper().Equals("FIM")) continue;
                JogadorPrin jogad = new JogadorPrin();
                jogad.Ler(dados);
                jogadores[contador] = jogad;
                contador++; 
            } while (!dados.ToUpper().Equals("FIM"));
            // Procura Nome
            do
            {
                findNome = Console.ReadLine();
                if (findNome.ToUpper().Equals("FIM")) continue;
                Console.WriteLine(PesquisaBinaria(jogadores, findNome, contador));
            } while (!findNome.ToUpper().Equals("FIM"));
        }
        public static string PesquisaBinaria(JogadorPrin[] jogadores, string nome, int contador)
        {
            int esquerda = 0;
            int direita = contador - 1;
            do
            {
                int meio = (esquerda + direita) / 2;
                if (jogadores[meio].Nome == nome)
                {
                    return "SIM";
                }
                else if (String.Compare(nome, jogadores[meio].Nome) > 0)
                {
                    esquerda = meio + 1;
                }
                else
                {
                    direita = meio - 1;
                }
            } while (esquerda <= direita);
            return "NAO";
        }
    }
    class JogadorPrin
    {
        public string Nome;
        public string Foto;
        public DateTime Nascimento;
        public int Id;
        public int[] Times;
        public JogadorPrin() { }
        public void Ler(string entrada)
        {
            // Divisoes em Array[] - Parte esquerda
            string[] divisaoEsquerda = entrada.Split('[');
            string[] divisaoDireita = divisaoEsquerda[0].Split(',');

            Nome = divisaoDireita[1];
            Foto = divisaoDireita[2];
            Id = Convert.ToInt32(divisaoDireita[5]);

            // Divisoes da data em partes
            string[] Dados = divisaoDireita[3].Split('/');
            Nascimento = new DateTime(Int32.Parse(Dados[2]), Int32.Parse(Dados[1]), Int32.Parse(Dados[0]));
            // Divisoes em Array[] - Parte direita

            string[] timesDig = divisaoEsquerda[1].Substring(0, divisaoEsquerda[1].IndexOf(']')).Split(',');

            int[] times = new int[timesDig.Length];
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = Convert.ToInt32(timesDig[i]);
            }
            Times = times;
        }
        public void Imprimir()
        {
            string data = this.Nascimento.ToString("dd/MM/yyyy");
            string newData = data.Substring(0, 2).TrimStart('0') + data.Substring(2, data.Length - 2);

            int[] t = Times;
            string times = "(";


            for (int i = 0; i < t.Length; i++)
            {
                {
                    times += t[i] + (i == t.Length - 1 ? ")" : ", ");
                }
            }

            Console.WriteLine($"{this.Id} {this.Nome} {newData} {this.Foto} {times}");
        }
    }

}