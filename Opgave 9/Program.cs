using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3, number4;

            Console.Write("Indtast første tal: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast andet tal: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast tredje tal: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast fjerde tal: ");
            number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("Gennemsnitet af {0}, {1}, {2}, {3} er: {4}",
                number1, number2, number3, number4, result);
        }
    }
}
