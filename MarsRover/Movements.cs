using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public abstract class Movements
    {
        public Movements()
        {
            X = 0;
            Y = 0;
            Direction = Direction.N;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
        public abstract void Advance();
        public abstract void TurnRight();
        public abstract void TurnLeft();

    }
}
