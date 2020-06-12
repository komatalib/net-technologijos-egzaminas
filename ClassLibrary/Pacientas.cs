using System.Collections.Generic;

namespace ClassLibrary
{
    public class Pacientas
    {
        internal int PatientId;
        internal IEnumerable<object> Vizitas;

        public int PacientoId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
