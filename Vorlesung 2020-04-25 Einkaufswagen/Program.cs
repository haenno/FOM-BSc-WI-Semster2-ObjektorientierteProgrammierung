using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Vorlesung_2020_04_25_Einkaufswagen
{
    // Einstieg Aufgabe: Daten die während Nutzung "anfallen können"
    // - grundsätzlich wagen frei zur nutzung (leer + kette ab)
    // - platz im wagen / volumen / füllstand
    // - enthaltene artikel (anz., art)
    // - der den wagen nutzende kunde
    // - abstr. standort

    class Einkaufswagen
    {
        private int volumenWagen = 250; // Liter Volumen (50x50x100cm) 
        private int volumenGenutzt = 0;
        public bool nochPlatz = true;

        public bool wagenFrei = false;

        public List<Artikel> artikelListe; 
         
        public bool wagenLosketten()
        {
            // Kram machen
            return true;
        }
    }
    
    class Artikel
    {
        public string artikelName;
        public int artikelVolumen; // in Liter
        public float artikelPreis;
    }

    class Program
    {
               
        static void Main(string[] args)
        {
            bool einkaufsSystem= true;
            do
            {
                bool einkaufDurchlauf = true;
                Console.Clear();
                Console.WriteLine("--> Einkauf startet...");
                do
                {
                    Einkaufswagen meinWagen = new Einkaufswagen();
                    meinWagen.wagenFrei = meinWagen.wagenLosketten();
                    if (meinWagen.nochPlatz)
                    {
                        Artikel addArtikel = new Artikel();
                        Console.Write("Welcher Artikel soll in den Wagen?");
                        addArtikel.artikelName = Console.ReadLine();
                        
                        addArtikel.artikelVolumen = 3;      //ToDo: Abrufen DB oder Zufallszahl
                        addArtikel.artikelPreis = 8.99f;    //ToDo: Abrufen DB oder Zufallszahl
                        meinWagen.artikelListe.Add(addArtikel);
                        
                    }
                    else
                    {
                        Console.WriteLine("Wagen ist voll. Auf zur Kasse...");
                        einkaufDurchlauf = false;
                    }
                    // Preise aufaddieren

                } while (einkaufDurchlauf);

            } while (einkaufsSystem);
        }
    }
}
