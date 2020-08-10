using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Exercise04
{
    internal class Horse
    {
        internal string name;

        internal Horse(string Name)
        {
            name = Name;
        }

        internal void IntroA()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Neigh, Neigh! My name is {this.name}, and I am the oldest {this.GetType()} out of the herd!");
        }

        internal void ColorA()
        {
            Console.WriteLine($"When I was a younger {this.GetType()} I didn't use to be as gray, but with old age comes the color gray!");
        }

        internal void FoodA()
        {
            Console.WriteLine($"Since I am an older {this.GetType()} I get more food than Ella the younger horse. I get fed twice a day, and I get grain, hay, water, grass, and some extra supplements to keep me agile in my older age!");
        }

        internal void PlayA()
        {
            Console.WriteLine($"Just because I am the oldest {this.GetType()} in this pasture doesn't mean I can't run with the others. I like to act like I am an old girl that can't get around, but when my owners aren't watching I like to run and gallop with the others!");
        }
        internal void IntroB()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Neigh, Neigh! My name is {this.name}, and I am one of the youngest and most honery {this.GetType()} out of the herd!");
        }

        internal void ColorB()
        {
            Console.WriteLine($"My owners say I am a bay {this.GetType()}, but I like to try and change my color to mud!");
        }

        internal void FoodB()
        {
            Console.WriteLine($"I am what they call a hard keeper {this.GetType()} which means basically I poop a lot so I need a lot of food and supplements to keep me fat!");
        }

        internal void PlayB()
        {
            Console.WriteLine($"When my parents take me on trail rides I act like a lazy {this.GetType()} that only wants to walk......but when they let me go in the pasture I run around and around in circles!");
        }
        internal void IntroC()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Neigh, Neigh! My name is {this.name}, and I am a Mini {this.GetType()}, but I like to pretend I am the same size as the others!");
        }

        internal void ColorC()
        {
            Console.WriteLine($"I am a beautiful {this.GetType()}! I am dark brown with a very sleek and shiny coat...no other can conmpare!");
        }

        internal void FoodC()
        {
            Console.WriteLine($"Even though I like to act like a bigger {this.GetType()} I only get fed like a small one. I get the usual hay, grass, water, and about once a week I will get grain.");
        }

        internal void PlayC()
        {
            Console.WriteLine($"When I am playing I play very rough with the bigger {this.GetType()}s I think I can take them all and at the same time!");
        }
        internal void IntroD()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Neigh, Neigh! My name is {this.name}. I am the biggest {this.GetType()} in the pasture!");
        }

        internal void ColorD()
        {
            Console.WriteLine($"I am the only paint {this.GetType()}. I am white with big brown spots!");
        }

        internal void FoodD()
        {
            Console.WriteLine($"I am not like the other {this.GetType()}s I could get fat off the air! I like to eat the grass as fast as I can cause it tastes very yummy! I get fed grain and hay, but I don't get as much cause they say I'm too fat already!");
        }

        internal void PlayD()
        {
            Console.WriteLine($"I like to think I am the most playful {this.GetType()} in the pasture. I just like having fun!");
        }
    }
}
