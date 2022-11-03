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

        public DateTime GetNascimento()
        {
            return Nascimento;
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


            string[] Dados = dividido[3].Split("/");
            this.Nascimento = (new DateTime(Int32.Parse(Dados[2]), Int32.Parse(Dados[1]), Int32.Parse(Dados[0])));

            // Divisoes em Array[] - Parte direita

            string[] dividido2 = divisaoDireita.Substring(0, divisaoDireita.IndexOf("]")).Split(",");
            for (int i = 0; i < dividido2.Length; i++)
            {
                this.Times[i] = Convert.ToInt32(dividido2[i]);
            }
        }
        public void Imprimir()
        {
            string data = this.Nascimento.ToString("dd/MM/yyyy");
            string newData = data.Substring(0, 2).TrimStart('0') + data.Substring(2, data.Length - 2);
            string saida = "";
           

            for (int i = 0; i < Times.Length; i++)
            {
                if (this.Times[i] != 0)
                {
                    saida += (i == 0 ? "" : ", ") + this.Times[i];
                }
            }

            Console.WriteLine($"{this.Id} {this.Nome} {newData} {this.Foto} ({saida})");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = "";
            int contador = Preencher(Jogadores);
            do
            {
                palavra = Console.ReadLine();
                if (palavra == "FIM")
                    continue;
                Jogadores jogador = new Jogadores();
                jogador.Ler(palavra);
                jogador.Imprimir();
                Console.WriteLine(PesquisaSequen(Jogadores, palavra, contador));

            } while (palavra != "FIM");
        }
    }
}