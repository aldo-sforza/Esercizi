using Patterns.Repository;

namespace Games.Model
{
    public class Round : Entity
    {
        public int Number { get; set; }
        public TimeSpan Duration { get; set; } = TimeSpan.FromMinutes(0);

        public Player Offender { get; set; }
        public Player Defender { get; set; }

        public Round(string id)
            :base(id) 
        {
            
        }
    }
}