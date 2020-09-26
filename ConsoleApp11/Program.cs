using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] szinek = {"fekete", "fehér", "sárga", "piros", "kék", "lila", "zöld", "rózsaszín", "szürke" };

            Sikidom[] sikidomok = new Sikidom[5];
            Random r = new Random();
            for (int i = 0; i < sikidomok.Length; i++)
            {
                Sikidom uj;
                switch(r.Next(-1, 3))
                {
                    case 0:
                        uj = new Teglalap(r.NextDouble() * 100, r.NextDouble() * 100, szinek[r.Next(0, szinek.Length)]);
                        break;

                    case 1:
                        uj = new Kor(r.NextDouble() * 100, szinek[r.Next(0, szinek.Length)]);
                        break;

                    case 2:
                        uj = new Negyzet(r.NextDouble() * 100, szinek[r.Next(0, szinek.Length)]);
                        break;

                    default:
                        uj = new Teglalap(r.NextDouble() * 100, r.NextDouble() * 100, szinek[r.Next(0, szinek.Length)]);
                        break;
                }
                sikidomok[i] = uj;
            }
            
            /*Sikidom[] sikidomok =
            {
                new Kor(6, "fekete"),
                new Teglalap(5, 7, "kék"),
                new Negyzet(5, "piros"),
                new Teglalap(9, 16, "lila"),
                new Kor(4, "sárga")
            };*/

            foreach(Sikidom s in sikidomok)
            {
                Console.WriteLine(s);
            }
            Sikidom s1 = negyszogHozzaadas(10, 10, "fekete");
            Console.WriteLine("Legnagyobb területű síkidom: {0}", sikidomok[maximumTerulet(sikidomok)]);
            Console.ReadLine();
        }

        static Sikidom negyszogHozzaadas(double szelesseg, double hosszusag, string szin)
        {
            if (szelesseg == hosszusag)
            {
                return new Negyzet(szelesseg, "fekete");
            }
            else
            {
                return new Teglalap(szelesseg, hosszusag, "fekete");
            }
        }

        static int maximumTerulet(Sikidom[] sikidoms)
        {
            int teruletMax = 0;
            for (int i = 1; i < sikidoms.Length; i++)
            {
                if (sikidoms[i].Terulet > sikidoms[teruletMax].Terulet)
                {
                    teruletMax = i;
                }
            }
            return teruletMax;
        }
    }

    abstract class Sikidom
    {
        protected bool lyukas;
        protected string szin;
        protected abstract double kerulet();
        protected abstract double terulet();

        public double Kerulet { get => Math.Round(kerulet(), 3); }
        public double Terulet { get => Math.Round(terulet(), 3); }

        public Sikidom(string Szin)
        {
            lyukas = false;
            szin = Szin;
        }

        public void Kilyukaszt()
        {
            lyukas = true;
        }

        public void KilyukasztHa()
        {
            if (terulet() > kerulet())
            {
                lyukas = true;
            }
        }
    }
}
