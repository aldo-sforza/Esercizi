using Esercizi.Patterns;

namespace Esercizi.Models
{
    public class Player : Entity
    {
        public string Nickname { get; set; }
        public int Helath { get; set; } = 100;
    }
}