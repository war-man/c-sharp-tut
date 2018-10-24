﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpTut
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Animal Farm:");

            AnimalFarm myAnimals = new AnimalFarm();

            myAnimals[0] = new Animal("Wilbur");
            myAnimals[1] = new Animal("Templeton");
            myAnimals[2] = new Animal("Gander");
            myAnimals[3] = new Animal("Charlotte");

            foreach (Animal i in myAnimals)
            {
                Console.WriteLine(i.Name);
            }

            Console.WriteLine("\nBox:");

            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);
            Box box3 = box1 + box2;

            Console.WriteLine($"Box 3 : {box3}");
            Console.WriteLine($"Box Int : {(int)box3}");

            Box box4 = (Box)4;

            Console.WriteLine($"Box 4 : {(Box)4}");

            Console.WriteLine("\nShop:");

            var shopkins = new {
                Name = "Shopkins",
                Price = 4.99
            };

            Console.WriteLine("{0} costs ${1}", shopkins.Name, shopkins.Price);

            var toyArray = new[] {
                new
                {
                    Name = "Yo-Kai Pack",
                    Price = 4.99
                },
                new
                {
                    Name = "Legos",
                    Price = 9.99
                }
            };

            foreach (var item in toyArray)
            {
                Console.WriteLine("{0} costs ${1}", item.Name, item.Price);
            }
        }
    }
}
