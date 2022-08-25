using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra,
                encriptada = "";
            do
            {
                palavra = Console.ReadLine();
                if (palavra.ToUpper().Equals("FIM"))
                    continue;
                for (int i = -0; i < palavra.Length; i++)
                {
                    int ASCII = (int)palavra[i];

                    int ASCII_encriptado = ASCII + 3;

                    encriptada += (char)ASCII_encriptado;
                }
                Console.WriteLine(encriptada);
                encriptada = "";
            } while (palavra != "FIM");
        }
    }
}
