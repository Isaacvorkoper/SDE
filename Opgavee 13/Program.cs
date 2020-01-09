using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavee_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("{0} {0} {0}", n);
            Console.Write("\n\n{0}  {0}", n);
            Console.Write("\n\n{0}  {0}", n);
            Console.Write("\n\n{0}  {0}", n);
            Console.Write("\n\n{0}{0}{0}", n);
        }
    }
}
