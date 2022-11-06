using System;

namespace MyApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            string dados = "";

            // Insere dados
            do
            {
                dados = Console.ReadLine();
                if (dados.ToUpper().Equals("FIM")) continue;
                JogadorPrin jogador = new JogadorPrin();
                jogador.Ler(dados);
                fila.Inserir(jogador);
            } while (!dados.ToUpper().Equals("FIM"));

            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                string data = Console.ReadLine();
                JogadorPrin jogad = new JogadorPrin();

                if (data[0] == 'I')
                {
                    jogad.Ler(data.Substring(2));
                    fila.Inserir(jogad);
                }
                else if (data[0] == 'R')
                {
                    fila.Remover();
                }
            }

            int contador = fila.Esquerda;
            while (contador != fila.Direita)
            {
                fila.Jogadores[contador].Imprimir();
                contador = (contador + 1) % fila.Jogadores.Length;
            }
        }
    }

    public class Fila
    {
        public JogadorPrin[] Jogadores;
        public int Esquerda;
        public int Direita;

        public Fila()
        {
            Jogadores = new JogadorPrin[10];
            Esquerda = 0;
            Direita = 0;
        }

        public void Inserir(JogadorPrin jogador)
        {
            if (((Direita + 1) % Jogadores.Length) == Esquerda)
                throw new Exception("Erro");

            Jogadores[Direita] = jogador;
            Direita = (Direita + 1) % Jogadores.Length;
        }

        public JogadorPrin Remover()
        {
            if (Esquerda == Direita)
                throw new Exception("Erro");

            JogadorPrin value = Jogadores[Esquerda];
            Esquerda = (Esquerda + 1) % Jogadores.Length;
            return value;
        }
    }

    public class JogadorPrin
    {
        public string Nome;
        public string Foto;
        public DateTime Nascimento;
        public int Id;
        public int[] Times;
        public JogadorPrin() { }
        public void Ler(string entrada)
        {
            // Divisoes em Array[] - Parte Esquerda
            string[] divisaoEsquerda = entrada.Split('[');
            string[] divisaoDireita = divisaoEsquerda[0].Split(',');

            Nome = divisaoDireita[1];
            Foto = divisaoDireita[2];
            Id = int.Parse(divisaoDireita[5]);

            // Divisoes da data em partes
            string[] Dados = divisaoDireita[3].Split('/');
            Nascimento = new DateTime(Int32.Parse(Dados[2]), Int32.Parse(Dados[1]), Int32.Parse(Dados[0]));
            // Divisoes em Array[] - Parte Direita

            string[] timesDig = divisaoEsquerda[1].Substring(0, divisaoEsquerda[1].IndexOf(']')).Split(',');

            int[] times = new int[timesDig.Length];
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = int.Parse(timesDig[i]);
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
