using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respostas = int.Parse(Console.ReadLine());

            while (respostas > 0)
            {
                bool respFim;
                string[] pessoasEdiff = Console.ReadLine().Split(' ');
                int pessoas = int.Parse(pessoasEdiff[0]);
                int dif = int.Parse(pessoasEdiff[1]);
                string[] tempAlturas = Console.ReadLine().Split(' ');
                int[] alturas = new int[pessoas * 2];
                for (int i = 0; i < pessoas; i++)
                {
                    alturas[i] = int.Parse(tempAlturas[i]);
                }
                for (int i = 0; i < alturas.Length - 1; i++)
                {
                    if (alturas[(alturas.Length / 2) + i] - alturas[i] >= dif)
                    {
                        respFim = true;
                    }
                    else
                    {
                        respFim = false;
                    }

                    if (i == alturas.Length)
                    {
                        if (respFim == true)
                        {
                            Console.WriteLine("SIM");
                        }
                        else
                        {
                            Console.WriteLine("NAO");
                        }
                    }
                }
                respostas--;
            }
        }
    }
}