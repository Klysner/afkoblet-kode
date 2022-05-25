using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.IO;
using System.Text.RegularExpressions;

namespace TheThreeCases
{
    internal class PasswordMenu
    {
        string txt = File.ReadAllText(@"C:\Users\kaslas\Desktop\Projects\Afkoblet kode\TheThreeCases\TextFile1.txt"), brugerforsøg, pwforsøg;

        public PasswordMenu()
        {
            PasswordLogik obj = new PasswordLogik();

            obj.PasswordÆndring();
        }

    }
}
