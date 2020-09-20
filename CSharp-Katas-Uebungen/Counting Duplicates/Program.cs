using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


namespace Counting_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ergebnis = Kata.DuplicateCount("bbbbaaa");


            Console.WriteLine("Hello World!" + Ergebnis);
        }
    }
}



  
public class Kata
{
    public static int DuplicateCount(string str)
    {
        int AnzahlDoppelte = 0;
        string ArbeitsString = str.ToLower();
        string GepruefteZeichen = "";

        foreach (char Zeichen in ArbeitsString) // Jedes Zeichen des übergebenen Strings durchgehen
        {
            if (!GepruefteZeichen.Contains(Zeichen)) // Nur noch die überprüfen die noch nicht geprüft wurden
            {
                int SuchZaehler = 0;
                for (int i = 0; i < ArbeitsString.Length; i++)  // Und dann die Anzahl des Zeichens im String zählern
                {
                    if (ArbeitsString[i] == Zeichen)
                    {
                        SuchZaehler++;
                    }
                }
                if (SuchZaehler >= 2) // Falls mehr als oder gleich 2 (also doppelt) Ausgabezähler erhöhen
                {
                    AnzahlDoppelte++;
                }
    
            }
            GepruefteZeichen = GepruefteZeichen + Zeichen;
        }

        return AnzahlDoppelte;
    }
}

 