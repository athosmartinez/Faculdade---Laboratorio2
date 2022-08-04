using System;

namespace ex5 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;
            Console.WriteLine("Entre com queeeeee número deseja calcular o fatorial: ");
            int num = int.Parse(Console.ReadLine());
            if(num == 0)
            {
                Console.WriteLine("Fatorial de 0 de 1");
            }
            else
            {
                for(int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("Factorial de {0} é {1}", num, factorial);
            }
        }
    }
}