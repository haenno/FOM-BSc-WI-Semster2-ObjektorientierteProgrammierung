using System;
using System.Collections.Generic;
using System.Text;

namespace vorl2020_05_22
{
    class Medium
    {
        public Medium()
        {

        }

        public int MediumID;
        public string MediumName;
        public string MediumLaufzeitMinuten;

        public int MediumArt; // 1=Film, 2=Serie  //*update:IDEE: Art<1=Film, sonst ID=SerienID (Verweis ID auf Seriendaten (Name, Staffel, Folge)

        //Daten für MedienArt = 2 -> Serie
        public int MeidumSerieName;
        public int MediumSerieStaffel;
        public int MediumSerieFolge;


    }
}
