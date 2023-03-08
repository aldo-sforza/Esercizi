using Esercizi.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.Models
{
    public class Round:Entity
    {
        public int Number { get; set; }
        public TimeSpan Duration { get; set; } = TimeSpan.FromMinutes(0);

        public Player Offender { get; set; }
        public Player Defender { get; set; }
    }
}
