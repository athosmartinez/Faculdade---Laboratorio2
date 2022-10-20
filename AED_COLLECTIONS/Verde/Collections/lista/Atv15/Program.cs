using System;
using System.Collections;

namespace Lista15 {
	class Program {
		static void Main(string[] args) {
      // 15 – Crie uma função que receba a coleção como parâmetro e retorne a soma de seus elementos. Obs: considere que todos seus dados são do tipo int.
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

      for(int i=1; i<=10; i++) {
        array.Add(i);
      }

      Console.WriteLine("\nSoma Array: {0}\n", Soma(array));
    }

    public static void SoluctionOfQueuee() {
      Queue queue = new Queue();

      for(int i=1; i<=10; i++) {
        queue.Enqueue(i);
      }

      Console.WriteLine("\nSoma Queue: {0}\n", Soma(queue));
    }

    public static void SoluctionOfStack() {
      Stack stack = new Stack();

      for(int i=1; i<=10; i++) {
        stack.Push(i);
      }

      Console.WriteLine("\nSoma Stack: {0}\n", Soma(stack));
    }

    private static int Soma(IEnumerable tad) {
      int soma = 0;
      foreach(var item in tad) {
        soma += Convert.ToInt32(item);
      }
      return soma;
    }
  }
}