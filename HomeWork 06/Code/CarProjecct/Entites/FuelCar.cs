using Entites.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites
{
    public class FuelCar : Car
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }

        public FuelCar( int fuelCapacity, int currentFuel)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
        }

        public FuelCar(string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engineType, int v1, int v2) : base(brand, model, doors, topSpeed, consumption, engineType)
        {
        }
    }
}
