using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class DanseLogik
    {
        public string navn;
        public int points;

        public DanseLogik()
        { }

        public DanseLogik(string navn, int points)
        {
            this.navn = navn;
            this.points = points;
        }
        public static DanseLogik operator +(DanseLogik danser1, DanseLogik danser2)
        {
            return new DanseLogik(danser1.navn + " og " + danser2.navn, danser1.points + danser2.points);
        }
    }

}



