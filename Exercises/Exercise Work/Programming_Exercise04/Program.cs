using System;

namespace Programming_Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog heidi = new Dog("Heidi");
            heidi.IntroA();
            heidi.ColorA();
            heidi.FoodA();
            heidi.PlayA();

            Dog dixie = new Dog("Dixie");
            dixie.IntroB();
            dixie.ColorB();
            dixie.FoodB();
            dixie.PlayB();

            Dog nakita = new Dog("Nakita");
            nakita.IntroC();
            nakita.ColorC();
            nakita.FoodC();
            nakita.PlayC();

            Dog arson = new Dog("Arson");
            arson.IntroD();
            arson.ColorD();
            arson.FoodD();
            arson.PlayD();

            Cat tizzie = new Cat("Tizzie");
            tizzie.IntroA();
            tizzie.ColorA();
            tizzie.FoodA();
            tizzie.PlayA();

            Cat apollo = new Cat("Apollo");
            apollo.IntroB();
            apollo.ColorB();
            apollo.FoodB();
            apollo.PlayB();

            Cat stripes = new Cat("Stripes");
            stripes.IntroC();
            stripes.ColorC();
            stripes.FoodC();
            stripes.PlayC();

            Cat sasha = new Cat("Sasha");
            sasha.IntroD();
            sasha.ColorD();
            sasha.FoodD();
            sasha.PlayD();

            Cat lizzie = new Cat("Lizzie");
            lizzie.IntroE();
            lizzie.ColorE();
            lizzie.FoodE();
            lizzie.PlayE();

            Cat smokey = new Cat("Smokey");
            smokey.IntroF();
            smokey.ColorF();
            smokey.FoodF();
            smokey.PlayF();

            PigmyGoat salt = new PigmyGoat("Salt");
            salt.IntroA();
            salt.ColorA();
            salt.FoodA();
            salt.PlayA();

            PigmyGoat nutmeg = new PigmyGoat("Nutmeg");
            nutmeg.IntroB();
            nutmeg.ColorB();
            nutmeg.FoodB();
            nutmeg.PlayB();

            PigmyGoat pepper = new PigmyGoat("Pepper");
            pepper.IntroC();
            pepper.ColorC();
            pepper.FoodC();
            pepper.PlayC();

            PigmyGoat eightball = new PigmyGoat("Eight Ball");
            eightball.IntroD();
            eightball.ColorD();
            eightball.FoodD();
            eightball.PlayD();

            Horse dallas = new Horse("Dallas");
            dallas.IntroA();
            dallas.ColorA();
            dallas.FoodA();
            dallas.PlayA();

            Horse ella = new Horse("Ella");
            ella.IntroB();
            ella.ColorB();
            ella.FoodB();
            ella.PlayB();

            Horse maverick = new Horse("Maverick");
            maverick.IntroC();
            maverick.ColorC();
            maverick.FoodC();
            maverick.PlayC();

            Horse george = new Horse("George");
            george.IntroD();
            george.ColorD();
            george.FoodD();
            george.PlayD();

        }
    }
}
//Using classes and objects, implement a farm.Create a class containing a Main() function that exercises
//your other classes.Create classes representing several types of domesticated animals, such as cows, sheep,
//chickens, goats, etc.Instantiate several objects of each class. For example, for your Rabbit class, you might
//instantiate objects Bugs Bunny, Roger Rabbit, Thumper, and Peter Cottontail.

//Implementing one class: 70 points Implement one class of a farm animal.You can choose your type
//of animal: horses, cows, pigs, sheep, etc.For our class, implement at least one eld, such as a name eld,
//and at least two methods, such as a speak or an eat method.Also implement two constructors, a default
//constructor that takes no parameters and another constructor that takes at least one parameter, such as (for
//example) the object name.

//Four instances: 90 points Create four or more animals from your class. Invoke all methods for each.If
//you create pigs, you can have Porky, Wilbur, Miss Piggy, and Napoleon(the pig leader in Orwell's Animal
//Farm). You can implement a speak() method for each animal.A pig can say, \Oink." A cow can say,
//\Moo." A chicken can say, \Cluck." You get the idea.

//Four classes, four instances: 100 points Implement one farm animal by creating a class and a method.
//For example, you may elect to create a Horse type, and a speak() method. In your main program, instantiate
//a Horse, name him MrEd, and call the speak() method. When Mr. Ed speaks, he might say something like,
//\Hello, my name is Mr.Ed, and I am a horse.I say neigh."