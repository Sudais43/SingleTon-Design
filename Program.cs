using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
namespace Singleton.Structural
{
    /// <summary> 
    /// Singleton Design Pattern 
    /// </summary> 
    public class Program
    {
        public static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new 
            President P1 = President.Instance();
            President P2 = President.Instance();

            //Constructor is Public
            Director D1 = new Director();
            Director D2 = new Director();

            Student s1 = Student.Instance();
            Student s2 = Student.Instance();
            Student s3 = Student.Instance();
            Student s4 = Student.Instance();
            Student s5 = Student.Instance();

            if (s1 == s2 && s2 == s3)
            {
                System.Console.WriteLine("limit not exceeded");
            }
            else
            {
                System.Console.WriteLine("limit not exceeded");
            }


            // Test for same instance 
            if (P1 == P2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            if (D1 == D2)
            {
                Console.WriteLine("Object are Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            // Wait for user 
            Console.ReadKey();
        }
    }

    /// <summary> 
    /// The 'Singleton' class 
    /// </summary> 

    public class President
    {
        static President instance;

        // Constructor is 'protected' 

        protected President()
        {
        }

        public static President Instance()
        {
            // Uses lazy initialization. 
            // Note: this is not thread safe. 
            if (instance == null)
            {
                instance = new President();
            }

            return instance;
        }
    }

    public class Director
    {
        public Director() { } 

    }


    public class Student
    {
        static Student instance;
        private static int instanceCount = 0;
        private static int MaxInstanceCount = 4;
        protected Student() { }

        public static Student Instance()
        {
            if (instanceCount < MaxInstanceCount)
            {
                instance = new Student();
                instanceCount++;
            }
            else
            {
                Console.WriteLine("Cannot create more than 4 instance");
            }

            return instance;
        }

    }
}