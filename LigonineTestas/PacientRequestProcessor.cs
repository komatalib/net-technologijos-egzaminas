using System;

namespace LigonineTestas
{
    public class LigonietestasProcessor
    {

        public PacientResult PtApoinment(PacientRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return new PacientResult
            {
                PacientoId = request.PacientoId,
                Name = request.Name,
                LastName = request.LastName
            };


        }

        public PacientResult PtApoinment()
        {
            throw new NotImplementedException();
        }
    }
}