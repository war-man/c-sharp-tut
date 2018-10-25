using System;
using System.Linq;

namespace CSharpTut
{
    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalID { get; set; }

        public Animal(
            string name = "No Name",
            double weight = 0,
            double height = 0
        )
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return string.Format(
                "{0} weighs {1}lbs and is {2} inches tall",
                Name,
                Weight,
                Height
            );
        }

        private string name;
        protected string sound;

        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public void SetAnimalIdInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        //public void MakeSound()
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double dblX = Convert.ToDouble(num1);
            double dblY = Convert.ToDouble(num2);
            Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");
        }

        public Animal()
            :this("No Name", "No Sound") { }

        public Animal(string name)
            :this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        //public string Name
        //{
        //    get { return name; }
        //    set
        //    {
        //        if (!value.Any(char.IsDigit))
        //        {
        //            name = "No Name";
        //        }
        //        name = value;
        //    }
        //}

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }
                sound = value;
            }
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
