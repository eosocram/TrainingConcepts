namespace App
{
    abstract public class Animal
    {
        public string Name { get; set; } = string.Empty;

        public abstract void Sound();
    }
}