using System;
using System.Collections;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Crie um ArrayList e adicione 10 valores inteiros digitados pelo usuário. Ao final, imprima todos os elementos.
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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o {0}° valor inteiro: ", i + 1);
                array.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Write("\nArrayList: [ ");
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(String.Join("\n", array[i]));
            }
            Console.WriteLine(" ]\n");
        }

        public static void SoluctionOfQueuee()
        {
            Queue queue = new Queue();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o {0}° valor inteiro: ", i + 1);
                queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
            }

            int cont = 0;
            Console.Write("\nQueue: [");
            foreach (object obj in queue)
            {
                Console.Write("{0}", cont == 0 ? obj : ", " + obj);
                cont++;
            }
            Console.WriteLine("]\n");
        }

        public static void SoluctionOfStack()
        {
            Stack stack = new stackack();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o {0}° valor inteiro: ", i + 1);
                stack.Push(Convert.ToInt32(Console.ReadLine()));
            }

            int cont = 0;
            Console.Write("\nstack: [");
            foreach (object obj in stack)
            {
                Console.Write("{0}", cont == 0 ? obj : ", " + obj);
                cont++;
            }
            Console.WriteLine("]\n");
        }
    }
}