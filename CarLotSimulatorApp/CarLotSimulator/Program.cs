using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            var lot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var sahbasCar = new Car();
            sahbasCar.Make = "Ford";
            sahbasCar.Model = "Focus";
            sahbasCar.Year = 2013;
            sahbasCar.EngineNoise = "vroom";
            sahbasCar.HonkNoise = "beep";
            sahbasCar.IsDrivable = true;

            lot.Cars.Add(sahbasCar);
            var masonsCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDrivable = false
            };
            lot.Cars.Add(masonsCar);
            var brettsCar = new Car(2013, "Honda", "Civic", "vroooom", "beeeep", true);
            lot.Cars.Add(brettsCar);
            sahbasCar.MakeEngineNoise(sahbasCar.EngineNoise);
            masonsCar.MakeEngineNoise(masonsCar.EngineNoise);
            brettsCar.MakeEngineNoise(brettsCar.EngineNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
