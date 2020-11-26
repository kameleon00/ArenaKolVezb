using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaKolVezb
{
    abstract class TerminNaLedu
    {
        protected int maksPosetilaca;
        protected int brPosetilaca;
        protected Posetilac[] posetioci;

        public void dodajPosetioca (Posetilac p)
        {
            if (brPosetilaca < maksPosetilaca)
                posetioci[brPosetilaca++] = p;
        }
        public abstract float zarada();

        public TerminNaLedu()
        {
            maksPosetilaca = 100;
            brPosetilaca = 0;

            posetioci = new Posetilac[maksPosetilaca];
        }
        public TerminNaLedu(int mp)
        {
            maksPosetilaca = mp;
            brPosetilaca = 0;

            posetioci = new Posetilac[maksPosetilaca];
        }

        public override string ToString()
        {
            return "U dvorani maksimalnog kapaciteta do " + maksPosetilaca + " ima trenutno " + brPosetilaca + " posetilaca.";
        }
    }
}
