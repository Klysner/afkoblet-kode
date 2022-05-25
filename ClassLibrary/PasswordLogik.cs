using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PasswordLogik
    {
        string txt = File.ReadAllText(@"C:\Users\kaslas\Desktop\Projects\Afkoblet kode\TheThreeCases\TextFile1.txt");

        public void Login()
        {
            var delttxt = txt.Split(';');
            string kontrolnavn = delttxt[0].ToLower();
            string kontrolpw = delttxt[1];

            Console.WriteLine("Indtast brugernavn: ");
            kontrolnavn = Console.ReadLine();
            Console.WriteLine("Indtast password: ");
            kontrolpw = Console.ReadLine();

            if (kontrolnavn == delttxt[0] && kontrolpw == delttxt[1])
            {

                Console.WriteLine("Login Godkendt");
            }
            else
            {
                Console.WriteLine("Login ikke godkendt.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        public void PasswordÆndring()
        {
            //Variabler
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            string nytpw, nybruger;
            bool Stor = false, Lille = false, Symbol = false, Mellemrum = true;

            //Smider dem i arrays og giver dem identifiers
            var delttxt = txt.Split(';');
            string kontrolnavn = delttxt[0].ToLower();
            string kontrolpw = delttxt[1];


            Console.WriteLine("Velkommen til ændring af password & brugernavn.");

            Console.WriteLine("Indtast nyt brugernavn: ");
            nybruger = Console.ReadLine();

            Console.WriteLine("Bemærk at et password skal være mindst 12 tegn, anvende store og små bogstaver, mindst et tal og mindst et specialtegn.");
            Console.WriteLine("Den må ikke indeholde mellemrum og ikke starte eller slutte med et tal.");
            Console.WriteLine("Indtast nyt password: ");
            nytpw = Console.ReadLine();

            for (int i = 0; i < nytpw.Length; i++)
            {
                char ok = nytpw[i];

                if (!char.IsUpper(ok))
                { Stor = true; }

                if (!char.IsLower(ok))
                { Lille = true; }

                if (Regex.IsMatch(nytpw, @"[!-&]"))
                { Symbol = true; }

                if (char.Equals(ok, " "))
                { Mellemrum = false; }
            }

            if (nytpw.Length > 12 && !char.IsDigit(nytpw[0]) && !char.IsDigit(nytpw[nytpw.Length - 1]) && Stor && Lille && Symbol && Mellemrum)
            {

                File.WriteAllText(@"c:\users\kaslas\desktop\projects\afkoblet kode\thethreecases\textfile1.txt", nybruger + ";" + nytpw);
                Console.WriteLine("Dit nye kodeord er nu gemt.");
                Console.ReadKey();
            }
            else { Console.WriteLine("ikke godkendt password"); }
            Console.ReadKey();


        }
    }
}