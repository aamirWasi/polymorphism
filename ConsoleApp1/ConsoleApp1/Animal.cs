using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        private string name;
        protected string sound;
        protected AnimalIdInfo animalIdInfo = new AnimalIdInfo();
        public void SetAnimalInfo(int IdNum,string owner)
        {
            animalIdInfo.IdNum = IdNum;
            animalIdInfo.Owner = owner;
        }
        public void GetAnimalInfo()
        {
            Console.WriteLine($"{Name} had the ID of {animalIdInfo.IdNum} & is owned by {animalIdInfo.Owner}");
        }

        //Method to MakeSound
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal()
            :this("No Name","No Sound") { }
        public Animal(string name)
            : this(name, "No Sound") { }

        public Animal(string name, string sound) {
            Name = name;
            Sound = sound;
        }
        //Name properties
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = value;
                }
                else
                {
                    name = "No Name";
                }
            }
        }
        //Sound Properties
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
            public bool HealthyWeight(double height,double weight)
            {
                double calc = height / weight;
                if((calc>=.18)&& (calc <= .27))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
