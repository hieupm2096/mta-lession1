using System;
using MyNameSpace;

namespace PersonDefineClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("hieu", 23);
            var emp = new Employee
            {
                Name = "hieu",
                Age = 23,
                BasicSalary = 200
            };

            Console.WriteLine("Luong: " + emp.CalculateSalary());
        }

    }
}

namespace MyNameSpace
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Employee : Person
    {
        public int BasicSalary { get; set; }

        public double CalculateSalary()
        {
            return BasicSalary;
        }

        public double CalculateSalary(int bonus, int punishment)
        {
            return BasicSalary + bonus - punishment;
        }

        public double CalculateSalary(int bonus, int punishment, int extra)
        {
            return BasicSalary + bonus - punishment + extra;
        }
    }
}
