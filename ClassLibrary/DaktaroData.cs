using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class DaktaroData
    {
        public static List<Daktaras> daktaras = new List<Daktaras>();
        public static List<Daktaras> AddDaktaras()
        {
            Daktaras daktaras1 = new Daktaras()
            {
                DaktaroId = 1,
                Name = "Denis",
                LastName = "Zamaro"
            };
            Daktaras daktaras2 = new Daktaras()
            {
                DaktaroId = 2,
                Name = "Denis",
                LastName = "Zamaro"
            };
            Daktaras daktaras3 = new Daktaras()
            {
                DaktaroId = 3,
                Name = "Denis",
                LastName = "Zamaro"
            };
            daktaras.Add(daktaras1);
            daktaras.Add(daktaras2);
            daktaras.Add(daktaras3);
            return daktaras;
        }
    }
}
