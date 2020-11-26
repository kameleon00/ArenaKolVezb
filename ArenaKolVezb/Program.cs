using ArenaKolVezb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedenaDvorana
{
    class Program
    {
        static void Main(string[] args)
        {
            Posetilac p1 = new Posetilac("Pera Peric", 6);
            Posetilac p2 = new Posetilac("Ivan Ivanovic", 23);
            Posetilac p3 = new Posetilac("HK Partizan", 12);
            Posetilac p4 = new Posetilac("HK Crvena Zvezda", 14);
            Posetilac p5 = new Posetilac("KK Helena Pajovic", 10);
            Posetilac p6 = new Posetilac();

            p6.Ime = "Marko Mitrovic";
            p6.Godine = 40;

            Posetilac p7 = new Posetilac("HK Partizan", 14);
            Posetilac p8 = new Posetilac("Ana Anic", 8);
            Posetilac p9 = new Posetilac("Mina Minic", 18);
            Posetilac p10 = new Posetilac("HK Crvena Zvezda", 15);

            TerminNaLedu s1 = new SlobodnoKlizanje(50, 300);

            s1.dodajPosetioca(p1);
            s1.dodajPosetioca(p2);
            s1.dodajPosetioca(p3);
            s1.dodajPosetioca(p4);
            s1.dodajPosetioca(p5);
            s1.dodajPosetioca(p6);
            s1.dodajPosetioca(p7);
            s1.dodajPosetioca(p8);
            s1.dodajPosetioca(p9);
            s1.dodajPosetioca(p10);

            Console.WriteLine(s1);

            TerminNaLedu k1 = new Klub(50, false, 10000);

            k1.dodajPosetioca(p3);
            k1.dodajPosetioca(p7);

            Console.WriteLine(k1);

            TerminNaLedu k2 = new Klub(50, true, 10000);

            k2.dodajPosetioca(p3);
            k2.dodajPosetioca(p7);
            k2.dodajPosetioca(p4);
            k2.dodajPosetioca(p10);

            Console.WriteLine(k2);

            Console.ReadLine();


        }
    }
}