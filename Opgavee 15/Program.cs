using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavee_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));
        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}