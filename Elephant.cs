using System;
using System.Collections.Generic;
using System.Text;

namespace zoopark
{
    internal class Elephant : Animal, IRunnable
    {
        public Elephant(string name, int age, double weight) : base(name, age, weight)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} izdava zvuci.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating treva.");
        }
        public void Run()
        {
            Console.WriteLine(Name + " is running.");
        }
    }
}
