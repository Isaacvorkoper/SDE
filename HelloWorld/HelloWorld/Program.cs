using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string Fornavn;
            string Efternavn;
            int Alder;
            
            string Køn;
            char charKøn = ' ';

            int oldage
            int ageToOld;

            Console.Write("Hvad er dit fornavn?");
            Fornavn = Console.ReadLine();

            Console.Write("Hvad er dit efternavn?");
            Efternavn = Console.ReadLine();

            Console.Write("Hvad er din alder?");
            Alder = int.Parse(Console.ReadLine());

            Console.Write("Hvad er dit køn?");
            Køn = Console.ReadLine();

            switch(Køn)
                {
                case "mand":
                    charKøn = "m";
                    Køn = "m";
                    break;
                case "Mand":
                    charKøn = "m";
                    Køn = "m";
                    break;
                case "kvinde":
                    charKøn = "k";
                    Køn = "k";
                    break;
                case "Kvinde":
                    charKøn = "k";
                    Køn = "k";
                    break;

            }

            Console.WriteLine(Fornavn);
            Console.WriteLine(Efternavn);
            Console.WriteLine(Alder);
            Console.WriteLine(Køn);
        }n
    }
}
