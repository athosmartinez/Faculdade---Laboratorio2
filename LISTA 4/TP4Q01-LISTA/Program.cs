using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            InsereElementosIniciais(lista);

            int qtdElementos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qtdElementos; i++)
            {
                string info = Console.ReadLine();
                JogadorPrin jogador = new JogadorPrin();

                switch (info.Substring(0, 2))
                {
                    case "II":
                        jogador.Ler(info.Substring(3));
                        lista.InserirInicio(jogador);
                        break;

                    case "IF":
                        jogador.Ler(info.Substring(3));
                        lista.InserirFim(jogador);
                        break;

                    case "I*":
                        string elemento = info.Substring(3);
                        jogador.Ler(elemento);
                        int pos = Convert.ToInt32(elemento.Substring(0, 2).Replace(" ", ""));
                        lista.Inserir(jogador, pos);
                        break;

                    case "RI":
                        lista.RemoverInicio();
                        break;

                    case "RF":
                        lista.RemoverFim();
                        break;

                    default:
                        lista.Remover(Convert.ToInt32(info.Substring(3).Replace(" ", "")));
                        break;
                }
            }
            lista.Print();
        }

        public static void InsereElementosIniciais(Lista lista)
        {
            string word = "";
            do
            {
                word = Console.ReadLine();
                if (word.ToUpper().Equals("FIM"))
                    continue;

                JogadorPrin jogador = new JogadorPrin();
                jogador.Ler(word);

                lista.InserirFim(jogador);
            } while (!word.ToUpper().Equals("FIM"));
        }
    }
}
public class Celula
{
    public JogadorPrin elemento;
    public Celula prox;
    public Celula() { }

    public Celula(JogadorPrin x)
    {
        this.elemento = x;
        this.prox = null;
    }
}

public class Lista
{
    public Celula primeiro;
    public Celula ultimo;

    public Lista()
    {
        this.primeiro = new Celula();
        this.ultimo = this.primeiro;
    }

    public void InserirInicio(JogadorPrin jogador)
    {
        Celula tmp = new Celula(jogador);
        tmp.prox = this.primeiro.prox;
        this.primeiro.prox = tmp;
        if (this.primeiro == this.ultimo)
        {
            this.ultimo = tmp;
        }
        tmp = null;
    }

    public void InserirFim(JogadorPrin jogador)
    {
        this.ultimo.prox = new Celula(jogador);
        this.ultimo = this.ultimo.prox;
    }

    public void Inserir(JogadorPrin jogador, int pos)
    {
        int length = Length();

        if (pos < 0 || pos > length)
            throw new Exception("Posição invalida!");

        if (pos == 0)
        {
            InserirInicio(jogador);
        }
        else if (pos == length)
        {
            InserirFim(jogador);
        }
        else
        {
            Celula i = this.primeiro;
            for (int j = 0; j < pos; j++, i = i.prox) ;

            Celula tmp = new Celula(jogador);
            tmp.prox = i.prox;
            i.prox = tmp;
            i = null;
            tmp = null;
        }
    }

    public JogadorPrin RemoverInicio()
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

    public JogadorPrin RemoverFim()
    {
        if (primeiro == ultimo)
            throw new Exception("Lista Vazia");

        Celula i;
        for (i = this.primeiro; i.prox != this.ultimo; i = i.prox) ;

        JogadorPrin resp = this.ultimo.elemento;
        this.ultimo = i;
        this.ultimo.prox = null;
        i = null;

        return resp;
    }

    public JogadorPrin Remover(int pos)
    {
        JogadorPrin resp;
        int length = Length();

        if (primeiro == ultimo)
            throw new Exception("Lista Vazia");

        if (pos < 0 || pos >= length)
            throw new Exception("Posição invalida!");

        if (pos == 0)
        {
            resp = RemoverInicio();
        }
        else if (pos == length - 1)
        {
            resp = RemoverFim();
        }
        else
        {
            Celula i = this.primeiro;
            for (int j = 0; j < pos; j++, i = i.prox) ;

            Celula tmp = i.prox;
            resp = tmp.elemento;
            i.prox = tmp.prox;
            tmp.prox = null;
            tmp = null;
            i = null;
        }

        return resp;
    }

    public int Length()
    {
        int length = 0;
        for (Celula i = this.primeiro; i != this.ultimo; i = i.prox, length++) ;
        return length;
    }

    public void Print()
    {
        for (Celula i = this.primeiro.prox; i != null; i = i.prox)
        {
            i.elemento.Imprimir();
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


