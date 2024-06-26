using System;

namespace Inheritance.Design_Patterns.Creational
{   // Step 1: Animal Interface
    public interface IAnimal
    {
        void Speak();
    }

    // Step 2: Concrete Animal Classes
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }

    public class Duck : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Quack!");
        }
    }
    public static class AnimalFactory
    {
        public static IAnimal CreateAnimal(string animalType)
        {
            switch (animalType.ToLower())
            {
                case "dog":
                    return new Dog();
                case "cat":
                    return new Cat();
                case "duck":
                    return new Duck();
                default:
                    throw new ArgumentException("Invalid animal type");
            }
        }
    }
}
