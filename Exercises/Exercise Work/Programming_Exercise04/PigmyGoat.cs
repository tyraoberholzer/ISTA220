using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Exercise04
{
    internal class PigmyGoat
    {
        internal string name;

        internal PigmyGoat(string Name)
        {
            name = Name;
        }

        internal void IntroA()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"BAAA, BAAAA! My name is {this.name}, and I am one of the oldest {this.GetType()}s on the farm!");
        }
        internal void ColorA()
        {
            Console.WriteLine($"I am a black and white {this.GetType()} where the white looks like it was sprinkled on top of me like salt!");
        }
        internal void FoodA()
        {
            Console.WriteLine($"My normal {this.GetType()} food is hay, grass, and water, but for a special treat sometimes I get grain too! Also my humans give me apples and yummy apple leaves...those are my favorite!");
        }
        internal void PlayA()
        {
            Console.WriteLine($"Since I am the oldest {this.GetType()} I am not as playful as I once was, but I love to butt heads with other {this.GetType()}!");
        }

        internal void IntroB()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"BAAA, BAAAA! My name is {this.name}. Salt likes to think he is the oldest {this.GetType()} on the farm, but I actually am!");
        }

        internal void ColorB()
        {
            Console.WriteLine($"I am white with a couple large splotches of brown. I am a Boar Milking goat so I am bigger than the {this.GetType()}s!");
        }

        internal void FoodB()
        {
            Console.WriteLine($"My normal {this.GetType()} food is the same as all the other goats...hay, grass, and water, but for a special treat sometimes I get grain too! After my humans are done milking me they like to give me a treat for a good job!");
        }

        internal void PlayB()
        {
            Console.WriteLine($"When I am not being milked I like to play with the little {this.GetType()}s!");
        }
        internal void IntroC()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"BAAA, BAAAA! My name is {this.name}. I am the second oldest {this.GetType()} on the farm, and Salt is my son!");
        }

        internal void ColorC()
        {
            Console.WriteLine($"I am a black and white {this.GetType()}. I was name Pepper because my fur looks like Pepper!");
        }

        internal void FoodC()
        {
            Console.WriteLine($"My normal {this.GetType()} food is hay, grass, and water. When I first had Salt I also got special Mamma feed to keep me healthy from all the work I had just done!");
        }

        internal void PlayC()
        {
            Console.WriteLine($"Being an older {this.GetType()} the littler ones get on my nerves trying to jump all over me!");
        }
        internal void IntroD()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"BAAA, BAAAA! My name is {this.name}, and I am one of the younger {this.GetType()}s on the farm!");
        }

        internal void ColorD()
        {
            Console.WriteLine($"Most of my fur is white but I have a patch that looks just like the eight ball in pool...so that's why they call me the EightBall {this.GetType()}!");
        }

        internal void FoodD()
        {
            Console.WriteLine($"{this.GetType()} food can be really boring....I am just glad our humans gives us treats all the time!");
        }

        internal void PlayD()
        {
            Console.WriteLine($"Even though I know I am a {this.GetType()} I like to play with the humans more than the other {this.GetType()}!");
        }
    }
}
