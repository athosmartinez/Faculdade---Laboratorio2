using System;

namespace MergeSort
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

            mergeSort(lista, 0, i-1);

            foreach (JogadorPrin item in lista)
            {
                if (item != null)
                    item.Imprimir();
            }
        }

        public static void mergeSort(JogadorPrin[] lista, int esq, int dir)
        {
            if (esq < dir)
            {
                int meio = esq + (dir - esq) / 2;
                mergeSort(lista, esq, meio);
                mergeSort(lista, meio + 1, dir);
                intercalar(lista, esq, meio, dir);
            }
        }

        public static void intercalar(JogadorPrin[] lista, int esq, int meio, int dir)
        {
            int nEsq = meio - esq + 1;
            int nDir = dir - meio;

            JogadorPrin[] arrayEsq = new JogadorPrin[nEsq];
            JogadorPrin[] arrayDir = new JogadorPrin[nDir];
            int i, j;

            for (i = 0; i < nEsq; ++i)
                arrayEsq[i] = lista[esq + i];

            for (j = 0; j < nDir; ++j)
                arrayDir[j] = lista[meio + 1 + j];

            i = 0;
            j = 0;
            int k = esq;

            while (i < nEsq && j < nDir)
            {
                if (arrayEsq[i].Nascimento <= arrayDir[j].Nascimento)
                {
                    lista[k++] = arrayEsq[i++];
                }
                else
                {
                    lista[k++] = arrayDir[j++];
                }
            }

            while (i < nEsq)
            {
                lista[k++] = arrayEsq[i++];
            }

            while (j < nDir)
            {
                lista[k++] = arrayDir[j++];
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
