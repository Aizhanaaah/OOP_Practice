using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    enum Position
    {
        point_guard, shooting_guard, small_forward, power_forward, center
    }
    internal class Player
    {
        public string Name { get; set; }
        public Position P { get; set; }

        public Player(string name, Position p)
        {
            Name = name;
            P = p;
        }

    }
}
