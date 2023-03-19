using Patterns.Repository;

namespace Games.Model
{
    public class Player : Entity
    {
        public string Nickname { get; set; }
        public int Helath { get; set; } = 100;
    }
}