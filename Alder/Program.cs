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

            int oldage;
            int ageToOld;

            Console.Write("Hvad er dit fornavn? ");
            Fornavn = Console.ReadLine();

            Console.Write("Hvad er dit efternavn? ");
            Efternavn = Console.ReadLine();

            Console.Write("Hvad er din alder? ");
            Alder = int.Parse(Console.ReadLine());

            Console.Write("Hvad er dit køn? ");
            Køn = Console.ReadLine();

            switch (Køn)
            {
                case "mand":
                    charKøn = 'm';
                    Køn = "mand";
                    break;
                case "Mand":
                    charKøn = 'm';
                    Køn = "mand";
                    break;
                case "kvinde":
                    charKøn = 'k';
                    Køn = "kvinde";
                    break;
                case "Kvinde":
                    charKøn = 'k';
                    Køn = "kvinde";
                    break;



            }

            Console.WriteLine("Hvor gammel skal man være før man er gammel? ");
            oldage = int.Parse(Console.ReadLine());

            if (oldage > Alder)
            {
                ageToOld = oldage - Alder;
                Console.WriteLine("Der går " + ageToOld + "år til at du bliver gammel");
            }
            else if (oldage <= Alder)
            {
                Console.WriteLine("Du er en gammel" + Køn + "!!");
            }
            Console.WriteLine(Alder);
            Console.WriteLine(Køn);
        }
    }
}