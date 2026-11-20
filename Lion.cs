using System;
using System.Collections.Generic;
using System.Text;

namespace zoopark
{
    internal class Lion : Animal, IRunnable
    {
        public Lion(string name, int age, double weight) : base(name, age, weight)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is reve.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating meat.");
        }
        public void Run()
        {
            Console.WriteLine(Name + " is running.");
        }
    }
}
