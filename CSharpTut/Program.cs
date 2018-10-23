using System;

namespace CSharpTut
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrr"
            };

            grover.Sound = "Wooooooof";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIdInfo(12345, "Sally Smith");
            grover.SetAnimalIdInfo(12346, "Paul Brown");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));
            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 146));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooooooff",
                Sound2 = "Geeerrrr"
            };

            monkey.MakeSound();
            spot.MakeSound();
        }
    }
}
