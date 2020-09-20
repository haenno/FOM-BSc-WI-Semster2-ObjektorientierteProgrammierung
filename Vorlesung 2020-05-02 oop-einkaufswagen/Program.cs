using System;
using System.Collections.Generic;

namespace oop_einkaufswagen
{
    // Artikel die in den Wagen gelegt werden: Name, Nummer, Einzelpreis
    // Einkaufswagen mit max. Anzahl Artikel und Gesamtpreis des Einkaufs
    class Einkaufswagen 
    {
        public int MaximaleAnzahlArtikel;
        public float Gesamtpreis()
        {
            float gp = 0.0f;
            foreach( Artikel a in AktuellerInhalt)
            {
                gp += a.Einzelpreis*a.Anzahl;
            }
            return gp; 
        }
        public int  AktuelleAnzahlArtikel()
        {
            int anzArt = 0;
            foreach(Artikel a in AktuellerInhalt)
            { 
                anzArt += a.Anzahl;
            }
            return anzArt;
        } 
        public List<Artikel> AktuellerInhalt; 
    }

    class Artikel
    {
        public string Name;
        public int Nummer;
        public int Anzahl;
        public float Einzelpreis;
        
    }
    class Program
    {
        static Artikel ArtikelVonKonsole()
        {
            Console.WriteLine("Was möchtest du in deinen Wagen legen?");
            Artikel a = new Artikel();

            Console.Write("Bitte Artikelname eingeben:");
            a.Name = Console.ReadLine();

            Console.Write("Bitte Artikelnummer eingeben:");
            a.Nummer= Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte Artikelpreis eingeben:");
            a.Einzelpreis = Convert.ToSingle(Console.ReadLine());

            Console.Write("Bitte Anzahl eingeben:");
            a.Anzahl = Convert.ToInt32(Console.ReadLine());

            return a;
        }
        static void Main(string[] args)
        {
            bool kaufeEin = true;
            while (kaufeEin)
            {
                Console.WriteLine("Viel Spaß beim Einkauf!");

                Einkaufswagen wagen = new Einkaufswagen();
                wagen.MaximaleAnzahlArtikel = 10;
                wagen.AktuellerInhalt = new List<Artikel>();

                bool einkaufen =true;

                while (einkaufen)
                {
                    Artikel neuInWagen = ArtikelVonKonsole();
                    wagen.AktuellerInhalt.Add(neuInWagen);

                    if (wagen.AktuelleAnzahlArtikel() >= wagen.MaximaleAnzahlArtikel)
                    {
                        Console.WriteLine("Wagen voll! Ab zur Kasse...");
                        einkaufen = false;
                    } 
                    else
                    {
                        Console.Write("Weiteren Artikel hinzufügen?");
                        switch(Console.ReadLine())
                        {
                            case "ja":
                            case "yes":
                            case "j":
                            case "J":
                            case "Ja":
                            case "y":
                            case "enjo":
                            case "heeh":
                            break;
                            default:
                                einkaufen = false;
                            break;
                        }

                    }
                }
                Console.WriteLine("...an der Kasse:");
                Console.WriteLine("Der gesamte Einkaufswagen kostet: " + wagen.Gesamtpreis() +" Euro!");


                // gesamtsummen ausgeben
                Console.WriteLine("Fin.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
