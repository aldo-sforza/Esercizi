namespace Esercizi.Astrazioni.Interfaccia
{
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