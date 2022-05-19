using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace TheThreeCases
{
    public class DanseMenu
    {
        ClassLibrary.DanseLogik _danselogik;

        public DanseMenu()
        {
            _danselogik = new DanseLogik();

            Console.WriteLine("Hvad er den første dansers navn?");
            string navn = Console.ReadLine();

            Console.WriteLine("Hvor mange point har danseren tjent");
            int points = Convert.ToInt32(Console.ReadLine());
            DanseLogik danser1 = new DanseLogik(navn, points);

            Console.WriteLine("Hvad er den anden dansers navn?");
            navn = Console.ReadLine();
            Console.WriteLine("Hvor mange point har danseren tjent");
            points = Convert.ToInt32(Console.ReadLine());
            DanseLogik danser2 = new DanseLogik(navn,points);

            DanseLogik danser3 = danser1 + danser2;

            Console.WriteLine(danser3.navn + ": " + danser3.points);

        }
    }
}

