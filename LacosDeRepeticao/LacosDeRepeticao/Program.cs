using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_LacosDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            while (count < 1000000)
            {
                Console.WriteLine("Número: " + count);
                count++;
            }
            Console.WriteLine("terminou o loop");
            Console.ReadKey();
        }
    }
}
