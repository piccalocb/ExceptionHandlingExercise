using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public double EngineSize { get; set; } = 3.25;
        public string Make { get; set; } = "BMW";
        public string Model { get; set; } = "325i";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "BMW";
        public string Motto { get; set; } = "The Ultimate Driving Machine!";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving forward. . .");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} Can't reverse unless we change gears");
                HasChangedGears = false;
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now parking. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} Can't park unless we change gears");
                HasChangedGears = false;
            }
        }
    }
}

        
    
