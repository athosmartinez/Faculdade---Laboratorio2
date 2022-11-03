using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Jogadores
    {
        public String nome;
        public DateTime nascimento;
        public String foto;
        public int id;
        public int[] times;


        public Jogadores()
        {
            this.nome = "";
            this.nascimento = new DateTime(1111, 1, 1);
            this.foto = "";
            this.id = 0;
            this.times = new int[] { 000, 000, 000, 000 };
        }

        void ler(String entrada)
        {
            String[] entradadiv = entrada.Split(',');
            String[] datas = entradadiv[3].Split('/');

            this.nome = entradadiv[1];
            this.foto = entradadiv[2];
            this.id = int.Parse(entradadiv[5]);
            this.nascimento = new DateTime(int.Parse(datas[2]), int.Parse(datas[1]), int.Parse(datas[0]));
            this.times = new int[entradadiv.Length - 6];
            for (int i = 6, j = 0; i < entradadiv.Length; i++, j++)
            {
                this.times[j] = int.Parse(entradadiv[i].Replace("[", "").Replace("]", "").Replace("\"", ""));
            }
        }

        void imprimir()
        {
            Console.Write(this.id + " ");
            Console.Write(this.nome + " ");
            Console.Write(this.nascimento.ToString("d/MM/yyyy") + " ");
            Console.Write(this.foto + " ");

            Console.Write("(");
            for (int i = 0; i < this.times.Length; i++)
            {
                Console.Write(this.times[i]);
                if (i < this.times.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(")");
            Console.WriteLine();
        }
        static String pesquisaSequen(Jogadores[] jogadores, String nome, int j)
        {
            Boolean resposta = false;
            int jog = jogadores.Length - j;
            for (int i = 0; i < jog; i++)
            {
                if (jogadores[i].nome == nome)
                {
                    resposta = true;
                    i = jog;
                }
            }
            return resposta ? "SIM" : "NAO";
        }

        static void Main(string[] args)
        {
            int i = 0;
            String entrada = Console.ReadLine();
            Jogadores[] jogador = new Jogadores[30];
            while (entrada != "FIM") ;
            jogador[i] = new Jogadores();
            jogador[i].ler(entrada);
            entrada = Console.ReadLine();
            i++;

            entrada = Console.ReadLine();
            while (entrada != "FIM") ;
            Console.WriteLine(pesquisaSequen(jogador, entrada, i));
            entrada = Console.ReadLine();
        }
    }
}

