using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase1;
            do
            {
                string retorno1,
                    retorno2,
                    retorno3,
                    retorno4;
                frase1 = Console.ReadLine().ToUpper();
                if (frase1.ToUpper().Equals("FIM"))
                    continue;

                retorno1 = vogais(frase1);
                retorno2 = consoantes(frase1);
                retorno3 = inteiros(frase1);
                retorno4 = reais(frase1);
                 Console.WriteLine("{0} {1} {3} {4}", retorno1, retorno2, retorno3, retorno4);
            } while (!frase1.ToUpper().Equals("FIM"));
        }

        static string vogais(string frase1)
        {
            for (int i = 0; i < frase1.Length; i++)
            {
                if (
                    frase1[i] == 'B'
                    || frase1[i] == 'C'
                    || frase1[i] == 'D'
                    || frase1[i] == 'F'
                    || frase1[i] == 'G'
                    || frase1[i] == 'H'
                    || frase1[i] == 'J'
                    || frase1[i] == 'K'
                    || frase1[i] == 'L'
                    || frase1[i] == 'M'
                    || frase1[i] == 'N'
                    || frase1[i] == 'P'
                    || frase1[i] == 'Q'
                    || frase1[i] == 'R'
                    || frase1[i] == 'S'
                    || frase1[i] == 'T'
                    || frase1[i] == 'V'
                    || frase1[i] == 'W'
                    || frase1[i] == 'X'
                    || frase1[i] == 'Y'
                    || frase1[i] == 'Z'
                )
                {
                    return "NAO";
                }
            }
            return "SIM";
        }

        static string consoantes(string frase1)
        {
            for (int i = 0; i < frase1.Length; i++)
            {
                if (
                    frase1[i] != 'A'
                    && frase1[i] != 'E'
                    && frase1[i] != 'I'
                    && frase1[i] != 'O'
                    && frase1[i] != 'U'
                )
                {
                    return "SIM";
                }
            }
            return "NAO";
        }

        static string inteiros(string frase1) {  
            for (int i = 0; i < frase1.Length; i++)
            {
                if (
                    frase1[i] == '0'
                    || frase1[i] == '1'
                    || frase1[i] == '2'
                    || frase1[i] == '3'
                    || frase1[i] == '4'
                    || frase1[i] == '5'
                    || frase1[i] == '6'
                    || frase1[i] == '7'
                    || frase1[i] == '8'
                    || frase1[i] == '9'
                )
                {
                    return "SIM";
                }
            }
            return "NAO";
        }

        static string  reais(string frase1) {  
            if (frase1.Contains(",") || frase1.Contains(".")) {
                return "SIM";
            }
            return "NAO";
        }
    }
}
