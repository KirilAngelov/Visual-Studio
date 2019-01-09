using System;

namespace TruckLogistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCargo = int.Parse(Console.ReadLine());
            double moneyFromCargo = 0.0;
            double CargoInBus = 0.0;
            double CargoInTruck = 0.0;
            double CargoInTrain = 0.0;
            double AveragePrice = 0.0;
            int NumberOfVehicles = 0;
            for (int i = 0; i < numbersOfCargo; i++)
            {
                int weight = int.Parse(Console.ReadLine());
                if (weight <= 3)
                {
                    CargoInBus = CargoInBus + weight;
                    moneyFromCargo = moneyFromCargo + weight * 200;
                }
                else if (weight > 3 && weight <= 11)
                {
                    CargoInTruck = CargoInTruck + weight;
                    moneyFromCargo = moneyFromCargo + weight * 175;
                }
                else
                {
                    CargoInTrain = CargoInTrain + weight;
                    moneyFromCargo = moneyFromCargo + weight * 120;
                }
            }


            double SumOfCargo = CargoInBus + CargoInTrain + CargoInTruck;
            double PercentWithBus = (CargoInBus / SumOfCargo) * 100;
            double PercentWithTruck = (CargoInTruck / SumOfCargo) * 100;
            double PercentWithTrain = (CargoInTrain / SumOfCargo) * 100;
            AveragePrice = moneyFromCargo / SumOfCargo;

            Console.WriteLine(String.Format("{0:0.00}", AveragePrice));
            Console.WriteLine(String.Format("{0:0.00}%", PercentWithBus));
            Console.WriteLine(String.Format("{0:0.00}%", PercentWithTruck));
            Console.WriteLine(String.Format("{0:0.00}%", PercentWithTrain));
            

        }
    }
}
