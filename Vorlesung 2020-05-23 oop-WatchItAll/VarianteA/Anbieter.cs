using System;
using System.Collections.Generic;
using System.Text;

// Variante A: Filme sind den Anbietern zugeordnet
namespace WatchItAll.VarianteA
{
	public class Anbieter
	{
		public string Name;

		public int Rating;

		public string Url;

		public List<Verfuegbarkeit> Filme;

		public List<Verfuegbarkeit> Serien;

		public Anbieter()
		{
			Filme = new List<Verfuegbarkeit>();
			Serien = new List<Verfuegbarkeit>();
		}
	}
}
