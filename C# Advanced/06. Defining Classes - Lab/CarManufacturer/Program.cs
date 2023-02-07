using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public static class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new List<Tire[]>();
            string command;
            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] splits = command.Split();
                var firstTire = new Tire(int.Parse(splits[0]), double.Parse(splits[1]));
                var secondTire = new Tire(int.Parse(splits[2]), double.Parse(splits[3]));
                var thirdTire = new Tire(int.Parse(splits[4]), double.Parse(splits[5]));
                var fourthTire = new Tire(int.Parse(splits[6]), double.Parse(splits[7]));
                tires.Add(new Tire[] { firstTire, secondTire, thirdTire, fourthTire });
            }

            var engines = new List<Engine>();
            string engineInput;
            while ((engineInput = Console.ReadLine()) != "Engines done")
            {
                string[] splits = engineInput.Split();
                int currentHorsePower = int.Parse(splits[0]);
                double currentCubicCapacity = double.Parse(splits[1]);
                var engine = new Engine(currentHorsePower, currentCubicCapacity);
                engines.Add(engine);
            }

            var cars = new List<Car>();

            string input;
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] splits = input.Split();
                string make = splits[0];
                string model = splits[1];
                int year = int.Parse(splits[2]);
                double fuelQuantity = double.Parse(splits[3]);
                double fuelConsimption = double.Parse(splits[4]);
                var engine = engines[int.Parse(splits[5])];
                var tire = tires[int.Parse(splits[6])];
                Car car = new Car(make, model, year, fuelQuantity, fuelConsimption, engine, tire);
                cars.Add(car);
            }

            cars = cars.Where(y => y.Year >= 2017 && y.Engine.HorsePower >= 330 && y.Tires.Sum(y => y.Pressure) >= 9 && y.Tires.Sum(y => y.Pressure) <= 10).ToList();

            foreach (var car in cars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI()); ;
            }
        }
    }
}
