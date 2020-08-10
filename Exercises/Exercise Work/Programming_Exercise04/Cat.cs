using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Exercise04
{
    internal class Cat
    {
        internal string name;

        internal Cat(string Name)
        {
            name = Name;
        }

        internal void IntroA()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Meow, Meow! My name is {this.name}, and I am the Mamma {this.GetType()}!");
        }

        internal void ColorA()
        {
            Console.WriteLine($"I am a gray tigered {this.GetType()} with very soft fur!");
        }

        internal void FoodA()
        {
            Console.WriteLine($"My parents spoil me so I will have a bowl full hard {this.GetType()} food, but I will only eat it if there is soft {this.GetType()} cat food on top!");
        }

        internal void PlayA()
        {
            Console.WriteLine($"I may have 5 full grown children, but I would rather play with no other {this.GetType()}s. I prefer to be the one and only Queen!");
        }

        internal void IntroB()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Meow, Meow! My name is {this.name}. {this.name} may be my actual name, but I usually get called Paul. I am a son of the Mamma {this.GetType()}!");
        }

        internal void ColorB()
        {
            Console.WriteLine($"I am all black {this.GetType()} with a touch of white on the underside of my neck!");
        }

        internal void FoodB()
        {
            Console.WriteLine($"My brother Stripes is the biggest {this.GetType()}, but I am the second biggest so I like to eat a lot.");
        }

        internal void PlayB()
        {
            Console.WriteLine($"My parents have a broken explorer in the garage and I am one of the only {this.GetType()}s that likes to lay on top of it like it's my own big bed!");
        }

        internal void IntroC()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Meow, Meow! My name is {this.name}. I am also a son of the Mamma {this.GetType()}!");
        }

        internal void ColorC()
        {
            Console.WriteLine($"Some people say I look like a dirty {this.GetType()}, but in all reality I am just a dark tigered {this.GetType()} with a tan belly that looks like dirt.");
        }

        internal void FoodC()
        {
            Console.WriteLine($"Between my brothers, sisters, and my mamma I am the biggest {this.GetType()} of all. Even though I am the biggest I like to let everyone else eat first then I eat what's left.");
        }

        internal void PlayC()
        {
            Console.WriteLine($"I am a pretty laid back {this.GetType()}. You can pick me and hold me or pet, and I won't care as long as I get to take a nap on the couch later!");
        }

        internal void IntroD()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Meow, Meow! My name is {this.name}. I am a daughter of the Mamma {this.GetType()}!");
        }

        internal void ColorD()
        {
            Console.WriteLine($"Like my brother Paul I too am a black {this.GetType()} with a patch of white on the underside of my neck!");
        }

        internal void FoodD()
        {
            Console.WriteLine($"Now what my brother Paul and I do not share is that I am the smallest {this.GetType()}. I still like to be one of the first ones to the food though.");
        }

        internal void PlayD()
        {
            Console.WriteLine($"I like to think I am a very active {this.GetType()}, but sometimes I just want to be left alone. My parents say I can be sassy...I don't believe them.");
        }
        internal void IntroE()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Meow, Meow! My name is {this.name}. I am also daughter of the Mamma {this.GetType()}!");
        }

        internal void ColorE()
        {
            Console.WriteLine($"I look just like Mamma {this.GetType()}...so much that sometimes my parents get us confused. Although Mamma is a little bit chunkier then me!");
        }

        internal void FoodE()
        {
            Console.WriteLine($"I guess I am up there with Sasha and I like to be one of the first {this.GetType()}s to eat...but you couldn't tell with my girlish figure.");
        }

        internal void PlayE()
        {
            Console.WriteLine($"I used to be a very wiry {this.GetType()}...I couldn't stay out of trouble for more than five minutes. I'm older now though and more mature.");
        }
        internal void IntroF()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Meow, Meow! My name is {this.name}. I am another daughter of the Mamma {this.GetType()}!");
        }

        internal void ColorF()
        {
            Console.WriteLine($"I am the only gray {this.GetType()} in the family, but I do have that white patch under my neck....but my fur is the most soft out of all the other!");
        }

        internal void FoodF()
        {
            Console.WriteLine($"If I am not the first {this.GetType()} to the food bowl there is going to be a problem. I ALWAYS get first dibs!");
        }

        internal void PlayF()
        {
            Console.WriteLine($"In all honesty I am a pretty chill {this.GetType()}. I like to play with my brothers and sisters, but I also wouldn't mind a day to myself.");
        }
    }
}
