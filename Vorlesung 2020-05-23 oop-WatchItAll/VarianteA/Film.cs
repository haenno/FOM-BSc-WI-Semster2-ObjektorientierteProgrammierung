using System;
using System.Collections.Generic;
using System.Text;

namespace WatchItAll.VarianteA
{
	public class Film : Medium
	{
		public int AnzOskars;

		public Film(string name, int erscheinungsjahr, int rating, int anzOskars) 
			: base(name, erscheinungsjahr, rating)
		{
			AnzOskars = anzOskars;
		}
		
	}
}
