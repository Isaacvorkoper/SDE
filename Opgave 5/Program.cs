using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.Write("\nIndtast første tal : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nIndtast det andet tal : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nEfter ombyt");
            Console.Write("\nFørste tal : "+number1);
            Console.Write("\nAndet tal : " + number2);
            Console.Read();
        }
    }
}
