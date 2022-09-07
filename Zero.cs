using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public int CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; } = 66.2;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }
}