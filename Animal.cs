using System;
using System.Collections.Generic;
using System.Text;

namespace zoopark
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public Animal(string Name, int Age, double Weight)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weight = Weight;
        }
        public abstract void MakeSound();

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating...");
        }   

        public void DisplayInfo()
        {
            Console.WriteLine("Name" + Name);
            Console.WriteLine("Age" + Age);
            Console.WriteLine("Weight" + Weight);
        }
    }
}
