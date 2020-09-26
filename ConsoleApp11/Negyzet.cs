using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    class Negyzet : Teglalap
    {
        protected double oldalhossz;
        public Negyzet(double oldalhossz, string szin) : base(oldalhossz, oldalhossz, szin)
        {
            this.oldalhossz = oldalhossz;
        }
    }
}
