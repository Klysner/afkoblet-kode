using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace TheThreeCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordLogik obj = new PasswordLogik();

            Console.WriteLine("Log venligst ind for at fortsætte");
            obj.Login();

            Console.WriteLine("Velkommen til hovedmenuen \n Tast 1 for fodboldmenu \n Tast 2 for dansemenu \n tast 3 for ændring af password og bruger.");
            string tast = Console.ReadLine();


            switch (tast)
            {
                case "1":
                    var fussball = new FodboldMenu();
                    break;

                case "2":
                    var dancinginthemoonlight = new DanseMenu();
                    break;

                case "3":
                    var pw = new PasswordMenu();
                    break;

                default:
                    Console.WriteLine("Du har ikke valgt en gyldig menu.");
                    break;

            }

        }

    }
}
