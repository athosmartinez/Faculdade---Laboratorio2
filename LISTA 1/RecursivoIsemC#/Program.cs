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
                    System.Console.WriteLine(
                        vogal(palavra, 0)
                            + " "
                            + éconsoante(palavra, 0)
                            + " "
                            + énumerointeiro(palavra, 0)
                            + " "
                            + énumeroreal(palavra, 0)
                    );
                }
            }
        }

        public static string vogal(string palavra, int i)
        {
            Boolean resposta = false;
            while (i < palavra.Length)
            {
                if (
                    palavra[i] == 'B'
                    || palavra[i] == 'C'
                    || palavra[i] == 'D'
                    || palavra[i] == 'F'
                    || palavra[i] == 'G'
                    || palavra[i] == 'H'
                    || palavra[i] == 'J'
                    || palavra[i] == 'K'
                    || palavra[i] == 'L'
                    || palavra[i] == 'M'
                    || palavra[i] == 'N'
                    || palavra[i] == 'P'
                    || palavra[i] == 'Q'
                    || palavra[i] == 'R'
                    || palavra[i] == 'S'
                    || palavra[i] == 'T'
                    || palavra[i] == 'V'
                    || palavra[i] == 'W'
                    || palavra[i] == 'X'
                    || palavra[i] == 'Y'
                    || palavra[i] == 'Z'
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
                    vogal(palavra, ++i);
                    resposta = false;
                }
                else
                {
                    resposta = true;
                    i = palavra.Length;
                }
            }
            return resposta ? "SIM" : "NAO";
        }

        public static string éconsoante(string palavra, int i)
        {
            bool resposta = false;
            while (i < palavra.Length)
            {
                if (
                    palavra[i] == 'A'
                    || palavra[i] == 'E'
                    || palavra[i] == 'I'
                    || palavra[i] == 'O'
                    || palavra[i] == 'U'
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
                    éconsoante(palavra, ++i);
                    resposta = false;
                }
                else
                {
                    resposta = true;
                    i = palavra.Length;
                }
            }
            return resposta ? "SIM" : "NAO";
        }

        public static string énumerointeiro(string palavra, int i)
        {
            Boolean resposta = false;
            while (i < palavra.Length)
            {
                if (palavra[i] <= '0' || palavra[i] <= '9')
                {
                    énumerointeiro(palavra, ++i);
                    resposta = true;
                }
                else
                {
                    resposta = false;
                    i = palavra.Length;
                }
            }
            return resposta ? "SIM" : "NAO";
        }

        public static string énumeroreal(string palavra, int i)
        {
            Boolean resposta = false;
            int contador = 0;
            while (i < palavra.Length)
                if (palavra[i] >= '0' || palavra[i] <= '9')
                {
                    énumeroreal(palavra, ++i);
                    resposta = true;
                }
                else if ((palavra[i] == ',') || (palavra[i] == '.') && contador == 0)
                {
                    énumeroreal(palavra, ++i);
                    contador++;
                }
                else
                {
                    resposta = false;
                    i = palavra.Length;
                }
            return resposta ? "SIM" : "NAO";
        }
    }
}
