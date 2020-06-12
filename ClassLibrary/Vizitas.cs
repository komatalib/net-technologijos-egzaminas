using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Vizitas
    {
        public int PatientId { get; set; }
        public string LigosAprasas { get; set; }
        public Skyrius Skyrius { get; set; }
        public int DaktaroId { get; set; }
        public DayOfWeek Diena { get; set; }
        public int EilesNr { get; set; }

    }
}
