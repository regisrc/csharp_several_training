using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace numeroPrimosRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            List<int> lista = new List<int>();
            for (int i = 2; i < 1000000; i++)
            {
                if (i % 2 == 0) continue;
                else
                {
                    bool isPrime = true;
                    for (int j = 3; j < i / 2; j++)
                    {
                        if (VerificaPrimo(i, j))
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime) lista.Add(i);
                }
            }
            Console.WriteLine(DateTime.Now - current);
        }

        private static bool VerificaPrimo(int primeiroNumero, int segundoNumero) => primeiroNumero % segundoNumero == 0;
    }
}
