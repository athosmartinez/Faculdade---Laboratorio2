using System;

namespace ex4 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] MatrizA = new int[12, 4];
            LeMatriz(MatrizA);
            ImprimeMatriz(MatrizA);
            SomaMes(MatrizA);
            MelhorSemana(MatrizA);
            Somatoria(MatrizA);
        }

        static void LeMatriz(int[,] MatrizA)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Digite o valor da posição [{0}][{1}]: ", i, j);
                    MatrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void ImprimeMatriz(int[,] Imprimir)
        {
            Console.WriteLine("OLHA A MATRIZ AÍ OH:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Imprimir[i, j] + " \t ");
                }
                Console.WriteLine();
            }
        }

        static void SomaMes(int[,] MatrizA)
        {
            for (int i = 0; i < 12; i++)
            {
                int soma = 0;
                for (int j = 0; j < 4; j++)
                {
                    soma += MatrizA[i, j];
                }
                Console.WriteLine("A soma do mês {0} é: {1}", i, soma);
            }
        }

        static void MelhorSemana(int[,] MatrizA)
        {
            int melhor = MatrizA[0, 0];
            int posicao = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (MatrizA[i, j] > melhor)
                    {
                        melhor = MatrizA[i, j];
                        posicao = j;
                    }
                }
            }
            Console.WriteLine("A melhor semana é a {0} com {1}", posicao, melhor);
        }
        static void Somatoria(int[,] MatrizA)
        {
            int soma = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    soma += MatrizA[i, j];
                }
            }
            Console.WriteLine("No ano foram vendidos {0} carros", soma);
        }
    }
}
