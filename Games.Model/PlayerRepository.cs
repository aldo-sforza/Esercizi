using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Model
{
    public class PlayerRepository
        : IRepository<Player>, IUnitOfWork
    {
        private const string FILE_NAME = "players.txt";
        private readonly Dictionary<string, Player> _players = new();

        public PlayerRepository() {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = System.IO.Path.Combine(folder, FILE_NAME);
            if (File.Exists(fullPath))
            {
                var content = File.ReadAllText(fullPath);
                _players = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, Player>>(content);
            }
        }
        public void Create(string id)
        {
            var player = new Player(id);
            _players.Add(player.Id,player);
        }

        public void Delete(string id)
        {
            _players.Remove(id);
        }

        public bool Exists(string id)
        {
            return _players.ContainsKey(id);
        }

        public Player Load(string id)
        {
            if (_players.ContainsKey(id))
                return _players[id];

            return null;
        }

        public void SaveChanges()
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = System.IO.Path.Combine(folder, FILE_NAME);
            var content = System.Text.Json.JsonSerializer.Serialize(_players);
            System.IO.File.WriteAllText(fullPath, content);
        }
    }
}
