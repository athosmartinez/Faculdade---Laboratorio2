using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase, print = "";
            do
            {
                Random generator = new Random(4);
                char random0 = (char)('a' + (Math.Abs(generator.Next()) % 26));
                char random1 = (char)('a' + (Math.Abs(generator.Next()) % 26));
                phrase = Console.ReadLine();
                if (phrase == "FIM") continue;
                for (int i = 0; i < phrase.Length; i++)
                {
                    if (phrase[i] == ' ')
                    {
                        print += " ";
                    }
                    else if(phrase[i] == random0)
                    {
                        print += random1;
                    }
                    else if(phrase[i] == random1)
                    {
                        print += random0;
                    }
                    else
                    {
                        print += phrase[i];
                    }
                }
                Console.WriteLine(print);
                print = "";
            } while (phrase != "FIM");


        }
    }
}