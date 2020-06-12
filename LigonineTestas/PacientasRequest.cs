using System;

namespace LigonineTestas
{
    public class PacientRequest
    {
        public int PacientoId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public void ReiksmesTikrumas() => throw new NotImplementedException();
    }
}