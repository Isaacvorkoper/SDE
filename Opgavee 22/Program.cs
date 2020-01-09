using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavee_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nIndtast et tal: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(x));
        }

        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
            return false;
        }
    }
}
