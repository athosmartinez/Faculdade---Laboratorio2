using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int respostas = int.Parse(Console.ReadLine());
            while (respostas > 0)
            {
                bool respFim = true;
                string[] pessoasEdiff = Console.ReadLine().Split(' ');
                int pessoas = int.Parse(pessoasEdiff[0]);
                int dif = int.Parse(pessoasEdiff[1]);
                string[] tempAlturas = Console.ReadLine().Split(' ');
                int[] alturas = new int[pessoas * 2];
                for (int i = 0; i < tempAlturas.Length; i++)
                {
                    alturas[i] = int.Parse(tempAlturas[i]);
                }
                OrdenarBubble(alturas);
                for (int i = 0; i < pessoas; i++)
                {
                    int subtracao = alturas[pessoas + i] - (alturas[i] + dif);
                    if (subtracao < 0)
                    {
                        respFim = false;
                    }
                    if (i == pessoas - 1)
                    {
                        if (respFim)
                        {
                            Console.WriteLine("SIM");
                        }
                        else
                        {
                            Console.WriteLine("NAO");
                        }
                    }
                }
                respostas--;
            }
        }
        public static void OrdenarBubble(int[] array)
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