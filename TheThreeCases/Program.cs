using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThreeCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til hovedmenuen \n Tast 1 for fodboldmenu \n Tast 2 for \n tast 3 for oprettelse af password");
            string tast = Console.ReadLine();

           
            switch (tast)
            {
                case "1":
                    var fussball = new FodboldMenu();
                    break;

                case "2":
                    var dancinginthemoonlight = new DanseMenu();
                    Console.ReadKey();
                    break;

                case "3":

                var pw = new PasswordMenu();
                    break;

                default:
                    Console.WriteLine("Du har ikke valgt en gyldig menu.");
                    break;

            }



            //1 FOR FODBOLD
            //2 FOR DANSEKONKURRENCE
            //3 FOR OPRETTELSE AF GYLDIGT PASSWORD

        }

    }
}
