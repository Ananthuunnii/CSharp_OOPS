using System;

namespace vehicalConfigarationSystem
{
    abstract class Vehicle
    {
        public string FuelType { get; set; }
        public int Capacity { get; set; }


        public abstract void Start();
        public abstract void Engin();

        public void ShowDetails()
        {
            Console.WriteLine($"the fule type is {FuelType}");
            Console.WriteLine($"the capacity is {Capacity} passengers");
        }

    }
    class car : Vehicle
    {
        // abstract methods while implementing we need to give the override keyword
        public override void Start()
        {
            Console.WriteLine($" Car is starting with key ignision");
        }
        public override void Engin()
        {
            Console.WriteLine($"car engine is a 4-cylinder petrol engine");
        }

    }
    class bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine($" Bike is starting with key ignision");
        }
        public override void Engin()
        {
            Console.WriteLine($"Bike engine is 2-stroke petrol engine");
        }


    }
    class Program
    {
        static void Main()
        {
            Vehicle Car = new car();

            Car.FuelType = "petrol";
            Car.Capacity = 5;

            Car.Start();
            Car.Engin();

            Console.WriteLine("-------------------------------");

            Vehicle bike = new bike();
            bike.FuelType = "petrol";
            bike.Capacity = 2;

            bike.Start();
            bike.Engin();
        }
    }
}
