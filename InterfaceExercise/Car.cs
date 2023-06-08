using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public Car() 
        { 
        
        }

        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public double EngineSize { get; set; } = 4.6;
        public int SeatCount { get; set; } = 4;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";

        public bool HasChangedGears { get; set; }

        public bool HasTrunk { get; set; } = true;


        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} is now driving forword.");
        }
        public void Reverse()
        {
            if(HasChangedGears == true)
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
            if(HasChangedGears == true)
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

        public void GetHasTrunk()
        {
            //HasTrunk = hasTrunk;
            if (HasTrunk)
            {
                Console.WriteLine($"The {GetType().Name} has a trunk");
            }
            else
            {
                Console.WriteLine($"The {GetType().Name} does not have a trunk");
            }
        }
    }
}
