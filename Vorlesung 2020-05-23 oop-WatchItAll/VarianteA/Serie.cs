using System;
using System.Collections.Generic;
using System.Text;

namespace WatchItAll.VarianteA
{
	public class Serie : Medium
	{
		public int Staffel;
		public int Folge; 

		public Serie(string name, int erscheinungsjahr, int rating, int staffel, int folge) 
			: base(name, erscheinungsjahr, rating)
        {
			Staffel = staffel;
			Folge = folge;
        }
	}
}
