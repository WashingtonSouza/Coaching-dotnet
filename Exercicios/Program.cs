using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntecessorEMultiplo
{
    class Program
    {
        static void Main(string[] args)   
        {
            Console.WriteLine("Digite um valor ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor ");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O antecessor de {0} é {1} ", a, a -1);             
            Console.WriteLine("\n");
            Console.WriteLine("O antecessor de {0} é {1} ", b, b - 1);
            Console.WriteLine("\n");

            if ((a / b) == 0)
            {
                Console.WriteLine(a + " é multiplo de " + b );
            }
            else
                Console.WriteLine(a + " Não é multiplo de " + b);

            Console.ReadKey();
        }
    }
}
