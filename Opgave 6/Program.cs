using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast første tal");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("indtast andet tal");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
                    {
                        result = Gange(input_1, input_2);
                    }
            Console.WriteLine("Resultatet er {0}", result);
            Console.ReadKey();
        }

        //Gange
        public static int Gange(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }
    }
}