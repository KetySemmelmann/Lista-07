using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;


            for (int i = 85; i <= 907; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - É par");
                    soma = soma + i;
                    Console.WriteLine("A soma dos valores é: {0}", soma);
                }


            }

            Console.ReadKey();
        }
    }
}
