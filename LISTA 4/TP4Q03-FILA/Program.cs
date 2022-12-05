using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();

            InsereElementosIniciais(fila);

            int qtdElementos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qtdElementos; i++)
            {
                string info = Console.ReadLine();
                JogadorPrin jogador = new JogadorPrin();

                switch (info[0])
                {
                    case 'I':
                        jogador.Ler(info.Substring(2));
                        fila.Inserir(jogador);
                        break;

                    default:
                        fila.Remover();
                        break;
                }
            }

            fila.Print();
        }

        public static void InsereElementosIniciais(Fila fila)
        {
            string word = "";
            do
            {
                word = Console.ReadLine();
                if (word.ToUpper().Equals("FIM"))
                    continue;

                JogadorPrin jogador = new JogadorPrin();
                jogador.Ler(word);

                fila.Inserir(jogador);
            } while (!word.ToUpper().Equals("FIM"));
        }
    }
}
public class Celula
{
    public JogadorPrin elemento;
    public Celula prox;

    public Celula() { }

    public Celula(JogadorPrin elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }
}

public class Fila
{
    public Celula primeiro;
    public Celula ultimo;

    public Fila()
    {
        this.primeiro = new Celula();
        this.ultimo = this.primeiro;
    }

    public void Inserir(JogadorPrin jogador)
    {
        this.ultimo.prox = new Celula(jogador);
        this.ultimo = this.ultimo.prox;
    }

    public JogadorPrin Remover()
    {
        if (this.primeiro == this.ultimo)
            throw new Exception("Lista Vazia");

        Celula tmp = this.primeiro;
        this.primeiro = this.primeiro.prox;
        JogadorPrin resp = this.primeiro.elemento;
        tmp.prox = null;
        tmp = null;

        return resp;
    }

    public void Print()
    {
        for (Celula i = this.primeiro.prox; i != null; i = i.prox)
            i.elemento.Imprimir();
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


