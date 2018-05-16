using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Escreva um algoritmo que calcule a média dos números digitados pelo
             * usuário, se eles forem pares. Termine a leitura se o usuário digitar zero(0*/
            int num = 0,soma = 0, media = 0;
            
            do
            {
               
                Console.Write(num + " - Digite um número: ");
                num = Convert.ToInt16(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine(num + " - É par");
                    soma = soma + num;
                    media = soma / num;
                    Console.WriteLine("A média dos valores é: {0}", media);
                }

            } while (num != 0s);
               


            }

            Console.ReadKey();
        }
    }
}
