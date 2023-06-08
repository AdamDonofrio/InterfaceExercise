using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public Truck() 
        { 
        
        }

        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public double EngineSize { get; set; } = 6;
        public int SeatCount { get; set; } = 4;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F150";

        public bool HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; } = true;

        public double BedSize { get; set; } = 2;


        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} is now driving forword.");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is now driving forword.");
            }
            
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"The {GetType().Name} is now driving backword.");
            }

        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} now in park.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"Can't park untill we change gears");
            }

        }

        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void GetBedSize()
        {
            //BedSize = bedSize;
            Console.WriteLine($"The {GetType().Name} has a bed size of {BedSize}.");
        }


    }
}
