using System;

namespace ex1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da esfera");
            double raio =  int.Parse(Console.ReadLine());
            VolumeCalc(raio);
        }

        static void VolumeCalc(double raio){
            double volume = (4 * 3.14 * raio*raio*raio)/3;
            Console.WriteLine("O volume é: " + volume);
        }
         
    }
}