using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public int CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; } = 83.2;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($" The {MainColor} {Name} blazes by you. MMmmmmmmmmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} {Name} squeals around a  {direction} turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} {Name} silently stops as if it never moved.");
        }
    }
}