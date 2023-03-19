using Esercizi.Astrazioni.Interfaccia;

namespace Loggers
{
    internal class ExampleWithInterface
    {
        private readonly ILogger _logger;

        public ExampleWithInterface(ILogger logger)
        {
            _logger = logger;
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

    internal class ExampleMultiLogger
    {
        private readonly IEnumerable<ILogger> _loggers;

        public ExampleMultiLogger(IEnumerable<ILogger> loggers)
        {
            _loggers = loggers;
        }

        public void DoSomethingGood()
        {
            //do something
            foreach (var logger in _loggers)
            {
                logger.WriteInformation("tuttapost");
            }
        }

        public void DoSomethingBad()
        {
            //do something
            foreach (var logger in _loggers)
                logger.WriteError("aiaiaiaia");
        }

        public void DoSomethingWarning()
        {
            foreach (var logger in _loggers)
                logger.WriteWarning("forse è meglio fare attenzione");
        }
    }
}