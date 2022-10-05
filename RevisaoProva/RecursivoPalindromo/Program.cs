using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            while (frase != "FIM")
            {
                frase = Console.ReadLine();
                if (frase != "FIM")
                {
                    Console.WriteLine(epalindromo(frase));
                }
            }
        }
        public static string epalindromo(string frase)
        {
            //using recursion check if the string is a palindrome
            if (frase.Length <= 1)
            {
                return "SIM";
            }
            else if (frase[0] != frase[frase.Length - 1])
            {
                return "NAO";
            }
            else
            {
                return epalindromo(frase.Substring(1, frase.Length - 2));
            }
        }
    }
}