using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStrom
{
    class Trojuhelnik:Tvar
    {
        public double stranaA;
        public double stranaB;
        public double stranaC;
        public Trojuhelnik(double stranaA, double stranaB, double stranaC, string barva): base (barva)
        {
            this.stranaA = stranaA;
            this.stranaB = stranaB;
            this.stranaC = stranaC;
        }

        public double VypocitejObsahTrojuhelniku()
        {
            double s = (stranaA + stranaB + stranaC) / 2;
            double velkeS = Math.Sqrt(s * ((s - stranaA) * (s - stranaB) * (s - stranaC)));
            return velkeS;
           
        }
    }
}
