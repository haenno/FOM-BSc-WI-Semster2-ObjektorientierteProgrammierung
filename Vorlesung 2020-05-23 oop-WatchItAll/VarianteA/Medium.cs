using System;
using System.Collections.Generic;
using System.Text;

namespace WatchItAll.VarianteA
{
    public class Medium
    {
        public string Name;

        public int Erscheinungsjahr;

        public int Rating;
        public Medium(string name, int erscheinungsjahr, int rating)
        {
            Name = name;
            Erscheinungsjahr = erscheinungsjahr;
            Rating = rating;
        }

    }
}
