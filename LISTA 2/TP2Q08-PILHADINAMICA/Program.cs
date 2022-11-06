using System;
using System.Collections;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilha = new Stack(20);

            string dados = "";

            // Insere dados
            do
            {
                dados = Console.ReadLine();
                if (dados.ToUpper().Equals("FIM")) continue;
                JogadorPrin jogad = new JogadorPrin();
                jogad.Ler(dados);
                pilha.Push(jogad);
            } while (!dados.ToUpper().Equals("FIM"));

            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                string data = Console.ReadLine();
                JogadorPrin jogador = new JogadorPrin();

                if (data[0] == 'I')
                {
                    jogador.Ler(data.Substring(2));
                    pilha.Push(jogador);
                }
                else if (data[0] == 'R')
                {
                    pilha.Pop();
                }
            }

            Stack novaPilha = new Stack(pilha.ToArray());
            foreach (JogadorPrin np in novaPilha)
            {
                np.Imprimir();
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
