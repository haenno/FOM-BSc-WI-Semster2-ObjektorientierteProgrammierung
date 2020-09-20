using System;
using System.Collections.Generic;

namespace vorl2020_05_22
{
    /* Aufgabe aus Vorlesung vom 22.05.2020: Watch it all
     *  Ziel ist es, eine Datenbank für Streaming-Angebote zu entwickeln.Dabei möchte der 
     * fiktive Kunde, dass die Kataloge beliebiger Anbieter verwaltet werden können.
     * Jeder Katalog kann eine beliebige Reihe an Serien und Filmen beinhalten. 
     * Zusätzlich gibt es eine Watch-List, in die Filme aus allen vorhandenen 
     * Katalogen übergreifend eingetragen werden können.1.Bestimmen Sie die Ihrer 
     * Meinung nach notwendigen Klassen.2.Schreiben Sie für jede in 1. gefundene 
     * Klasse eine Code-Datei mit möglichen Attributen. Schreiben Sie noch keine 
     * Methoden!3.Wir vergleichendie Ergebnisse von 1. und2. 
     */


    /*Entwurfsteil zu 1:
     * 
     * Stichwörter / Essenz:
     *  - Datenbank zu Streaming-Angeboten
     *    - Kataloge beliebiger Anbieter
     *    - Jeder Katalog mit beliebiger Reihe an 
     *       - Filmen und
     *       - Serien 
     *       
     *  - Zusätzlich dazu Watch-List: 
     *    - mit Möglichkeit Filmen (und Serien?) aus allen Katalogen übergreifend einzutragen
     * 
     * 
     * Dazu notwendige Klassen: 
     *  - Anbieter
     *  - Filme
     *  - Serien
     *    - Staffeln
     *    - Folgen
     *  - Watch-List
     * 
     * Details der Klassen: 
     *  - Anbieter:
     *   - Anbitername
     *   - Zugeordente Filme
     *   - Zugeordente Serien (Detail: Staffeln später)
     *   - Weitere Details später: Abo Status, Preise, Adressen, nutzbare Abspielgeräte, ...
     *  - Filme
     *   - Filmname
     *   - Film ID
     *   - Weitere Details später: Erscheinungsjahr, Laufzeit in Minuten, Hauptrollen, ...
     *  - Serien
     *   - Serienname
     *   - zugeordente Staffeln (Liste mit Bezug auf eindeutige Staffel ID)
     *  - Staffeln
     *   - Staffel ID
     *   - Staffelnummer 
     *   - zugeordnete Folgen (Liste mit Bezug auf eindeutige Folgen ID)
     *  - Folgen
     *   - Folgen ID 
     *   - Folgennummer
     *   - Folgenname 
     *   - Weitere Details später: Erscheinungsjahr, Laufzeit in Minuten, ...
     *  (TODO später: Anpassung an DB Struktur, 1. / 2. Normalisierung)
     *  
     *  
     *  **UPDATE**
     *  
     *  - Klassen Filme, Serien, Staffeln und Folgen zusammenfassen:
     *    - Neue Klasse "Medium" mit Typ int "1=Film, 2=Serie"
     *    - Optionale Felder bei Typ 2=Serie: int Staffel, int Folge, string Serienname (Serienname ggfls. Normalisieren)
     *  - Watchlist
     *   - ID des Medium <int>
     *   - Datum/Uhrzeit Aufnahme in Watchlist 
     *   - Datum/Uhrzeit gesehen 
     *   - Weitere Details später: Anzahl gesehen, Stelle Abbruch letztes abspielen, ...
     *  - AnbieterKatalog  (und damit MedienID aus Anbeiter nehmen)
     *   - AnbieterID <int>
     *   - MedienID <int>
     *   - MedienAnbieterURL <string>
     *   - Optional: AufnahmeInKatalog <date>, EntfallenAusKatalog <date>
     *    --> Damit sind die Klassen Anbieter und Medium nur noch Datenhaltendene Klassen!
     *   
     *    
     */

        
    class Program
{
    static void Main(string[] args)
    {
            Anbieter testAnbieter = new Anbieter();
            testAnbieter.AnbieterName = "Netflix";

            Console.WriteLine("Hello World!" + testAnbieter.AnbieterName);
           
    }
}
}
