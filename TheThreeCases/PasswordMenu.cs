using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.IO;

namespace TheThreeCases
{
    public class PasswordMenu
    {
        string txt = File.ReadAllText(@"C:\Users\kaslas\Desktop\Projects\Afkoblet kode\TheThreeCases\TextFile1.txt");
        string pw, tast, brugernavn;

        public PasswordMenu()
        {
            Console.WriteLine("Velkommen til ændring af password & brugernavn. Tast 1 For at ændre brugernavn. Tast 2 for at ændre password.");
            switch (tast)
            {
                case "1":

                    Console.WriteLine("Indtast nyt brugernavn: ");
                    brugernavn = Console.ReadLine();

                    File.WriteAllText(@"C:\Users\kaslas\Desktop\Projects\Afkoblet kode\TheThreeCases\TextFile1.txt", brugernavn+";"+kontrolpw);
                   
                    break;

                case "2":

                    Console.WriteLine("Indtast nyt pw: ");
                    pw = Console.ReadLine();

                    File.WriteAllText(@"C:\Users\kaslas\Desktop\Projects\Afkoblet kode\TheThreeCases\TextFile1.txt", kontrolnavn+";"+pw);

                    break;

                default:
                    Console.WriteLine("Du har ikke valgt en gyldig menu.");
                    break;

            }
            Console.ReadKey();

            var delttxt = txt.Split(';');
            //Smider dem i arrays og giver dem identifiers
            string kontrolnavn = delttxt[0].ToLower();
            string kontrolpw = delttxt[1];
        }

    }
}
