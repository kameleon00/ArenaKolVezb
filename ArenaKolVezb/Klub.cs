using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaKolVezb
{
    class Klub : TerminNaLedu
    {
        private float osnovica;
        private bool takmicenje;

        public Klub() : base()
        {
            osnovica = 10000;
            takmicenje = false;
        }
        public Klub(float os, bool tak, int mp) : base(mp)
        {
            osnovica = os;
            takmicenje = tak;
        }
        public override float zarada()
        {
            if (takmicenje)
                return osnovica + 5000;
            else 
                return osnovica;
        }
        public override string ToString()
        {
            return "Klubski termin " + base.ToString() + " u kojem je odrzan turnir - " + takmicenje + " ostvaruje zaradu od " + zarada() + " RSD";
        }
    }
}
