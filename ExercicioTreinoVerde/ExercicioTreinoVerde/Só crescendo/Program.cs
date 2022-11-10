using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;




namespace SóCrescendo // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Boolean resposta = true;
            int nTestes, tArray;
            //string s = Console.ReadLine();
            nTestes = int.Parse(Console.ReadLine());
            while (nTestes > 0)
            {
                tArray = int.Parse(Console.ReadLine());
                string[] numeros = Console.ReadLine().Split(' ');
                int[] array = new int[tArray];
                for (int i = 0; i < tArray; i++)
                {
                    array[i] = int.Parse(numeros[i]);
                }
                OrdenarBubbleSort(array);
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        resposta = false;
                    }
                }
                if (resposta == true)
                {
                    Console.WriteLine("SIM");
                }
                else
                {
                    Console.WriteLine("NAO");
                }
            }
           
        }
        static void OrdenarBubbleSort(int[] array)
        {
            for (int posicao = 1; posicao < array.Length; posicao++)
            {
                for (int difposicao = 0; difposicao < array.Length - 1; difposicao++)
                {
                    if (array[posicao] < array[difposicao])
                    {
                        int aux = array[posicao];
                        array[posicao] = array[difposicao];
                        array[difposicao] = aux;
                    }
                }
            }

        }
    }
}