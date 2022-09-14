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
                    Console.WriteLine(epolindromo(linha, 0, linha.Length - 1));
            }
        }

        public static string epolindromo(string frase, int esquerda, int direita)
        {
            
        
            if (esquerda>= direita){
                return "SIM";
            }
            
            if (frase[esquerda] == frase[direita])
            {
                
                return epolindromo(frase, esquerda+1, direita-1);
                
            }
            else
            {
                return "NAO";
            }
            
        }
    }
}
