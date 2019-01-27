using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };
            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "wooof",
                Sound2 = "Greer"
            };
            grover.MakeSound();
            whiskers.MakeSound();

            whiskers.SetAnimalInfo(1236, "Sally Smith");
            grover.SetAnimalInfo(676, "Paul Brown");


            grover.GetAnimalInfo();
            whiskers.GetAnimalInfo();

            //Inner class
            Animal.AnimalHealth animalHealth = new Animal.AnimalHealth();
            //Console.WriteLine("Is my Animal is healthy :{0}",animalHealth.HealthyWeight(11,23));
            Console.WriteLine($"Is my Animal is healthy :{animalHealth.HealthyWeight(11, 46)}");


            //polymorphism

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeee"
            };
            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Jeee",
                Sound2 = "Wooof"
            };
            spot.MakeSound();
            monkey.MakeSound();
        }
    }
}
