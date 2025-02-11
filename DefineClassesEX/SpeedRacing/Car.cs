using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        public Car (string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public string Model {  get; set; }
        public double FuelAmount {  get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance {  get; set; }

        public bool Drive(double distanceKM)
        {
            double neededFuel = distanceKM * this.FuelConsumptionPerKilometer;

            if (neededFuel > FuelAmount)
            {
                return false;
            }
            else
            {
                FuelAmount -= neededFuel;
                TravelledDistance += distanceKM;
                return true;
            }
        }
    }
}
