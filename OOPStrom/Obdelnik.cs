using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStrom
{
    class Obdelnik:Tvar
    {
        public double stranaA;
        public double stranaB;

        public Obdelnik(double stranaA, double stranaB, string barva) : base(barva)
        {
            this.stranaA = stranaA;
            this.stranaB = stranaB;
        }

        public double VypocitejObsahObdelniku()
        {
            double obsah = stranaA * stranaB;
            return obsah;
        }
    }
}
