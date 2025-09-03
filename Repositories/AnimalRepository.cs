using AnimalApp;

namespace Repositories
{
    public class AnimalRepository
    {
       private List<Animal> animal = new List<Animal>();

       public AnimalRepository()
       {
           animal.Add(new Dog("Fred"));
       }

       public List<Animal> GetAnimal()
       {
           return animal;
       }
    }
}