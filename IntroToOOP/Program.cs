using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstcat = new Cat();
            firstcat.Name = "Mr. Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstcat.Name);
            Console.WriteLine(secondCat.Name);

            firstcat.Eat();

            secondCat.Meow();

            firstcat.HairLength = "nice and short";
            secondCat.HairLength = "too long";
            Console.WriteLine(firstcat.Hairball());
            Console.WriteLine(secondCat.Hairball());

            Cat thirdCat = new Cat(4, true);

            Dog firstDog = new Dog("short", 25, 30, 25.22);
            Dog secondDog = new Dog();
            Console.WriteLine(firstDog.HairLength + ", "+ firstDog.Height + ", " + firstDog.RunningSpeed + ", " + firstDog.Weight);
            secondDog.Potty();
            secondDog.Bark();
        }
    }
}
