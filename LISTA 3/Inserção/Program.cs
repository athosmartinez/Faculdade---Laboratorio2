using System;

namespace Insercao
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorPrin[] lista = new JogadorPrin[20];

            string word = "";
            int i = 0;

            do
            {
                word = Console.ReadLine();
                if (word.ToUpper().Equals("FIM"))
                    continue;

                JogadorPrin jogador = new JogadorPrin();
                jogador.Ler(word);
                lista[i] = jogador;
                i++;
            } while (!word.ToUpper().Equals("FIM"));

            inserstionSort(lista);

            foreach (JogadorPrin item in lista)
            {
                if (item != null)
                    item.Imprimir();
            }
        }
        public static void inserstionSort(JogadorPrin[] lista)
        {
            for (int i = 1; i < lista.Length; i++)
            {
                if (lista[i] != null)
                {
                    JogadorPrin tmp = lista[i];
                    int j = i - 1;

                    while ((j >= 0) && (lista[j].Id > tmp.Id))
                    {
                        lista[j + 1] = lista[j];
                        j--;
                    }
                    lista[j + 1] = tmp;
                }
            }
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