using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    class Teglalap : Sikidom
    {
        private double szelesseg;
        private double hosszusag;
        public Teglalap(double szelesseg, double hosszusag, string Szin) : base(Szin)
        {
            this.Szelesseg = szelesseg;
            this.Hosszusag = hosszusag;
        }

        
        public double Szelesseg { get => Math.Round(szelesseg, 3); set => szelesseg = value; }
        public double Hosszusag { get => Math.Round(hosszusag, 3); set => hosszusag = value; }

        public override string ToString()
        {
            string text;
            if (szelesseg == hosszusag)
            {
                text = "négyzet";
            }
            else
            {
                text = "téglalap";
            }
            return "Egy " + Szelesseg + "x" + Hosszusag + " cm-es, " + Kerulet + " cm kerületű és " + Terulet + " cm2 területű " + text + ".";

        }

        protected override double kerulet()
        {
            return 2 * (szelesseg + hosszusag);
        }

        protected override double terulet()
        {
            return szelesseg * hosszusag;
        }
    }
}