using System;
using System.Collections.Generic;
using System.Text;

namespace zoopark
{
    internal class Dolphin : Animal, ISwimmable
    {
        public Dolphin(string name, int age, double weight): base(name, age, weight)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} izdava zvuci.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating ribi.");
        }
        public void Swim()
        {
            Console.WriteLine(Name + " is swimming.");
        }
    }
}
