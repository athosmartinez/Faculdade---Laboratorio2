using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            string encrypted = "";
            //encrypt the string changing char for 3 char after
            do
            {
                str = Console.ReadLine();
                if (str == "FIM") continue;
                foreach (char c in str)
                {
                    encrypted += (char)(c + 3);
                }
                Console.WriteLine(encrypted);
                encrypted = "";
            } while (str != "FIM");



        }
    }
}