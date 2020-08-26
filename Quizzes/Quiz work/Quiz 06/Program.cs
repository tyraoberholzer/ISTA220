using System;

namespace Quiz_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Tyra's C# Quiz 06.");
            Firearm myFirearm = new Firearm();
            myFirearm.Shooting();
            Shotgun myShotgun = new Shotgun();
            myShotgun.Shooting();
            Rifle myRifle = new Rifle();
            myRifle.Shooting();
            Pistol myPistol = new Pistol();
            myPistol.Shooting();
        }
    }
    class Firearm
    {
        public virtual void Shooting()
        {
            Console.WriteLine("I am a Firearm and I shoot things.");
        }
    }
    class Shotgun : Firearm
    {
        public override void Shooting()
        {
            Console.WriteLine("I am a shotgun and I go Boom.");
        }
    }
    class Rifle : Firearm
    {
        public override void Shooting()
        {
            Console.WriteLine("I am a rifle and I go Bang.");
        }        
    }
    class Pistol : Firearm
    {
        public override void Shooting()
        {
            Console.WriteLine("I am a pistol and I go Pop.");
        }        
    }

}

//This is C Sharp quiz 6.
//I am a firearm and I shoot things.
//I am a shotgun and I go Boom.
//I am a rifle and I go Bang.
//I am a pistol and I go Pop.
//Press any key to continue .
