using System.Collections.Generic;

namespace ClassLibrary
{
    public class PacientoData
    {
        public static List<Pacientas> pacientas = new List<Pacientas>();
        public static List<Pacientas> AddPacientas()
        {
            Pacientas pacientas1 = new Pacientas()
            {
                PacientoId = 1,
                Name = "Denis",
                LastName = "Zamaro"
            };
            Pacientas pacientas2 = new Pacientas()
            {
                PacientoId = 2,
                Name = "Tadas",
                LastName = "Bananas"
            };
            Pacientas pacientas3 = new Pacientas()
            {
                PacientoId = 3,
                Name = "Ieva",
                LastName = "Tataite"
            };
            pacientas.Add(pacientas1);
            pacientas.Add(pacientas2);
            pacientas.Add(pacientas3);
            return pacientas;
        }
    }
}
