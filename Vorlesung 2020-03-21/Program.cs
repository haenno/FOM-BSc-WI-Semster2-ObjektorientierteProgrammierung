using System;
using System.Collections.Generic;

namespace Vorlesung_2020_03_21
{
    class Auto
    {
        public string Nummernschild;
        public int Kilometerstand;

        /*Aufgabe 1:
         * Erweiterung um:
         *  - Max. Tankgröße (Attribut)
         *  - akt. Tankfüllung (Attribut)
         *  - Methode zum Tanken  (Methode)
         *  */
        
        public void PrintYourself()
        {
            string LäuftText = "aus";
            if (Läuft) { LäuftText = "an"; }
            
            Console.Write("\n\n\nDas Auto mit dem Nummernschild '" + Nummernschild + "' hat " + Kilometerstand + "km gelaufen" +
                ", der Tank ist zu "+ (Tankinhalt / Tankvolumen * 100) + "% gefüllt und der Motor ist "+LäuftText + ".\n\n\n");
            
        }

        /* Lösungsansatz: Daten selbst in absoluten Zahlen/Litern, da später leichter für andere Zwecke abzuwandeln (Berechnung Kosten,...) */

        public float Tankvolumen;
        public float Tankinhalt;

        public void Tanken ()
        {
            float TankInhaltInProzent = Tankinhalt / Tankvolumen * 100;
            Console.WriteLine("Wilkommen an der Tankstelle Heupel!\n " +
                "Ihr Tank ist zu " + TankInhaltInProzent + "% gefüllt.");

            Console.Write("Sie könnten jetzt bis zu " + (Tankvolumen - Tankinhalt) + " Liter tanken. \n" +
                " Wie viel Liter sollen getankt werden?   ");

            float TankMenge = Convert.ToSingle(Console.ReadLine());

            if (TankMenge + Tankinhalt > Tankvolumen)
            {
                Console.WriteLine("Ohje! Das wäre zu aber viel. Wir machen den Tank einfach randvoll.");
                TankMenge = Tankvolumen-Tankinhalt;
            }

            Tankinhalt = TankMenge + Tankinhalt;
            TankInhaltInProzent = Tankinhalt / Tankvolumen * 100;

            Console.WriteLine("Tankvorgang beendet. \n " +
                "Ihr Tank ist jetzt zu " + TankInhaltInProzent + "% gefüllt. \n " +
                "Danke! Besuchen Sie uns bald wieder! \n\n");

        }


        /* Aufgabe 2 
         *  a) M: Anlassen & Abschalten, Z: Läuft
         *  b) M: Fahren() mit Strecke in km und Abfrage Läuft */

        public bool Läuft;
        public Auto(string nummernschild, int kilometerstand, float tankvolumen, float tankinhalt)
        {
            Läuft = false;

            Nummernschild = nummernschild;
            Kilometerstand = kilometerstand;
            Tankvolumen = tankvolumen;
            Tankinhalt = tankinhalt;

        }

        public void Anlassen()
        {
            string Statusmeldung;
            if (Läuft==true)   {               Statusmeldung = "*krrr-quitsch-ratter* (Ohje! Der Wagen war schon an!)"; }
            else               { Läuft = true; Statusmeldung = "*vrooom* (Wagen ist jetzt an.)"; }
            Console.WriteLine(Statusmeldung);
        }

        public void Abschalten()
        {
            string Statusmeldung;
            if (Läuft == true) { Läuft = false; Statusmeldung = "*rop-flop-flop* (Der Wagen ist jetzt aus."; }
            else               {                Statusmeldung = "*mhpf* (Ohje! Wagen war gar nicht an!)"; }
            Console.WriteLine(Statusmeldung);
        }
        public void Fahren(int Strecke)
        {
            string Statusmeldung;
            if (Läuft == true) 
            {
                Kilometerstand = Kilometerstand + Strecke;
                Statusmeldung = "Nach der Reise beträgt der Kilometerstand " + Kilometerstand +"km."; }
            else 
            { 
                Statusmeldung = "*sluff* (Das Gaspedal ist funktionslos. Der Motor ist aus.)"; 
            }
            Console.WriteLine(Statusmeldung);
            // ToDo: Tankstand verringern
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            //Auto auto2 = new Auto("M-AB 123", 909090, 75.0f, 0.5f);
            //auto2.PrintYourself();
            //Console.WriteLine("Tankvorgang Auto 2:\n\n");
            //auto2.Tanken();


            Auto auto1 = new Auto("SI-MS 188", 100000, 50.0f, 25.0f);
            auto1.PrintYourself();
            
            Console.WriteLine("Tankvorgang Auto 1:\n\n");
            auto1.Tanken();

            auto1.PrintYourself();

            auto1.Fahren(50);
            auto1.PrintYourself();

            auto1.Anlassen();
            auto1.PrintYourself();
            
            auto1.Fahren(50);
            auto1.PrintYourself();

            auto1.Anlassen();
            auto1.PrintYourself();

            auto1.Abschalten();






        }
    }
}
