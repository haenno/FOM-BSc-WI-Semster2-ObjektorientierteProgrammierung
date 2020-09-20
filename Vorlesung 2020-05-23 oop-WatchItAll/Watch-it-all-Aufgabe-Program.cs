using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ExceptionServices;
using WatchItAll.VarianteA;

namespace WatchItAll
{
	class Program
	{
		static void Main(string[] args)
		{
			// Variante A zur Übung 23.05.2020
			// 1 Implementieren Sie in Program.cs das Hinzufügen eines Anbieters (z.B. Netflix o. Amazon Prime) durch den Benutzer.
			// 2 Implementieren Sie weiterhin das Hinzufügen eines Films und einer Serie zu dem in 1. implementierten Anbieter, ebenfalls durch den Benutzer

			List<Anbieter> AnbieterDB = new List<Anbieter>();
			List<Film> FilmDB = new List<Film>();

			bool hauptschleife = true;
			while (hauptschleife)
            {
				Console.WriteLine("Was möchten Sie machen? \n\n  1 für Anbiter hinzuügen\n  2 für Film hinzufügen \n  3 für Programmende\n  4 Dem Anbieter einen Film zuordnen");
				switch(Console.ReadLine())
                {
					case "1":
						Anbieter neuerAnbieter = new Anbieter();

						Console.Write("Bitte geben Sie den Namen des neuen Anbieters ein:                    ");
						neuerAnbieter.Name = Console.ReadLine();

						Console.Write("Bitte geben Sie die URL des neuen Anbieters ein:                      ");
						neuerAnbieter.Url = Console.ReadLine();

						Console.Write("Bitte geben Sie die Bewertung (Schulnoten) des neuen Anbieters ein:   ");
						neuerAnbieter.Rating = Convert.ToInt32(Console.ReadLine());

						AnbieterDB.Add(neuerAnbieter);
						Console.WriteLine("\n\nDer Anbieter wurde hinzugefügt. " + AnbieterDB.Count + " Anbieter sind in der DB.\n\n");
						
						break;

					case "2":
						Film neuerFilm = new Film();

						Console.Write("Bitte geben Sie den Namen des neuen Films ein:                    ");
						neuerFilm.Name = Console.ReadLine();

						Console.Write("Bitte geben Sie das Erscheinungsjahr des neuen Films ein:         ");
						neuerFilm.Rating = Convert.ToInt32(Console.ReadLine());

						Console.Write("Bitte geben Sie die Bewertung (Schulnoten) des neuen Films ein:   ");
						neuerFilm.Rating = Convert.ToInt32(Console.ReadLine());

						FilmDB.Add(neuerFilm);
						Console.WriteLine("\n\nDer Film wurde hinzugefügt. " + FilmDB.Count + " Filme sind in der DB.\n\n");

						break;

					case "3":
						hauptschleife = false;
						break;

					case "4":
						Verfuegbarkeit neueVerfuegbarket = new Verfuegbarkeit();
						
						Console.WriteLine("\n\nWir gehen jeden Anbieter durch...");

						foreach (Anbieter Anbieter in AnbieterDB)
						{
							Console.WriteLine("Soll dem Anbieter " + Anbieter.Name + " ein Film hinzugefügt werden? (j/n)");
							switch (Console.ReadLine())
                            {
								case "j":

									Console.WriteLine("\n\nWelcher Film soll hinzugefügt werden? Wir gehen die Filme durch...");
									foreach (Film Filme in FilmDB)
									{
										Console.WriteLine("Soll der Film " +  Filme.Name + " hinzugefügt werden? (j/n)");
										switch(Console.ReadLine())
                                        {
											case "j":
												neueVerfuegbarket.DerFilm = Filme; // Tusch!?
												//TODO hier: Weitere Metadaten abfragen + einfügen

												Anbieter.Filme.Add(neueVerfuegbarket);
												break;

											default:
												break;
                                        }
									}
									break;

								default: 
									break;
                            }

						}



						break;

					default:
						Console.WriteLine("\nUngültige Eingabe. Bitte wiederholen...");
						break;
                }
			}
			Console.WriteLine("\nProgrammende erreicht. Ausgabe Listen Anbieter und Filme...\n");
			
			Console.WriteLine("\nAnbieter...");
			foreach(Anbieter Anbieter in AnbieterDB)
            {
				Console.WriteLine(Anbieter.Name);
            }

			Console.WriteLine("\nFilme...");
			foreach (Film Filme in FilmDB)
			{
				Console.WriteLine(Filme.Name);
			}



		}
	}
}
