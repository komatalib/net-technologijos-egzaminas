using System.Collections.Generic;

namespace ClassLibrary
{
    public class VizitoData
    {
        public static List<Vizitas> AddVizitas()
        {
            List<Vizitas> Vizitas = new List<Vizitas>();
            Vizitas vizitas1 = new Vizitas()
            {
                PatientId = 1,
                LigosAprasas = "Apendicitas",
                Skyrius = new SkyriusData().SelectCategory("Chirurgija"),
                Diena = System.DayOfWeek.Monday,
                DaktaroId = 2,
                EilesNr = 1
            };
            Vizitas vizitas2 = new Vizitas()
            {
                PatientId = 50,
                LigosAprasas = "Sloga",
                Skyrius = new SkyriusData().SelectCategory("Pediatrija"),
                Diena = System.DayOfWeek.Friday,
                DaktaroId = 3,
                EilesNr = 2
            };
            Vizitas vizitas3 = new Vizitas()
            {
                PatientId = 40,
                LigosAprasas = "Ranko Luzis",
                Skyrius = new SkyriusData().SelectCategory("Chirurgija"),
                Diena = System.DayOfWeek.Tuesday,
                DaktaroId = 2,
                EilesNr = 3
            };
            Vizitas vizitas4 = new Vizitas()
            {
                PatientId = 20,
                LigosAprasas = "Kariesas",
                Skyrius = new SkyriusData().SelectCategory("Odontologija"),
                Diena = System.DayOfWeek.Monday,
                DaktaroId = 1,
                EilesNr = 4
            };
            Vizitas.Add(vizitas1);
            Vizitas.Add(vizitas2);
            Vizitas.Add(vizitas3);
            Vizitas.Add(vizitas4);
            return Vizitas;
        }
    }
}
