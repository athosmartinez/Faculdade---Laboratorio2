using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = " ";
            while (phrase != "FIM")
            {
                phrase = Console.ReadLine();
                if (phrase != "FIM")
                {
                    Console.WriteLine(vogal(phrase)
                    + " " + consoante(phrase)
                    + " " + numero(phrase)
                    + " " + real(phrase));
                }
            }
        }

        public static string vogal(string phrase)
        {
            //recursive function to check if the phrase has a vowel
            if (phrase.Length == 0)
            {
                return "NAO";
            }
            else if (phrase[0] == 'a' || phrase[0] == 'e' || phrase[0] == 'i' || phrase[0] == 'o' || phrase[0] == 'u')
            {
                return "SIM";
            }
            else
            {
                return vogal(phrase.Substring(1));
            }
        }

        public static string consoante(string phrase)
        {
            //recursive function to check if the phrase has a consonant
            if (phrase.Length == 0)
            {
                return "NAO";
            }
            else if (phrase[0] != 'a' && phrase[0] != 'e' && phrase[0] != 'i' && phrase[0] != 'o' && phrase[0] != 'u')
            {
                return "SIM";
            }
            else
            {
                return consoante(phrase.Substring(1));
            }

        }

        static string numero(string phrase)
        {
            //recursive function to check if the phrase has a number
            int numero;
            return int.TryParse(phrase, out numero) ? "SIM" : "NAO";
        }


        static string real(string phrase)
        {
            //recursive function to check if the phrase has a real number
            double real;
            return double.TryParse(phrase, out real) ? "SIM" : "NAO";


        }
    }

}
