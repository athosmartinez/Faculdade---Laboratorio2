using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int contalinhas = 0;
            int[] Vector = new int[100000];
            do
            {

                int contamais = 0;
                str = Console.ReadLine();

                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        char ch = str[i];
                        if (ch >= 'A' && ch <= 'Z')
                        {
                            contamais++;
                        }
                    }
                    Vector[contalinhas] = contamais;
                    contalinhas++;
                }
            } while (str.ToLower().Equals("fim") == false);
            for (int i = 0; i < contalinhas; i++)
            {
                Console.WriteLine(Vector[i]);
            }
        }
    }
}
