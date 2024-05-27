using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ConstructorChaining
    {


            // Constructor 1: no parameter constructor method, calls the second constructor
            public ConstructorChaining() : this(10)
            {
            // Call the second constructor with a default value
            // First Constructor
            Console.WriteLine("default constructor");
        }

            // Constructor 2: constructor with one parameter or parameterized constructor
            public ConstructorChaining(int Age)
            {
                Console.WriteLine(Age+"\t year old human");
                
            }

        
    }
}
