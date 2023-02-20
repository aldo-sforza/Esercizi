using System;
using System.IO;

namespace Esercizi.Astrazioni.Interfaccia
{
    /*
     * Un interfaccia definisce solo u contratto, i metodi.
     * Si usa un interfaccia quando abbiamo bisogno di un comportamento, i metodi,
     * ma non sappiamo, o non ci interessa, ancora come sarà implementato
     *
     * un interfaccia si definisce con la parola chiave interface
     * per convenzione il nome dell'interfaccia inizia sempre con la i maiuscola I
     */

    public interface ILogger
    {
        /*
         * sui metodi dell'interfaccia non si definisce la visibilità,
         * prendono quella definita dall'interfaccia stessa; in questo caso public
         *
         * i metodi dell'interfaccia definiscono sola la firma.
         * la firma deve finire con ;
         * il corpo non esiste
         */

        void WriteInformation(string message);

        void WriteWarning(string message);

        void WriteError(string message);
    }

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

    /*
  * Questa classe implementa l'interfaccia ILogger decidendo di scrivere su file
  */
    public class FileLogger : ILogger
    {

        private string _path;

        public FileLogger()
        {
            _path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
        }

        public void WriteError(string message)
        {
            File.AppendAllText(_path, $"Error: {message}\r\n");
        }

        public void WriteInformation(string message)
        {
            File.AppendAllText(_path, $"Information: {message}\r\n");
        }

        public void WriteWarning(string message)
        {
            File.AppendAllText(_path, $"Warning: {message}\r\n");
        }
    }
}