using System;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            int indx = getIndexOf(Console.ReadLine());
            Console.WriteLine($"Quantidade: {indx}");
        }

        public static int getIndexOf(String palavra)
        {
            int qtdVezes = 0, indexPal = 0;
            while (indexPal <= TextContent().Length)
            {
                indexPal = TextContent().IndexOf(palavra, indexPal) + 1;
                if (indexPal != 0)
                {
                    qtdVezes++;
                }
                else return 0;
            }
            return qtdVezes;
        }


        private static String TextContent() => @"aaaa";

    }
}
