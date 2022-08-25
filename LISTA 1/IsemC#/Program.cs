using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var consonates = new HashSet<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            var vogais = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'  };
            string frase1, frase2;
            int num1, num2;
            frase1 =  Console.ReadLine();
            for(int i = 0; i < frase1.Length; i++)
            {
                if (vogais.Contains(frase1[i]))
                {
                    Console.Write("SIM");
                }
            }

            frase2 = Console.ReadLine();
            for(int i = 0; i < frase2.Length; i++)
            {
                if (consonates.Contains(frase2[i]))
                {
                    Console.Write("SIM");
                }
            }

        }
    }
}