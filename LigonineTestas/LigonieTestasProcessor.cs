using System;
using Xunit;

namespace LigonineTestas
{
    public class PacientInputRequestTests
    {
        private PacientRequest _request;
        private PacientRequestProcessor _processor;

        [Fact]

        public void ShouldReturnPacientRequestValues()
        {
            _request = new PacientRequest
            {
                PacientoId = 1,
                Name = "Denis",
                LastName = "Zamaro"
            };

            _processor = new PacientRequestProcessor();

            PacientResult result = _processor.PtApoinment();

            Assert.NotNull(result);
            Assert.Equal(_request.PacientoId, result.PacientoId);
            Assert.Equal(_request.Name, result.Name);
            Assert.Equal(_request.LastName, result.LastName);
        }

        [Fact]

        public void CheckPacientRequestIsNull()
        {
            _processor = new PacientRequestProcessor();
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => _processor.PtApoinment());

            Assert.Equal("request", exception.ParamName);
        }
    }

    internal class PacientRequestProcessor
    {
        public PacientRequestProcessor()
        {
        }

        internal void PtApoinment()
        {
            throw new NotImplementedException();
        }
    }
}
