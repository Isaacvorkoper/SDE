using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tryk på tallet som passer til din regnemåde");
            Console.WriteLine("Tryk på 1 for Plus");
            Console.WriteLine("Tryk på 2 for Minus");
            Console.WriteLine("Tryk på 3 for Gange");
            Console.WriteLine("Tryk på 4 for Division \n");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast første tal");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("indtast andet tal");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Plus(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Minus(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Gange(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Ugyldigt input!");
                    break;
            }
            Console.WriteLine("Resultatet er {0}", result);
            Console.ReadKey();
        }
        //Plus
        public static int Plus(int input_1, int input_2) {
            int result = input_1 + input_2;
            return result;
        }

        //Minus
        public static int Minus(int input_1, int input_2) {
            int result = input_1 - input_2;
            return result;
        }
        //Gange
        public static int Gange(int input_1, int input_2)  {
            int result = input_1 * input_2;
            return result;
        }
        //Division
        public static int Division(int input_1, int input_2) {
            int result = input_1 / input_2;
            return result;
        }
    }
}
