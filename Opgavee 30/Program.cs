using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavee_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Hex Code: ");
            Console.WriteLine("Hex Code: {0}", Convert.ToInt32(Console.ReadLine(), 16));
        }
    }
}
