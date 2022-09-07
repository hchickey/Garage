using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");

            Zero fxs = new Zero();
            fxs.MainColor = "Midnight Blue";
            fxs.Name = "Zero";
            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            Console.WriteLine("------------------------");

            Zero fx = new Zero();
            fxs.MainColor = "Black";
            fxs.Name = "Zero";
            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            Console.WriteLine("------------------------");


            Tesla modelS = new Tesla();
            modelS.MainColor = "Burgandy";
            modelS.Name = "Tesla";
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();

            Console.WriteLine("------------------------");

            Cessna mx410 = new Cessna();
            mx410.MainColor = "White";
            mx410.Name = "Cessna";
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();

            Console.WriteLine("------------------------");

            Ram ram2010 = new Ram();
            ram2010.MainColor = "Silver";
            ram2010.Name = "Ram";
            ram2010.Drive();
            ram2010.Turn("right");
            ram2010.Stop();

            Console.WriteLine("------------------------");

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                fx, fxs, modelS
            };

            fx.CurrentChargePercentage = 60;
            fxs.CurrentChargePercentage = 70;
            modelS.CurrentChargePercentage = 80;


            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                ram, cessna150
            };

            ram.CurrentTankPercentage = 40;
            cessna150.CurrentTankPercentage = 55;

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}%");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}%");
            }

        }
    }

}