using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle// Propellor light aircraft
    {
        public int CurrentTankPercentage { get; set; }
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($" The {MainColor} {Name} flashes by you like a hurricane. Zzzzzooooommmm!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} {Name} rolls down the runway from a mile and stops.");
        }
    }
}