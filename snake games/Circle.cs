using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_games
{
    // Represent for a Snake and food
    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Circle()
        {
        }
        public Circle(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
