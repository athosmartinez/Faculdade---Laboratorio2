using System;
using System.Collections;

namespace Lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6 - Crie um ArrayList e adicione os números pares no intervalo entre 1 a 100. Calcule a soma dos números usando o comando foreach.
            int op = 0;

            do
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Array");
                Console.WriteLine("2 - Queuee");
                Console.WriteLine("3 - Stack");
                Console.WriteLine("4 - Sair");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1: SoluctionOfArray(); break;
                    case 2: SoluctionOfQueuee(); break;
                    case 3: SoluctionOfStack(); break;
                    case 4: continue;

                    default:
                        Console.WriteLine("Sem está opção.\n");
                        break;
                }
            } while (op != 4);
        }

        public static void SoluctionOfArray()
        {
            ArrayList array = new ArrayList();
            for (int i = 2; i <= 100; i += 2)
            {
                array.Add(i);
            }

            int soma = 0;
            foreach (int item in array)
            {
                soma += item;
            }

            Console.WriteLine("\nSoma Array: {0}\n", soma);
        }

        public static void SoluctionOfQueuee()
        {
            Queue queue = new Queue();
            for (int i = 2; i <= 100; i += 2)
            {
                queue.Enqueue(i);
            }

            int soma = 0;
            foreach (object item in queue)
            {
                soma += Convert.ToInt32(item);
            }

            Console.WriteLine("\nSoma Queue: {0}\n", soma);
        }

        public static void SoluctionOfStack()
        {
            Stack stack = new Stack();
            for (int i = 2; i <= 100; i += 2)
            {
                stack.Push(i);
            }

            int soma = 0;
            foreach (object item in stack)
            {
                soma += Convert.ToInt32(item);
            }

            Console.WriteLine("\nSoma Stack: {0}\n", soma);
        }
    }
}