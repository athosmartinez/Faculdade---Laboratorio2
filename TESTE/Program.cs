using System;

namespace TP2
{
    class Teste{
        public static void Executar(){
            Print(String.Format(@$"
                {"amanda".CompareTo("yago")}
                {"amanda".CompareTo("amanda")}
                {"yago".CompareTo("amanda")}
            "));
        }
        /*
        -1
        0
        1
        */


        public static void Print(string texto){
            Console.WriteLine(texto);
        }
    }
}