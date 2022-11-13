using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nTestes = int.Parse(Console.ReadLine());
            while (nTestes > 0)
            {
                string linhaA = Console.ReadLine();
                string linhaB = Console.ReadLine();
                string nome = "";
                // Console.WriteLine(a);
                // Console.WriteLine(nTestes);
                for (int i = 0; i < linhaA.Length; i += 2)
                {
                    nome = nome + linhaA[i];
                    if (i + 1 < linhaA.Length)
                    {
                        nome = nome + linhaA[i + 1];
                    }
                    if (i < linhaB.Length)
                    {
                        nome = nome + linhaB[i];
                    }
                    if (i + 1 < linhaB.Length)
                    {
                        nome = nome + linhaB[i + 1];
                    }
                }
                Console.WriteLine(nome);
                nTestes--;
            }
        }
    }
}