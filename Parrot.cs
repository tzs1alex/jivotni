using System;
using System.Collections.Generic;
using System.Text;

namespace zoopark
{
    internal class Parrot : Animal, IFlyable
    {
        public Parrot(string name, int age, double weight) : base(name, age, weight)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} izdava zvuci.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating semena.");
        }
        public void Fly()
        {
            Console.WriteLine(Name + " is flying.");
        }
    }
}
