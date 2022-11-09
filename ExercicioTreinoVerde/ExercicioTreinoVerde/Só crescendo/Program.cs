using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nTestes, tArray;
            nTestes = int.Parse(Console.Readline());
            while (nTestes > 0)
            {
                tArray = int.Parse(Console.Readline());
                string[] numeros = Console.Readline().Split(' ');
                int[] array = new int[tArray];
                for (int i = 0; i < tArray; i++)
                {
                    array[i] = int.Parse(numeros[i]);
                }
                Ordenar(tArray);
                for (int i = 0; i < tArray; i++)
                {
                    Console.WriteLine(array[i] < array[i + 1] ? "SIM" : "NAO");
                }
            }
            static int[] OrdenarBubbleSort(int[] array)
            {
                int aux;
                for (int posicao = 1; posicao < array.Length; posicao++)
                {
                    for (int difposicao = 0; posicao < array.Length - 1; difposicao--)
                    {
                        if (array[difposicao] > array[posicao])
                        {
                            int aux = array[posicao];
                            array[posicao] = array[difposicao];
                            array[difposicao] = aux;
                        }
                    }
                }
                return array;
            }
        }
    }
}