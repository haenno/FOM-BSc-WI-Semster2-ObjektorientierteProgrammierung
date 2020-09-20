using System;
using System.Collections.Generic;
using System.Text;

namespace vorl2020_05_22
{
    class AnbieterMedienKatalog
    {
        public AnbieterMedienKatalog()
        {
            
        }
        public int AnbieterImKatalogID; //Hier die ID als Int oder Aufruf der Klasse Anbieter?
        public int MediumImKatalogID;
        public DateTime AufnahmeInKatalog;
        public DateTime EntfallenAusKatalog;
        public String AnbieterMediumUrl;
        public bool AktivesAbo;
        public string Abspielgeraete;
        public float Preis; 
    }
}

