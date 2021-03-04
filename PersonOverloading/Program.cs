using System;

namespace PersonOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Person
    {
        void Eat()
        {
            Console.WriteLine("Eat");
        }

        void Eat(int speed)
        {
            Console.WriteLine("Eat with speed");
        }

        void Eat(string str)
        {
            Console.WriteLine("Eat " + str);
        }
    }

    class Doctor : Person
    {
        public Doctor()
        {

        }

        public Doctor(int speed)
        {

        }

        void Display() { }
    }

    class Employee: Person
    {
        public Employee()
        {

        }

        public Employee(int speed)
        {

        }

        void Display() { }
    }
}
