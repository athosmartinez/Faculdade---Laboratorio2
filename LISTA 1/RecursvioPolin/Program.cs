using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linha = "";
            do
            {
                linha = Console.ReadLine();
            } while (linha != "FIM");
            System.Console.WriteLine(épolindromo(linha, 0, linha.Length - 1));
        }

        public static string épolindromo(string frase, int esquerda, int direita)
        {
            Boolean resposta = true;
            while (esquerda < direita)
            {
                if (frase[esquerda] == frase[direita])
                {
                    épolindromo(frase, esquerda + 1, direita - 1);
                    resposta = true;
                }
                else
                {
                    resposta = false;
                    esquerda = direita;
                }
            }
            return resposta ? "SIM" : "NAO";
        }
    }
}
