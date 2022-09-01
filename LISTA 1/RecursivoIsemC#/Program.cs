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
                    Console.WriteLine(
                        vogal(palavra, 0)
                            + " "
                            + econsoante(palavra, 0)
                            + " "
                            + inteiros(palavra)
                            + " "
                            + reais(palavra)
                    );
                }
            }
        }

        public static string vogal(string palavra, int i)
        {
            if (i > palavra.Length - 1)
            {
                return "SIM";
            }

            if (
                palavra[i] != 'A'
                && palavra[i] != 'E'
                && palavra[i] != 'I'
                && palavra[i] != 'O'
                && palavra[i] != 'U'
                && palavra[i] != 'a'
                && palavra[i] != 'e'
                && palavra[i] != 'i'
                && palavra[i] != 'o'
                && palavra[i] != 'u'
            )
            {
                return "NAO";
            }
            return vogal(palavra, i + 1);
        }

        public static string econsoante(string palavra, int i)
        {
            if (i > palavra.Length - 1)
            {
                return "SIM";
            }
            if (
                palavra[i] == 'A'
                || palavra[i] == 'E'
                || palavra[i] == 'I'
                || palavra[i] == 'O'
                || palavra[i] == 'U'
                || palavra[i] == 'a'
                || palavra[i] == 'e'
                || palavra[i] == 'i'
                || palavra[i] == 'o'
                || palavra[i] == 'u'
                || palavra[i] == '1'
                || palavra[i] == '2'
                || palavra[i] == '3'
                || palavra[i] == '4'
                || palavra[i] == '5'
                || palavra[i] == '6'
                || palavra[i] == '7'
                || palavra[i] == '8'
                || palavra[i] == '9'
                || palavra[i] == '0'
            )
            {
                return "NAO";
            }
            return econsoante(palavra, i + 1);
        }

        static string inteiros(string palavra)
        {
            int numero;
            return int.TryParse(palavra, out numero) ? "SIM" : "NAO";
        }

        static string reais(string palavra)
        {
            string frase1_ = palavra.Replace(",", ".");
            float numero;
            return float.TryParse(frase1_, out numero) ? "SIM" : "NAO";
        }
    }
}
