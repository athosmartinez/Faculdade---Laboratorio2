using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void LerArquivo(string arquivo)
        {
            LerArquivo(arquivo, File);
        }

        private static void LerArquivo(string arquivo, File file)
        {
            using (StreamReader arquivo = file.OpenText(File))
            {
            string linha;
            while((linha = arquivo.ReadLine()) != null)
            {
               ThreadPool.QueueUserWorkItem(ProcessaLinha, Linha);
            }
            }
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}