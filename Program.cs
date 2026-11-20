namespace zoopark
{
    public interface ISwimmable
    {
        void Swim();
    }

    public interface IFlyable
    {
        void Fly();
    }

    public interface IRunnable
    {
        void Run();
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Lion("Симба", 5, 190));

            animals.Add(new Elephant("Дъмбо", 10, 1200));

            animals.Add(new Parrot("Коко", 2, 1));

            animals.Add(new Dolphin("Флипър", 7, 250));

            foreach (Animal animal in animals)
            {
                animal.DisplayInfo();
            }
            Console.WriteLine("\n=== ЗВУЦИ НА ЖИВОТНИТЕ ===");

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
            Console.WriteLine("\n=== ХРАНЕНЕ ===");

            foreach (Animal animal in animals)
            {
                animal.Eat();
            }
            Console.WriteLine("\n=== ЖИВОТНИ, КОИТО МОГАТ ДА ПЛУВАТ ===");

            foreach (Animal animal in animals)
            {
                if (animal is ISwimmable swimmer)
                {
                    swimmer.Swim();
                }
            }
            Console.WriteLine("\n=== ЖИВОТНИ, КОИТО МОГАТ ДА ЛЕТЯТ ===");

            foreach (Animal animal in animals)
            {
                if (animal is IFlyable flyer)
                {
                    flyer.Fly();
                }
            }
            Console.WriteLine("\n=== ЖИВОТНИ, КОИТО МОГАТ ДА ТИЧАТ ===");

            foreach (Animal animal in animals)
            {
                if (animal is IRunnable runner)
                {
                    runner.Run();
                }
            }
        }
    }
}
