namespace AnimalApp
{
    public class Cat : Animal, IRun
    {
        public Cat(string name = "")
        {
            Name = name;
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name} está miando");
        }
        
        
        public void Run()
        {
            Console.WriteLine($"{Name} está correndo");
        }
    }
    
}