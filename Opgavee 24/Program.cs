using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavee_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en sætning: ");
            var input = Console.ReadLine();

            string[] input1 = input.Split(' ');
            var longestWord = input1.OrderByDescending(n => n.Length).First();

            Console.WriteLine("Det længste ord  er: " + longestWord);
        }
    }
}
