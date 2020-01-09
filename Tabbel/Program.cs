using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i <= 100; i++)
            {
                for (int j = 5; j <= 100; j++)
                {
                    Console.Write((i * j).ToString() + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
