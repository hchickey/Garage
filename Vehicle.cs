using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public string Name { get; set; }




        public virtual void Drive()
        {
            Console.WriteLine($" The {MainColor} {Name} zips by you. Yeeeeeooowww!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop!");
        }

    }
}