using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linha = "";
            while (linha != "FIM")
            {
                linha = Console.ReadLine();
                if (linha != "FIM")
                    System.Console.WriteLine(épolindromo(linha, 0, linha.Length - 1));
            }
        }

        public static string épolindromo(string frase, int esquerda, int direita)
        {
            Boolean resposta = true;
            while (esquerda < direita)
            {
                if (frase[esquerda] == frase[direita])
                {
                    épolindromo(frase, esquerda++, --direita);
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
