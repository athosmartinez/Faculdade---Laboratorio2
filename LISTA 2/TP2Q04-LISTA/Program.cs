using System;

namespace MyApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            string dados = "";

            // Insere dados
            do
            {
                dados = Console.ReadLine();
                if (dados.ToUpper().Equals("FIM")) continue;
                JogadorPrin jogador = new JogadorPrin();
                jogador.Ler(dados);
                lista.InserirFim(jogador);
            } while (!dados.ToUpper().Equals("FIM"));

            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                string data = Console.ReadLine();
                JogadorPrin jogad = new JogadorPrin();

                if (data.Substring(0, 2) == "II")
                {
                    jogad.Ler(data.Substring(3));
                    lista.InserirInicio(jogad);
                }
                else if (data.Substring(0, 2) == "IF")
                {
                    jogad.Ler(data.Substring(3));
                    lista.InserirFim(jogad);
                }
                else if (data.Substring(0, 2) == "I*")
                {
                    jogad.Ler(data.Substring(3));
                    lista.Inserir(jogad, int.Parse(data.Substring(3).Substring(0, 2).Replace(" ", "")));
                }
                else if (data.Substring(0, 2) == "RI")
                {
                    lista.RemoverInicio();
                }
                else if (data.Substring(0, 2) == "RF")
                {
                    lista.RemoverFim();
                }
                else if (data.Substring(0, 2) == "R*")
                {
                    lista.Remover(int.Parse(data.Substring(3).Replace(" ", "")));
                }
            }

            for (int i = 0; i < lista.Contador; i++)
            {
                lista.Jogadores[i].Imprimir();
            }
        }
    }

    public class Lista
    {
        public JogadorPrin[] Jogadores;
        public int Contador;

        public Lista()
        {
            Jogadores = new JogadorPrin[20];
            Contador = 0;
        }

        public void InserirInicio(JogadorPrin jogador)
        {
            if (Contador >= Jogadores.Length)
                throw new Exception("Erro");

            for (int i = Contador; i > 0; i--)
                Jogadores[i] = Jogadores[i - 1];

            Jogadores[0] = jogador;
            Contador++;
        }

        public void InserirFim(JogadorPrin jogador)
        {
            if (Contador >= Jogadores.Length)
                throw new Exception("Erro");

            Jogadores[Contador] = jogador;
            Contador++;
        }

        public void Inserir(JogadorPrin jogador, int pos)
        {
            if (Contador >= Jogadores.Length || pos < 0 || pos > Contador)
                throw new Exception("Erro");

            for (int i = Contador; i > pos; i--)
                Jogadores[i] = Jogadores[i - 1];

            Jogadores[pos] = jogador;
            Contador++;
        }

        public JogadorPrin RemoverInicio()
        {
            if (Contador <= 0)
                throw new Exception("Erro");

            JogadorPrin resp = Jogadores[0];
            Contador--;

            for (int i = 0; i < Contador; i++)
                Jogadores[i] = Jogadores[i + 1];

            return resp;
        }

        public JogadorPrin RemoverFim()
        {
            if (Contador <= 0)
                throw new Exception("Erro");

            return Jogadores[Contador--];
        }

        public JogadorPrin Remover(int pos)
        {
            if (Contador <= 0 || pos < 0 || pos >= Contador)
                throw new Exception("Erro");

            JogadorPrin resp = Jogadores[pos];
            Contador--;

            for (int i = pos; i < Contador; i++)
                Jogadores[i] = Jogadores[i + 1];

            return resp;
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
            // Divisoes em Array[] - Parte esquerda
            string[] divisaoEsquerda = entrada.Split('[');
            string[] divisaoDireita = divisaoEsquerda[0].Split(',');

            Nome = divisaoDireita[1];
            Foto = divisaoDireita[2];
            Id = int.Parse(divisaoDireita[5]);

            // Divisoes da data em partes
            string[] Dados = divisaoDireita[3].Split('/');
            Nascimento = new DateTime(Int32.Parse(Dados[2]), Int32.Parse(Dados[1]), Int32.Parse(Dados[0]));
            // Divisoes em Array[] - Parte direita

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
