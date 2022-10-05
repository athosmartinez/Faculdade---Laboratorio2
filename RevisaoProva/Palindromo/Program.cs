using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            do
            {
                palavra = Console.ReadLine();
                if (palavra == "FIM") continue;
                // check if phrase is a palindrome
                bool isPalindrome = true;
                for (int i = 0; i < palavra.Length / 2; i++)
                {
                    if (palavra[i] != palavra[palavra.Length - i - 1])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                Console.WriteLine(isPalindrome ? "SIM" : "NAO");
                


            } while (palavra != "FIM");
        }
    }
}