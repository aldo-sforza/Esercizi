using Esercizi.Astrazioni.Interfaccia;

namespace Esercizi.Interfacce
{
    internal class ExampleWithInterface
    {
        private readonly ILogger _logger;

        public ExampleWithInterface(ILogger logger)
        {
            _logger =logger;
        }

        public void DoSomethingGood()
        {
            //do something
            _logger.WriteInformation("tuttapposto");
        }

        public void DoSomethingBad()
        {
            //do something
            _logger.WriteError("aiaiaiaia");
        }

        public void DoSomethingWarning()
        {
            _logger.WriteWarning("forse è meglio fare attenzione");
        }
    }
}