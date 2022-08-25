using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase, print = "";
            do{
            Random gerador = new Random(4);
            char aleatorio0 = (char)('a' + (Math.Abs(gerador.Next()) % 26));
            char aleatorio1 = (char)('a' + (Math.Abs(gerador.Next()) % 26));
            frase = Console.ReadLine();
            for(int i = 0; i < frase.Length; i++)
            {
                if(frase[i] == ' ')
                {
                    print += " ";
                }
                else if(frase[i] == aleatorio0)
                {
                    print += aleatorio1;
                }
                else if(frase[i] == aleatorio1)
                {
                    print += aleatorio0;
                }
                else
                {
                    print += frase[i];
                }
            }
            Console.WriteLine(print);
            print = "";
            }while(frase != "FIM");
        }
    }
}