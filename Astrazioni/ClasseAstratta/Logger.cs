using System;
using System.Diagnostics;
using System.IO;

namespace Esercizi.Astrazioni.ClasseAstratta
{
    /*
     * Una classe astratta è caratterizzata dalla parola abstract
     * non può essere istanziata
     * deve per forza essere estesa da un altra classe
     * Di solito, si definisce una classe astratta se c'è almeno un metodo astratto
     *
     */

    public abstract class Logger
    {
        /*
         * i metodi astratti definiscono solo la firma
         * la firma deve finire con ;
         * il corpo non esiste
         */

        public abstract void WriteInformation(string message);

        public abstract void WriteWarning(string message);

        public abstract void WriteError(string message);

        /*
         * una classe astratta può avere un metodo non astratto
         */

        public void WriteDebug(string message)
        {
            Debug.WriteLine(message);
        }
    }

    /*
     * Questa classe estende la classe astratta Logger implementando i metodi astratti, tramite override,
     * decidendo di scrivere sulla finestra di Console
     */

    public class ConsoleLogger : Logger
    {
        public override void WriteInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public override void WriteWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Warning: {message}");
            Console.ResetColor();
        }

        public override void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {message}");
            Console.ResetColor();
        }
    }

    /*
    * Questa classe estende la classe astratta Logger implementando i metodi astratti, tramite override,
    * decidendo di scrivere su file
    */

    public class FileLogger : Logger
    {
        private string _path;

        public FileLogger()
        {
            _path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
        }

        public override void WriteError(string message)
        {
            File.AppendAllText(_path, $"Error: {message}");
        }

        public override void WriteInformation(string message)
        {
            File.AppendAllText(_path, $"Information: {message}");
        }

        public override void WriteWarning(string message)
        {
            File.AppendAllText(_path, $"Warning: {message}");
        }
    }
}