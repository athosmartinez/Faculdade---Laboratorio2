using System;
using System.Collections;

namespace Lista12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que preencha um ArrayList com os números entre 1 e 25. Pede-se:
            // ● Imprima todos os elementos
            // ● Imprima todos os elementos em ordem invertida
            // ● Imprima todos os elementos em posições ímpares (os elementos da posição 1, 3, 5, ...)
            // ● Imprima todos os elementos ímpares
            // ● Imprima apenas os elementos da primeira metade do vetor (posição 0 a 12).
            // OBS: você deve fazer esse programa 2 vezes. Primeiro usando o comando FOR e depois usando o comando FOREACH.
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

            for (int i = 1; i <= 25; i++)
            {
                array.Add(i);
            }

            int method = selectForOrForeach();
            int length = array.Count;

            Console.WriteLine("\nArray - {0}\n", method == 1 ? "FOR" : "FOREACH");

            Console.WriteLine("Imprime:");
            Print(array, method, length);

            array.Reverse();

            Console.WriteLine("Imprime Reverse:");
            Print(array, method, length);

            Console.WriteLine("Imprime Posições Ímpares:");
            PrintImpar(array, true, method, length);

            Console.WriteLine("Imprime Elementos Ímpares:");
            PrintImpar(array, false, method, length);

            Console.WriteLine("Imprime a Primeira Metade:");
            PrintHalf(array, length, method);
        }

        public static void SoluctionOfQueuee()
        {
            Queue queue = new Queue();

            for (int i = 1; i <= 25; i++)
            {
                queue.Enqueue(i);
            }

            int method = selectForOrForeach();
            int length = queue.Count;

            Console.WriteLine("\nQueue - {0}\n", method == 1 ? "FOR" : "FOREACH");

            Console.WriteLine("Imprime:");
            Print(queue, method, length);

            ReverseQueue(queue);

            Console.WriteLine("Imprime Reverse:");
            Print(queue, method, length);

            Console.WriteLine("Imprime Posições Ímpares:");
            PrintImpar(queue, true, method, length);

            Console.WriteLine("Imprime Elementos Ímpares:");
            PrintImpar(queue, false, method, length);

            Console.WriteLine("Imprime a Primeira Metade:");
            PrintHalf(queue, length, method);
        }

        public static void SoluctionOfStack()
        {
            Stack stack = new Stack();

            for (int i = 1; i <= 25; i++)
            {
                stack.Push(i);
            }

            int method = selectForOrForeach();
            int length = stack.Count;

            Console.WriteLine("\nStack - {0}\n", method == 1 ? "FOR" : "FOREACH");

            Console.WriteLine("Imprime:");
            Print(stack, method, length);

            ReverseStack(stack);

            Console.WriteLine("Imprime Reverse:");
            Print(stack, method, length);

            Console.WriteLine("Imprime Posições Ímpares:");
            PrintImpar(stack, true, method, length);

            Console.WriteLine("Imprime Elementos Ímpares:");
            PrintImpar(stack, false, method, length);

            Console.WriteLine("Imprime a Primeira Metade:");
            PrintHalf(stack, length, method);
        }

        private static int selectForOrForeach()
        {
            Console.WriteLine("\n|| Selecione uma opção ||");
            Console.WriteLine("|| 1 - Usar For        ||");
            Console.WriteLine("|| 2 - Usar ForEach    ||");
            int resp = Convert.ToInt32(Console.ReadLine());

            if (resp != 1 && resp != 2)
            {
                Console.WriteLine("Sem está opção.\n");
                selectForOrForeach();
            }

            return resp;
        }

        private static void Print(IEnumerable tad, int method, int length)
        {
            Console.Write("[");

            if (method == 1)
            {
                IEnumerator e = tad.GetEnumerator();
                for (int i = 0; i < length; i++)
                {
                    e.MoveNext();
                    Console.Write(" {0}", e.Current);
                }
            }
            else
            {
                foreach (var item in tad)
                {
                    Console.Write(" {0}", item);
                }
            }

            Console.WriteLine(" ]\n");
        }

        private static void PrintImpar(IEnumerable tad, bool key, int method, int length)
        {
            Console.Write("[");

            if (method == 1)
            {
                IEnumerator e = tad.GetEnumerator();
                for (int i = 0; i < length; i++)
                {
                    e.MoveNext();
                    bool regra = (key ? i : Convert.ToInt32(e.Current)) % 2 != 0;
                    if (regra)
                        Console.Write(" {0}", e.Current);
                }
            }
            else
            {
                int i = 0;
                foreach (var item in tad)
                {
                    bool regra = (key ? i : Convert.ToInt32(item)) % 2 != 0;
                    if (regra)
                        Console.Write(" {0}", item);
                    i++;
                }
            }

            Console.WriteLine(" ]\n");
        }

        private static void PrintHalf(IEnumerable tad, int length, int method)
        {
            Console.Write("[");

            if (method == 1)
            {
                IEnumerator e = tad.GetEnumerator();
                for (int i = 0; i <= length / 2; i++)
                {
                    e.MoveNext();
                    Console.Write(" {0}", e.Current);
                }
            }
            else
            {
                int i = 0;
                foreach (var item in tad)
                {
                    if (i > length / 2) break;
                    Console.Write(" {0}", item);
                    i++;
                }
            }

            Console.WriteLine(" ]\n");
        }

        private static void ReverseQueue(Queue tad)
        {
            object?[] aux = tad.ToArray();
            tad.Clear();
            for (int i = aux.Length - 1; i >= 0; i--)
            {
                tad.Enqueue(aux[i]);
            }
        }

        private static void ReverseStack(Stack tad)
        {
            object?[] aux = tad.ToArray();
            tad.Clear();
            for (int i = aux.Length - 1; i >= 0; i--)
            {
                tad.Push(aux[i]);
            }
        }
    }
}