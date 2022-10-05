using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string polindromo,reverse;
            do
            {
                polindromo = Console.ReadLine();
                if(polindromo.ToUpper().Equals("FIM")) continue;
                char[] ch = polindromo.ToCharArray();
                Array.Reverse(ch);
                reverse = new string(ch);
                bool b = polindromo.Equals(reverse, StringComparison.CurrentCulture);
                if (b == true)
                {
                    Console.WriteLine("SIM");
                }
                else
                {
                    Console.WriteLine("NAO");
                }
            } while (!polindromo.ToUpper().Equals("FIM"));
        }
    }
}
