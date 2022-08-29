using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(int[] args)
        {
            int X,
                Y;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
        
        }
        public static int mdc(int x, int y)
        {
            if (x % y == 0)
            {
                return y;
            }
            else
            {
                return mdc(y, x % y);
            }
        }
    }
}
