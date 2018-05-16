using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count = 0, countPos = 0;

            do
            {
                count++;
                Console.Write(count + " - Digite um número: ");
                num = Convert.ToInt16(Console.ReadLine());

                if (num > 0)
                {
                    countPos++;
                }

            }
            while (num != 0);

            Console.WriteLine("Números digitados: " + count);
            Console.WriteLine("Números Positivos: " + countPos);

            Console.ReadLine();
        }
    }
}
