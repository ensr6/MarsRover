using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Operation : Movements
    {

        public void Start(string movements)
        {
            foreach (var move in movements)
            {
                switch (move)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Advance();
                        break;
                    default:
                        break;
                }
            }
        }
        public override void Advance()
        {
            switch (Direction)
            {
                case Direction.E:
                    this.X += 1;
                    break;
                case Direction.W:
                    this.X -= 1;
                    break;
                case Direction.N:
                    this.Y += 1;
                    break;
                case Direction.S:
                    this.Y -= 1;
                    break;
                default:
                    break;
            }
        }


        public override void TurnLeft()
        {
            switch (Direction)
            {
                case Direction.E:
                    Direction = Direction.N;
                    break;
                case Direction.W:
                    Direction = Direction.S;
                    break;
                case Direction.N:
                    Direction = Direction.W;
                    break;
                case Direction.S:
                    Direction = Direction.E;
                    break;
                default:
                    break;
            }
        }

        public override void TurnRight()
        {
            switch (Direction)
            {
                case Direction.E:
                    Direction = Direction.S;
                    break;
                case Direction.W:
                    Direction = Direction.N;
                    break;
                case Direction.N:
                    Direction = Direction.E;
                    break;
                case Direction.S:
                    Direction = Direction.W;
                    break;
                default:
                    break;
            }
        }

    }
}
