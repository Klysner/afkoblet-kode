using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.IO;

namespace TheThreeCases
{
    internal class PasswordMenu
    {
        string txt = File.ReadAllText(@"C:\Users\kaslas\Desktop\Projects\Afkoblet kode\TheThreeCases\TextFile1.txt");
        string pw, brugernavn, brugerforsøg, pwforsøg;


        public PasswordMenu()
        {
            var delttxt = txt.Split(';');
            //Smider dem i arrays og giver dem identifiers
            string kontrolnavn = delttxt[0].ToLower();
            string kontrolpw = delttxt[1];

            Console.Clear();
            Console.WriteLine("Brugernavn: ");
            brugerforsøg = Console.ReadLine().ToLower();
            Console.WriteLine("Password: ");
            pwforsøg = Console.ReadLine();


            if (brugerforsøg == delttxt[0] && pwforsøg == delttxt[1])
            {
                Console.WriteLine("Velkommen til ændring af password & brugernavn.");

                Console.WriteLine("Indtast nyt brugernavn: ");
                kontrolnavn = Console.ReadLine();
                Console.WriteLine("Bemærk at et password skal være mindst 12 tegn, anvende store og små bogstaver, mindst et tal og mindst et specialtegn.");
                Console.WriteLine("Den må ikke indeholde mellemrum og ikke starte eller slutte med et tal.");
                Console.WriteLine("Indtast nyt password: ");
                
                if (pw.Length < 12 && char.IsDigit(kontrolpw[0]) && char.IsDigit(kontrolpw[kontrolpw.Length - 1])) 
                kontrolpw = Console.ReadLine();

                File.WriteAllText(@"C:\Users\kaslas\Desktop\Projects\Afkoblet kode\TheThreeCases\TextFile1.txt", brugernavn + ";" + pw);
            }


        }

    }
}
