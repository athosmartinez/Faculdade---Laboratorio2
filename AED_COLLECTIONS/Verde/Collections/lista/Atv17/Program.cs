using System;
using System.Collections;

namespace Lista17 {
	class Program {
		static void Main(string[] args) {
      // 17 – Crie uma função que calcule o número de ocorrências em uma coleção de um elemento passado como parâmetro.
      int op = 0;

      do {
        Console.WriteLine("Selecione uma opção");
        Console.WriteLine("1 - Array");
        Console.WriteLine("2 - Queuee");
        Console.WriteLine("3 - Stack");
        Console.WriteLine("4 - Sair");
        op = Convert.ToInt32(Console.ReadLine());

        switch (op) {
          case 1: SoluctionOfArray(); break;
          case 2: SoluctionOfQueuee(); break;
          case 3: SoluctionOfStack(); break;
          case 4: continue;

          default:
            Console.WriteLine("Sem está opção.\n");
            break;
        }
      } while(op != 4);
    }

    public static void SoluctionOfArray() {
      ArrayList array = new ArrayList() {5, 5, 10, 15, 20, 25, 5, 20};

      Console.WriteLine("\nArray tem {0} números equivalentes a 5\n", numOcorrencias(array, 5));
    }

    public static void SoluctionOfQueuee() {
      Queue queue = new Queue();
      queue.Enqueue(5);
      queue.Enqueue(5);
      queue.Enqueue(10);
      queue.Enqueue(15);
      queue.Enqueue(20);
      queue.Enqueue(25);
      queue.Enqueue(5);

      Console.WriteLine("\nQueue tem {0} números equivalentes a 20\n", numOcorrencias(queue, 20));
    }

    public static void SoluctionOfStack() {
      Stack stack = new Stack();
      stack.Push(5);
      stack.Push(5);
      stack.Push(10);
      stack.Push(15);
      stack.Push(20);
      stack.Push(25);
      stack.Push(5);

      Console.WriteLine("\nStack tem {0} números equivalentes a 30\n", numOcorrencias(stack, 30));
    }

    private static int numOcorrencias(IEnumerable tad, int value) {
      int cont = 0;
      foreach(var item in tad) {
        if (Convert.ToInt32(item) == value)
          cont++;
      }
      return cont;
    }
  }
}