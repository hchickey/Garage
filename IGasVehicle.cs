
namespace Garage
{
    public interface IGasVehicle
    {
        int CurrentTankPercentage { get; set; }
        double FuelCapacity { get; set; }

        void RefuelTank();
    }
}