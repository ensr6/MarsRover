using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxValues = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            if (maxValues.Count > 2)
            {
                Console.WriteLine($"Enter two values, X and Y.");
            }

            Operation operation = new Operation();

            var firstCoordinate = Console.ReadLine().Trim().Split(' ');

            if (firstCoordinate.Count() == 3)
            {
                operation.X = Convert.ToInt32(firstCoordinate[0]);

                operation.Y = Convert.ToInt32(firstCoordinate[1]);

                operation.Direction = (Direction)Enum.Parse(typeof(Direction), firstCoordinate[2]);

            }
            else
            {
                Console.WriteLine($"Enter three values ​​as X, Y and first direction.");
            }

            var movements = Console.ReadLine().ToUpper();

            try
            {
                operation.Start(movements);

                if (operation.X < 0 || operation.X > maxValues[0] || operation.Y < 0 || operation.Y > maxValues[1])
                {
                    throw new Exception($"You are off the area.");
                }

                Console.WriteLine($"{operation.X} {operation.Y} {operation.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
            Console.ReadLine();
        }
    }
}
