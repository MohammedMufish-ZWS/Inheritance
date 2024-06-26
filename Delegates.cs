﻿using System;

namespace CSharp
{
    internal class Delegates
    {   // Declaring the delegates
        public delegate void addition(int a, int b);
        public delegate string SayHi(string name);


        
        public void add(int a, int b)
       {
            Console.WriteLine(a + b);
       }
        public static string SayHello(string name) 
        {
            return "Hello "+ name;
        }
        
         
        
    }
}

// C# program to illustrate the use of Delegates


