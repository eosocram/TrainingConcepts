using Repositories;

namespace App
{
    public class Dog : Animal, IRun 
    {
        public Dog(string name = "DogName")
        {
            Name = name;
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name} está latindo!");
        }

        public void Run()
        {
            Console.WriteLine($"{Name} está correndo");
        }
    }
}