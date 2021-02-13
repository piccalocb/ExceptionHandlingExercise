using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public double EngineSize { get; set; } = 6.0;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Sequoia";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Toyota";
        public string Motto { get; set; } = "Oh What a Feeling!";
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
                Console.WriteLine($"Can't reverse unless we change gears");
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
 