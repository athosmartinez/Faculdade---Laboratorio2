using System;

namespace ex3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            float media = GuardaN(numeros);
            int maiores = quantidadeDeMaiores(numeros, media);
            Console.WriteLine("São: " +maiores);
        }
        static float GuardaN(int[] numeros)
        {
            float somanumeros =0;
            Console.WriteLine("Digite 10 numeros para serem guardados:");
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
                somanumeros += numeros[i]; 
            }
            float media = somanumeros/10;
            Console.WriteLine("Os numeros digitados foram: ", numeros, somanumeros);
            return media;
        }
        static int quantidadeDeMaiores(int[] numeros, float media){
            int maiores = 0;
            for (int i = 0; i < 10; i++){
                if(numeros[i] > media){
                    Console.WriteLine("O número é maior que a média.");
                    maiores++;
                }
                else if (numeros[i] < media){
                    Console.WriteLine("O número é menor que a média.");
                }
            }
            return maiores;
        }
     }
}
