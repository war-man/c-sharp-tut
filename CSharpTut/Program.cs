using System;

namespace CSharpTut
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";
            cat.Owner = "Derek";

            Animal fox = new Animal("Oscar", "Rawrrr");

            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);
            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);
            Console.WriteLine("# of Animals : {0}", Animal.NumOfAnimals);
        }
    }
}
