using System;
using System.Collections;

namespace Lista11 {
	class Program {
		static void Main(string[] args) {
      // 11 – Faça um programa que preencha um ArrayList com elementos de diferentes tipos (int, double, float, boolean, String). Tente calcular a soma dos elementos. Evidentemente, isso irá provocar uma mensagem de erro. Que mensagem o Visual Studio retorna?
      // Dica: você pode criar um ArrayList e já inicializá-lo com alguns elementos conforme o exemplo abaixo:
      // ArrayList AL = new ArrayList() { 1, 2, "AED", new Queue(), "teste", 3.14 };
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
      ArrayList array = new ArrayList() { 1, 2.5, 10.10, true, "Athos" };

      var soma = 0;
      foreach(var item in array) {
        soma += Convert.ToInt32(item);
      }
      Console.WriteLine("Soma: {0}", soma);
      // ERRO: Unhandled exception. System.FormatException: Input string was not in a correct format.
    }

    public static void SoluctionOfQueuee() {
      Queue queue = new Queue();
      queue.Enqueue(1);
      queue.Enqueue(1.5);
      queue.Enqueue(10.10);
      queue.Enqueue(true);
      queue.Enqueue("Athos");

      var soma = 0;
      foreach(var item in queue) {
        soma += Convert.ToInt32(item);
      }
      Console.WriteLine("Soma: {0}", soma);
      // ERRO: Unhandled exception. System.FormatException: Input string was not in a correct format.
    }

    public static void SoluctionOfStack() {
      Stack stack = new Stack();
      stack.Push(1);
      stack.Push(1.5);
      stack.Push(10.10);
      stack.Push(true);
      stack.Push("Athos");

      var soma = 0;
      foreach(var item in stack) {
        soma += Convert.ToInt32(item);
      }
      Console.WriteLine("Soma: {0}", soma);
      // ERRO: Unhandled exception. System.FormatException: Input string was not in a correct format.
    }
  }
}