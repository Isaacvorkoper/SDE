using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Indstast nummer");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num * i);
            }
        }
    }
}
