using System;
namespace teste {
	class Program {
		static void Main(string[] args) {
            Console.WriteLine("Insira o valor de n:");
            int n = int.Parse(Console.ReadLine());

            int result = CalcNesimo(n);
            Console.WriteLine(result);
		}

        public static int CalcNesimo(int n) {
            if (n==1)
                return 2;
            if (n==2)
                return 3;
            return 5 * n + CalcNesimo(n-1);
        }
	}
}