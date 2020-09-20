using System;
using System.Collections.Generic;

namespace Termin02
{
	class Klausurtermin
	{
		public DateTime Termin;

		public TimeSpan Dauer;

		public string NameDesModuls;

		public List<Aufgabenstellung> Aufgabenstellungen;

		public List<Hilfsmittel> ErlaubteHilfsmittel;

		public List<Klausur> GeschriebeneKlausuren;
	}

	class Klausur
	{
		public Personendatensatz Student;

		public List<Lösung> Lösungen;
	}

	class Hausarbeit
	{
		public Personendatensatz Student;

		public string Titel;

		public string Text;
	}

	class Personendatensatz
	{
		public string Vorname;

		public string Nachname;

		public int Matrikelnummer;
	}

	class Aufgabenstellung
	{
		public string Titel;

		public string Text;

		public int Punkte;
	}

	class Lösung
	{
		public string Lösungstext;

		public int ErzieltePunkte;
	}

	class Hilfsmittel
	{
		public string Name;

		public string Beschreibung;
	}





	class Program
	{
		static Aufgabenstellung ErzeugeAufgabenstellung()
		{
			Aufgabenstellung aS = new Aufgabenstellung();

			Console.Write("Bitte Titel eingeben: ");
			aS.Titel = Console.ReadLine();

			Console.Write("Bitte Text eingeben: ");
			aS.Text = Console.ReadLine();

			Console.Write("Bitte max. Punkte eingeben: ");
			aS.Punkte = Convert.ToInt32(Console.ReadLine());

			return aS;
		}

		static void Main(string[] args)
		{
			// Klausurtermin erstellen
			Klausurtermin ersterTermin = new Klausurtermin();
			ersterTermin.NameDesModuls = "Konzepte des objektorientierten Programmierens";
			ersterTermin.Termin = new DateTime(2020, 7, 11, 10, 30, 0); // 11.7.  10:30 - 12:00
			ersterTermin.Dauer = new TimeSpan(0, 1, 30, 0);

			// Aufgaben erstellen
			Console.Write("Wie viele Aufgaben soll es geben? ");
			int anzahlAufgaben = Convert.ToInt32(Console.ReadLine());

			ersterTermin.Aufgabenstellungen = new List<Aufgabenstellung>();
			for (int i = 0; i < anzahlAufgaben; i++)
			{
				ersterTermin.Aufgabenstellungen.Add(ErzeugeAufgabenstellung());
			}

			// Hilfsmittel eintragen
			/*
			Hilfsmittel hilfsmittel = new Hilfsmittel();
			hilfsmittel.Name = "Papier";
			hilfsmittel.Beschreibung = "Eine Seite DIN A4 Papier, kariert";

			ersterTermin.ErlaubteHilfsmittel.Add(hilfsmittel);
			*/

			// Der große Tag
			// Jemand schreibt die Klausur
			/*
			Personendatensatz derStudent = new Personendatensatz();
			derStudent.Vorname = "Max";
			derStudent.Nachname = "Mustermann";
			derStudent.Matrikelnummer = 123456;

			Klausur klausurVonMaxMustermann = new Klausur();
			klausurVonMaxMustermann.Student = derStudent;

			Lösung lösungAufgabeEinsMM = new Lösung();
			lösungAufgabeEinsMM.Lösungstext = "C# ist eine objektorientierte Sprache.";

			klausurVonMaxMustermann.Lösungen.Add(lösungAufgabeEinsMM);

			ersterTermin.GeschriebeneKlausuren.Add(klausurVonMaxMustermann);

			// Tag der Korrektur
			*/
		}
	}
}
