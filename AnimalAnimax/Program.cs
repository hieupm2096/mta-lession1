using System;

namespace AnimalAnimax
{
    class Program
    {
        static void Main(string[] args)
        {
            var lion1 = new Lion();
            Lion.age = 1;
            lion1.inAge();

            var lion2 = new Lion();
            Lion.age++;

            lion1.inAge();

            lion2.inAge();
        }
    }

    abstract class Animal
    {
        public abstract void Eat();
        public abstract void Drink();
    }

    interface DongVatAnThit
    {
        public void Sanmoi();
    }

    class Person : Animal, DongVatAnThit
    {
        public override void Drink()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void Sanmoi()
        {
            throw new NotImplementedException();
        }
    }

    class Snake : Animal, DongVatAnThit
    {
        public override void Drink()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void Sanmoi()
        {
            throw new NotImplementedException();
        }
    }

    class Lion : Animal, DongVatAnThit
    {
        public override void Drink()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void Sanmoi()
        {
            throw new NotImplementedException();
        }

        public static int age;

        static void VoMoi()
        {

        }

        public void inAge()
        {
            Console.WriteLine("Age: " + age);
        }
    }

    sealed class Camel
    {
        public const int age = 10;

        void Run()
        {

        }
    }
}
