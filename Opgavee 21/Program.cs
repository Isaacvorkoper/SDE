using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavee_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int result;

            Console.WriteLine("\nIndtast et tal:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast et andet tal:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
        }
    }
}
