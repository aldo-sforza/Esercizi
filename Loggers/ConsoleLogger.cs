namespace Esercizi.Astrazioni.Interfaccia
{
    /*
   * Questa classe implementa l'interfaccia ILogger decidendo di scrivere sulla finestra di Console
   */

    public class ConsoleLogger : ILogger
    {
        public void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {message}");
            Console.ResetColor();
        }

        public void WriteInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void WriteWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Warning: {message}");
            Console.ResetColor();
        }
    }
}