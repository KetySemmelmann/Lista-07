using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000; i = i + 1)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine( i + " - É múltiplo de 7");
                }

            }

            Console.ReadKey();
        }
    }
}
