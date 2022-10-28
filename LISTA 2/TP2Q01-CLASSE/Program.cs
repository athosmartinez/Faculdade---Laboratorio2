using System;

namespace MyApp // Note: actual namespace depends on the project name.
{


    class Jogadores
    {
        public string Nome;
        public string Foto;
        public DateTime Nascimento;
        public int Id;
        public int[] Times;

        public Jogadores()
        {
            this.Times = new int[30];
        }

        public void Ler(string entrada)
        {
            // Divisoes em Array[] - Parte esquerda

            string divisaoEsquerda = entrada.Split("[")[0];
            string divisaoDireita = entrada.Split("[")[1];
            string[] dividido = divisaoEsquerda.Split(",");

            this.Nome = dividido[1];
            this.Foto = dividido[2];
            this.Id = Int32.Parse(dividido[5]);
            // Divisoes da data em partes 
            string[] Dados = dividido[4].Split("/");
            this.Nascimento = (new DateTime(Int32.Parse(Dados[2]), Int32.Parse(Dados[1]), Int32.Parse(Dados[0])));

            // this.Nascimento = DateTime.Parse(dividido[3]);

            // Divisoes em Array[] - Parte direita

            string[] dividido2 = divisaoDireita.Substring(0, divisaoDireita.IndexOf("]")).Split(",");
            for (int i = 0; i < dividido2.Length; i++)
            {
                this.Times[i] = Int32.Parse(dividido2[i]);
            }
        }

        public void Imprimir()
        {
            string saida = "";
            for (int i = 0; i < 30; i++)
            {
                if (Times[i] != 0)
                {
                    saida += this.Times[i];
                }
            }
            Console.WriteLine($"{this.Id} {this.Nome} {this.Nascimento} {this.Foto} ({saida})");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = "";
            do
            {
                palavra = Console.ReadLine();
                if (palavra == "FIM")
                    continue;
                Jogadores jogador = new Jogadores();
                jogador.Ler(palavra);
                jogador.Imprimir();

            } while (palavra != "FIM");
        }
    }
}