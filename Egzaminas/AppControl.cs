using ClassLibrary;
using System;
using System.Collections.Generic;

namespace Pagrindine

{
    public class App
    {
        public bool State = true;
        readonly PacientProcessor clientProcessor = new PacientProcessor();
        readonly List<Pacientas> pacientas = PacientoData.AddPacientas();
        public int CustomerId { get; set; }
        public int PacientoId { get; private set; }

        public void FirstMessage()
        {

            Console.WriteLine("Pasirinkite paciento id: ");
            int.TryParse(Console.ReadLine(), out int result);
            var PacientoId = result;
            Console.WriteLine(PacientoId);
        }

    }

    internal class PacientProcessor
    {
    }
}

