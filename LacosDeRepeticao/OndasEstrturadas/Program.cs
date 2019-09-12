using System;

namespace OndasEstrturadas
{
    class Program
    {
        static void Main(string[] args)
        {
            var caracter = "/***/";
            var caracterCresce = $"\\***\\";
            while (true)
            {
                for (int i = 0; i <= 100; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("\'");
                    }
                    Console.WriteLine($"{caracterCresce}");
                }
                for (int i = 100; i >= 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("\'");
                    }
                    Console.WriteLine($"{caracter}");
                }
            }
        }
    }
}
