using System;

namespace Quiz_04
{
    class Firearm
    {
        public void fire(string name, string noise)
        {
            Console.WriteLine($"I am a {name} and I go {noise}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tyra Oberholzer");
            Console.WriteLine("July 28, 2020");
            Console.WriteLine("This is my C# Quiz 04.");
            Firearm shotgun = new Firearm();
            shotgun.fire("Shotgun", "Boom");
            Firearm rifle = new Firearm();
            rifle.fire("Rifle", "Bang");
            Firearm pistol = new Firearm();
            pistol.fire("Pistol", "Pop");
        }
    }
}

