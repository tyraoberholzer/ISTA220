using System;

namespace Vehicles
{
    class Truck : Vehicle
    {
        public void Haul()
        {
            Console.WriteLine("Hauling");
        }
        public void Tows()
        {
            Console.WriteLine("Towing");
        }
        public override void Drive()
        {
            Console.WriteLine("Trucking");
        }

    }
}
