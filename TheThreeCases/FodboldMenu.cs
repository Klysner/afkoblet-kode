using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace TheThreeCases
{
    internal class FodboldMenu
    {
        ClassLibrary.FodboldLogik _fodboldlogik;

        //Constructor
        public FodboldMenu()
        {

            _fodboldlogik = new FodboldLogik();

            Console.WriteLine("Hvor mange afleveringer har vores hold lavet?");
            int afleveringer = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Hvis der er blevet lavet mål, tast mål");
            string mål = Console.ReadLine().ToLower();

            Console.WriteLine(_fodboldlogik.beregning(mål, afleveringer));

            Console.ReadKey();
        }
    }
}
