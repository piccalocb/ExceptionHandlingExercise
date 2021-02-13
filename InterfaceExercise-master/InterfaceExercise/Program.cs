using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    public class Program
    {
       static void Main(string[] args)
        {
            var car = new Car();

            var truck = new Truck();

            var SUV = new SUV();

            var vehicles = new List<IVehicle>() { Car, Truck, SUV };
            
            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.HasChangedGears(true);
                vehicle.Reverse();
            }
        
        }
    }
}
