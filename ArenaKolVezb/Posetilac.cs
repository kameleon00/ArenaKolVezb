using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaKolVezb
{
    class Posetilac
    {
        private string ime;
        private int godine;

        public string Ime
        {
            get { return ime; } set { ime = value; }
        }
        public int Godine
        {
            get { return godine; } set { godine = value; }
        }

        public Posetilac() { }

        public Posetilac (string i, int g)
        {
            ime = i;
            godine = g;
        }

        public override string ToString()
        {
            return "Posetilac " + ime + " ima " + godine + " godina.";
        }
    }
}
