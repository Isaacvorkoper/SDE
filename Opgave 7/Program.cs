using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast første tal ");
            int num1= Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast andet tal ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
        }
    }
}
