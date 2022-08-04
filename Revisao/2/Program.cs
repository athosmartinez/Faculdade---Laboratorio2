using System;

namespace ex2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da esfera");
            double raio =  double.Parse(Console.ReadLine());
            VolumeCalc(raio);
        }

        static void VolumeCalc(double raio){
            double volume = (4 * 3.14 * raio*raio*raio)/3;
            Console.WriteLine("O volume é: " + Math.Floor(volume));

        }
         
    }
}