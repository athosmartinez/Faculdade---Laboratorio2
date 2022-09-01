using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = "";
            while (palavra != "FIM")
            {
                palavra = Console.ReadLine();
                if (palavra != "FIM")
                {
                    System.Console.WriteLine(Ciframento(palavra, 0));
                }
            }
        }

        public static string Ciframento(string palavra, int i)
        {
            string cifrada = "";
            if (i > palavra.Length - 1)
            {
                return cifrada;
            }
            cifrada += ((char)((int)palavra[i] + 3)) + Ciframento(palavra, i + 1);

            return cifrada;
        }
    }
}
