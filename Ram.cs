using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public int CurrentTankPercentage { get; set; }
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {Name} growls by you. Rrrrrruuummmmbbble!");
        }

    }
}