using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terningkast
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int res = dice.Next(1, 7);
            int i = 1;

            while(res != 6){
                res = dice.Next(1, 7);
                i++;
            }
            Console.WriteLine("Det tog #{0:D} gange at slå en sekser", i);
            }
        }
    }
