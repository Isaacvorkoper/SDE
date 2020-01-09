using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavee_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            Console.Write("Indtast første tal: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast andet tal: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast tredje tal: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Resultatet bliver {0}, {1} og {2}, (x+y)·z er {3} og x·y + y·z er {4}\n\n",
            number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));

        }
    }
}
