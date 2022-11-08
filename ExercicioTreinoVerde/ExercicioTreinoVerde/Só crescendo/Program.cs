using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayInt[] inteiros = new ArrayInt[50];
        }
        class ArrayInt
        {
            int numeroTeste;
            int numeroTamanho;
        }

        public void Ler(string nTeste, string nTamanho)
        {
            nTeste = Console.ReadLine();
            nTamanho = Console.ReadLine();
            int numeroTeste = Convert.ToInt32(nTeste);
            int numeroTamanho = Convert.ToInt32(nTamanho);
            
            for (int i = 0; i < numeroTeste; i++)
            {
                for (int j = 0; j < numeroTamanho; j++)
                {
                    inteiros[i].numeroTeste = numeroTeste;
                    inteiros[i].numeroTamanho = numeroTamanho;
                }
            }
        }

    }
}