using System;
using System.Collections;

namespace Lista16 {
	class Program {
		static void Main(string[] args) {
      // 16 – Crie uma função que calcule o número de elementos positivos de uma coleção passada como parâmetro.
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
      ArrayList array = new ArrayList();

      for(int i=-10; i<=10; i++) {
        array.Add(i);
      }

      Console.WriteLine("\nArray tem {0} números positivos\n", ContaPositivos(array));
    }

    public static void SoluctionOfQueuee() {
      Queue queue = new Queue();

      for(int i=-10; i<=10; i++) {
        queue.Enqueue(i);
      }

      Console.WriteLine("\nQueue tem {0} números positivos\n", ContaPositivos(queue));
    }

    public static void SoluctionOfStack() {
      Stack stack = new Stack();

      for(int i=-10; i<=10; i++) {
        stack.Push(i);
      }

      Console.WriteLine("\nStack tem {0} números positivos\n", ContaPositivos(stack));
    }

    private static int ContaPositivos(IEnumerable tad) {
      int cont = 0;
      foreach(var item in tad) {
        int value = Convert.ToInt32(item);
        if (value > 0)
          cont++;
      }
      return cont;
    }
  }
}