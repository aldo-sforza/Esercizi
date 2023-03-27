using Patterns.Repository;

namespace Games.Model
{
    public class RoundRepository
        : IRepository<Round>, IUnitOfWork
    {
        private const string FILE_NAME = "rounds.txt";
        private readonly Dictionary<string, Round> _rounds = new();

        public RoundRepository()
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = System.IO.Path.Combine(folder, FILE_NAME);
            if (File.Exists(fullPath))
            {
                var content = File.ReadAllText(fullPath);
                _rounds = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, Round>>(content);
            }
        }

        public void Create(string id)
        {
            var round = new Round(id);
            _rounds.Add(round.Id, round);
        }

        public void Delete(string id)
            => _rounds.Remove(id);

        public bool Exists(string id)
            => _rounds.ContainsKey(id);

        public Round Load(string id)
        {
            if (_rounds.ContainsKey(id))
                return _rounds[id];
            return null;
        }

        public void SaveChanges()
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = System.IO.Path.Combine(folder, FILE_NAME);
            var content = System.Text.Json.JsonSerializer.Serialize(_rounds);
            System.IO.File.WriteAllText(fullPath, content);
        }
    }
}