using App;
namespace Repositories
{
    public static class DogRepository
    {
        public static List<Dog> GetDogs()
        {
            return new List<Dog>
            {
                new Dog("Simba"),
                new Dog("Fred"),
                new Dog("Bob")
            };
        }
    }
}