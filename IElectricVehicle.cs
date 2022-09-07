
namespace Garage
{
    public interface IElectricVehicle
    {
        int CurrentChargePercentage { get; set; }
        double BatteryKWh { get; }

        void ChargeBattery();
    }
}