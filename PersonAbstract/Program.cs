using System;

namespace PersonAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            var snake = new Snake();
            snake.Go();
        }
    }

    abstract class Person
    {
        abstract public void Go();
        abstract public void Run();
    }

    class Snake : Person
    {
        public override void Go()
        {
            Console.WriteLine("Truon");
        }

        public override void Run()
        {
            Console.WriteLine("Truon nhanh");
        }
    }

    class Bird : Person
    {
        public override void Go()
        {
            Console.WriteLine("Bay");
        }

        public override void Run()
        {
            Console.WriteLine("Bay nhanh");
        }
    }

    class Dog : Person
    {
        public override void Go()
        {
            Console.WriteLine("Chay");
        }

        public override void Run()
        {
            Console.WriteLine("Chay nhanh");
        }
    }
}
