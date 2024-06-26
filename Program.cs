using Inheritance;
using Inheritance.Design_Patterns.Creational;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using static CSharp.Enum;
using static CSharp.Sealed;
using static CSharp.Sum;

namespace CSharp
//Inheritance(Interface)
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("hello sir please eat something");
        }
    }

    public class Dog : Animal
    {   public void Bark()
        {
            Console.WriteLine("I am dog. Get Out of my Area");
        }
    }

    public class Mammal : Animal
    {
        public void Something()
        {
            Console.WriteLine("belong to mammal class");
        }
    }

    public class Horse : Mammal //MultiLevel
    {
        public void Run()
        {
            Console.WriteLine("tabdik tabdik ");
        }
    }

    public interface OS
    {
        void Kernel();

    }

    public class Mltiple : OS
    {   
        public void Kernel()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {


        static void Go()
        {
            int numberOfTimesToRun = 1000000;
            const string space = " ";
            const string the = "the";
            const string quick = "quick";
            const string brown = "brown";
            const string fox = "fox";
            const string jumps = "jumps";
            const string over = "over";
            const string lazy = "lazy";
            const string dog = "dog";

            var concatStopWatch = Stopwatch.StartNew();

            for (var i = 0; i < numberOfTimesToRun; i++)
                string.Concat(the, space, quick, space, brown, space, fox, space, jumps, space, over, space, the, space, lazy, space, dog);

            concatStopWatch.Stop();

            var joinStopWatch = Stopwatch.StartNew();
            for (var i = 0; i < numberOfTimesToRun; i++)
                string.Join(space, the, quick, brown, fox, jumps, over, the, lazy, dog);

            joinStopWatch.Stop();

            var stringbuilderStopWatch = Stopwatch.StartNew();
            for (var i = 0; i < numberOfTimesToRun; i++)
                new StringBuilder().Append(space).Append(the).Append(quick).Append(brown).Append(fox).Append(jumps).Append(over).Append(the).Append(lazy).Append(dog);

            stringbuilderStopWatch.Stop();


            Console.WriteLine("string.join - {0}", joinStopWatch.ElapsedMilliseconds);
            Console.WriteLine("string.concat- {0}", concatStopWatch.ElapsedMilliseconds);
            Console.WriteLine("StringBuilder.Append- {0}", stringbuilderStopWatch.ElapsedMilliseconds);
        }

        public class Cat : Abstraction
        {
            public override void AnimalSound()
            {
                Console.WriteLine("Meow Meow");
            }
        }
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
        }


        static void Main(string[] args)
        { 
            ConstructorChaining cc = new ConstructorChaining();
            Console.WriteLine("So I am going to present to you how inheritance works in C#");
            //Inheritance
            Dog tommy = new Dog();
            tommy.Eat();
            tommy.Bark();

            Horse chetak = new Horse();
            chetak.Run();
            chetak.Eat();
            chetak.Something();
            //Compile time polymorphism
            Sum p = new Sum();
            p.sum(10, 90);
            p.sum(11, 77, 11);
            //Run time Polymorphism
            so akash = new so();
            akash.bhai();

             for (var i = 1; i <= 5; i++)
             {
                 Console.WriteLine("Pass #" + i);
                 Go();

                 Console.WriteLine();
             }
            


            // "20" is capacity 
            string jk = "hey bro ";
            Console.WriteLine(jk);

            StringBuilder s = new StringBuilder("HELLO ", 20);

            s.Append("GFG");

            // after printing "GEEKS" 
            // a new line append 
            s.AppendLine(" GEEKS");

            s.Append("GeeksForGeeks ");
            s.Insert(15, "Development");
            s.Remove(0, 15);
            Console.WriteLine(s);


            //sealed 

            Printer op = new Printer();
            op.show();
            op.print();

            Printer ls = new LaserJet();
            ls.show();
            ls.print();

            Printer of = new Officejet();
            of.show();
            of.print();

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //enum
            int myNum = (int)Months.July;
            Console.WriteLine(myNum);
            //Delegate
            Delegates delegates = new Delegates();
            delegates.add(100, 50);
            string x = Delegates.SayHello("azim");
            Console.WriteLine(x);
            //Abstraction
            Cat cat = new Cat();
            cat.AnimalSound();
            cat.sleep();
            //encapsuNlation
            encapsulation manu = new encapsulation();
            //manu.name="hustle";
            //manu.age=22;
            manu.setage(5);
            manu.setname("manu");
            Console.WriteLine(manu.getname());
            Console.WriteLine(manu.getage());
            


            var StopWatch = Stopwatch.StartNew();
            List<string> GenList = new List<string>();
            GenList.Add("Akmal");
            GenList.Add("Samir");
            GenList.Add("Faisal");
            GenList.Add("Azharuddin");
            GenList.Add("Sohil");
            GenList.Insert(4, "Abdul Razzak");
            GenList.Add("Akash");
            foreach (string kl in GenList)
            {
                Console.WriteLine(kl);
            }
            GenList.Remove("Akash");
            GenList.RemoveAt(1);
            var joker = GenList.Contains("Abdul Razzak");
            Console.WriteLine(joker);

            //GenList.Sort();
            GenList.Reverse();
            //console.writeline("sorted list:");
            Console.WriteLine("Reverse List:");

            foreach (string msd in GenList)
            { Console.WriteLine(msd); }

            StopWatch.Stop();
            Console.WriteLine($"{StopWatch.ElapsedMilliseconds}");




            Dictionary<string, string> GenericDictionary = new Dictionary<string, string>();

            GenericDictionary.Add("Orange", "Soda");

            GenericDictionary.Add("Chicken", "Burger");

            GenericDictionary.Add("Freanch", "Fries");

            GenericDictionary.Add("Balaji", "Onion Rings");

            foreach (KeyValuePair<string, string> kvp in GenericDictionary)
            {
                Console.WriteLine( kvp.Key + " " + kvp.Value);
            }

            Program pro = new Program();
            pro.Test();

            List<Student> studentList = new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Gender = "Male"},
                new Student(){ID = 2, Name = "Sara", Gender = "Female"},
                new Student(){ID = 3, Name = "Steve", Gender = "Male"},
                new Student(){ID = 4, Name = "Pam", Gender = "Female"}
            };
            //Linq Query to Fetch all students with Gender Male
            IEnumerable<Student> QuerySyntax = from std in studentList
                                               where std.Gender == "Female"
                                               select std;
            //Iterate through the collection
            foreach (var student in QuerySyntax)
            {
                Console.WriteLine($"ID : {student.ID}  Name : {student.Name}");
            }

            var db = new ORM();
            IEnumerable<Customer> v = db.GetCustomersAsEnumerable();
            //v=50000
            var highPayingCustomers = v.Where(c => c.Revenue > 2500);
           //highPayingCustomers = 2500
            IQueryable<Customer> q = db.GetCustomersAsQueryable();
            // q=0;
            highPayingCustomers = q.Where(c => c.Revenue > 2500);
            //highPayingCutomers=0
            var finalData= highPayingCustomers.ToList();


            //Singleton Pattern


            Thread t1 = new Thread(() =>
            {
                var instance = UploadService.Instance(1);
            });
            Thread t2 = new Thread(() =>
            {
                var instance = UploadService.Instance(2);
            });
            t1.Start();
            t2.Start();
            t1.Join();  
            t2.Join();  


            //Factory Pattern


            // Create animals using the factory
            IAnimal dog = AnimalFactory.CreateAnimal("dog");
            dog.Speak(); // Output: Woof!

            IAnimal Cat = AnimalFactory.CreateAnimal("cat");
            Cat.Speak(); // Output: Meow!

            IAnimal duck = AnimalFactory.CreateAnimal("duck");
            duck.Speak(); // Output: Quack!

            // Trying to create an invalid animal
            try
            {
                IAnimal unknown = AnimalFactory.CreateAnimal("lion");
                unknown.Speak();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // Output: Invalid animal type
            }



            //Builder Pattern


            HouseBuilder builder = new HouseBuilder();
            House house = builder.BuildWalls("brick")
                                  .BuildRoof("tile")
                                  .BuildDoors("wooden")
                                  .BuildWindows("glass")
                                  .Build();

            Console.WriteLine(house);


            Console.ReadLine();

        }
    }

    
}






