using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class FodboldLogik
    {
        public string beregning(string text, int tal)
        {
            string mål = text;
            int afleveringer = tal;
               
            StringBuilder sb = new StringBuilder();
            var sbNew = sb;

            if (mål == "mål")
            {
                sb.Append("Olé Olé Olé");
                //Console.WriteLine("Olé Olé Olé");
            }
            else
            {
                // huh 1-10
                if (afleveringer > 0 && afleveringer < 10)
                {
                    for (int i = 0; afleveringer > i; i++)
                        sb.Append("Huh!");
                    //Console.Write("Huh!");
                }

                // high five - jubel 10+
                if (afleveringer >= 10)
                {
                    sb.Append("High Five - Jubel!!!");
                    //Console.WriteLine("High Five - Jubel!!!");
                }

                // Shh 0
                if (afleveringer < 1)
                {
                    sb.Append("Shh");
                    //Console.WriteLine("Shh");
                }
            }
            
            return sb.ToString();
        }


    }
}
