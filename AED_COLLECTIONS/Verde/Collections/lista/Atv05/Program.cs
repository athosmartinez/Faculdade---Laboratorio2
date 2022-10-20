using System;
using System.Collections;

namespace Lista5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 - Crie um ArrayList e adicione os números no intervalo entre 1 a 100. Calcule a soma dos números usando o comando do while.
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
            for (int i = 1; i <= 100; i++)
            {
                array.Add(i);
            }

            int soma = 0, cont = 0;
            do
            {
                soma += Convert.ToInt32(array[cont]);
                cont++;
            } while (cont < array.Count);

            Console.WriteLine("\nSoma Array: {0}\n", soma);
        }

        public static void SoluctionOfQueuee()
        {
            Queue queue = new Queue();
            for (int i = 1; i <= 100; i++)
            {
                queue.Enqueue(i);
            }

            int soma = 0, cont = 0;
            int length = queue.Count;
            do
            {
                soma += Convert.ToInt32(queue.Dequeue());
                cont++;
            } while (cont < length);

            Console.WriteLine("\nSoma Queue: {0}\n", soma);
        }

        public static void SoluctionOfStack()
        {
            Stack stack = new Stack();
            for (int i = 1; i <= 100; i++)
            {
                stack.Push(i);
            }

            int soma = 0, cont = 0;
            int length = stack.Count;
            do
            {
                soma += Convert.ToInt32(stack.Pop());
                cont++;
            } while (cont < length);

            Console.WriteLine("\nSoma Stack: {0}\n", soma);
        }
    }
}