using Patterns.Repository;

namespace Games.Model
{
    public class Player : Entity
    {
        public string Nickname { get; set; }
        public int Health { get; set; } = 100;

        public Player(string id)
            :base(id)
        {

        }
    }
}