using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    class Kor : Sikidom
    {
        private double sugar;
        public Kor(double sugar, string Szin) : base(Szin)
        {
            this.Sugar = sugar;
        }

        public double Sugar { get => Math.Round(sugar, 3); set => sugar = value; }

        public override string ToString()
        {
            return "Egy " + Sugar + " cm sugarú, " + Kerulet + " cm kerületű és " + Terulet + " cm2 területű kör.";
        }

        protected override double kerulet()
        {
            return 2 * sugar * Math.PI;
        }

        protected override double terulet()
        {
            return sugar * sugar * Math.PI;
        }

    }
}
