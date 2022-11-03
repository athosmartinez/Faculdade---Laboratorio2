using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorPrin[] jogadores = new JogadorPrin[30];
            int contador = Preencher(jogadores);
            string palavra = "";
            do
            {
                palavra = Console.ReadLine();
               
                Console.WriteLine(PesquisaSenque(jogadores, palavra, contador));
            } while (palavra != "FIM");
        }
        public static int Preencher(JogadorPrin[] jogadores)
        {
            string palavra = "";
            int contador = 0;
            do
            {
                palavra = Console.ReadLine();
                if (palavra.ToUpper().Equals("FIM"))
                    continue;
                JogadorPrin jogad = new JogadorPrin();
                jogad.Ler(palavra);
                jogadores[contador] = jogad;
                contador++;
            } while (!palavra.ToUpper().Equals("FIM"));
            return contador;
        }

        public static string PesquisaSenque(JogadorPrin[] jogadores, string palavra, int contador)
        {
            for (int i = 0; i < contador; i++)
            {
                if (jogadores[i].GetNome() == palavra)
                {
                    return "SIM";
                }
            }
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
        public JogadorPrin()
        {

        }
        public int GetId()
        {
            return Id;
        }
        public void SetId(int Id)
        {
            this.Id = Id;
        }
        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }
        public string GetNome()
        {
            return Nome;
        }
        public string GetFoto()
        {
            return Foto;
        }
        public void SetFoto(string Foto)
        {
            this.Foto = Foto;
        }
        public DateTime GetNascimento()
        {
            return Nascimento;
        }
        public void SetNascimento(DateTime Nascimento)
        {
            this.Nascimento = Nascimento;
        }
        public int[] GetTimes()
        {
            return Times;
        }
        public void SetTimes(int[] Times)
        {
            this.Times = Times;
        }

        public void Ler(string entrada)
        {
            // Divisoes em Array[]
            string[] divisaoEsquerda = entrada.Split("[");
            string[] divisaoDireita = divisaoEsquerda[0].Split(",");

            SetNome(divisaoDireita[1]);
            SetFoto(divisaoDireita[2]);
            SetId(Convert.ToInt32(divisaoDireita[5]));

            // Divisão da data em partes 

            string[] Dados = divisaoDireita[3].Split("/");
            SetNascimento(new DateTime(Int32.Parse(Dados[2]), Int32.Parse(Dados[1]), Int32.Parse(Dados[0])));

            // Separação dos times

            string[] timesDig = divisaoEsquerda[1].Substring(0, divisaoEsquerda[1].IndexOf("]")).Split(",");

            int[] times = new int[timesDig.Length];
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = Convert.ToInt32(timesDig[i]);
            }
            SetTimes(times);
        }
        public void Imprimir()
        {
            string data = this.Nascimento.ToString("dd/MM/yyyy");
            string newData = data.Substring(0, 2).TrimStart('0') + data.Substring(2, data.Length - 2);

            int[] t = GetTimes();
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