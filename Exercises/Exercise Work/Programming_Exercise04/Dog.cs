using System;

namespace Programming_Exercise04
{
    internal class Dog
    {
        internal string name;

        internal Dog(string Name)
        {
            name = Name;
        }

        internal void IntroA()
        {
            Console.WriteLine($"Woof, Woof! My name is {this.name}. I am a Saint Bernard {this.GetType()}!");
        }

        internal void ColorA()
        {
            Console.WriteLine($"My fur is brown, black, and white. I am a very colorful {this.GetType()}!");
        }

        internal void FoodA()
        {
            Console.WriteLine($"I like to eat and eat and eat, but I don't like to eat {this.GetType()} food I like to eat human food.");
        }

        internal void PlayA()
        {
            Console.WriteLine($"I like to run around and play, but then I get tired quickly.I am a lazy {this.GetType()}.");
        }

        internal void IntroB()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Woof, Woof! My name is {this.name}. I am a Corgi {this.GetType()}!");
        }

        internal void ColorB()
        {
            Console.WriteLine($"My fur is brown, black, and white. I am a very tiny and cute {this.GetType()}!");
        }

        internal void FoodB()
        {
            Console.WriteLine($"My favorite type of human food is Peanut butter, but if I have to eat {this.GetType()} food then I like to eat soft dog food. ");
        }

        internal void PlayB()
        {
            Console.WriteLine($"I like to pretend I am an old lazy {this.GetType()}, but if I see another {this.GetType()} I will run after it and bark!");
        }

        internal void IntroC()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Woof, Woof! My name is {this.name}. I am an Eskimo Spitz {this.GetType()}!");
        }

        internal void ColorC()
        {
            Console.WriteLine($"I am supposed to be a white {this.GetType()}, but I like to role in the mud so I turn brown!");
        }

        internal void FoodC()
        {
            Console.WriteLine($"If my humans drop any food on the floor I am the first to get it. They like to say I am a vaccuum {this.GetType()}.");
        }

        internal void PlayC()
        {
            Console.WriteLine($"While the other {this.GetType()}s are playing together I prefer to hang out with my humans.");
        }

        internal void IntroD()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Woof, Woof! My name is {this.name}. I am a German Shephard {this.GetType()}!");
        }

        internal void ColorD()
        {
            Console.WriteLine($"Most German Shepard {this.GetType()}s are mainly brown with some black, but I am the other way around. I am most black with very little brown!");
        }

        internal void FoodD()
        {
            Console.WriteLine($"I am a very big {this.GetType()} so I like to eat....it doesn't matter what...dog food, human food, grass, dirt...anything really!");
        }

        internal void PlayD()
        {
            Console.WriteLine($"Since I am such a big {this.GetType()}, and I look scary most humans are scared of me. But I have a dog friend named Heidi who loves playing wiht me!");
        }


    }
}
