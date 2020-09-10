using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavee_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] text = sentence.Split(' ');

            Array.Reverse(text);
            foreach (string word in text)
            {
                Console.Write(word + " ");
            }
        }
    }
}
