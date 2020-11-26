using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaKolVezb
{
    class SlobodnoKlizanje : TerminNaLedu
    {
        private float cenaKarte;

        public SlobodnoKlizanje() : base()
        {
            cenaKarte = 300;
        }
        public SlobodnoKlizanje(int ck, int mp) : base(mp)
        {
            cenaKarte = ck;
        }
        public override float zarada()
        {
            float zarada = 0;

            foreach (Posetilac p in posetioci)
            {
                if (p != null)
                {
                    if (p.Godine <= 7)
                        zarada += 0;
                    else if (p.Godine > 7 && p.Godine <= 18)
                        zarada += cenaKarte / 2;
                    else 
                        zarada += cenaKarte;
                }
            }
            return zarada;
        }
        public override string ToString()
        {
            return "Slobodno klizanje " + base.ToString() + " sa cenom karte od " + cenaKarte + " ostvaruje zaradu od " + zarada() + " RSD.";
        }
    }
}
