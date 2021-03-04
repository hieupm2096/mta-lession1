using System;

namespace PersonOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nguoi1 = new Person();
            nguoi1.Nhap();
            nguoi1.HienThi();

            var nguoi2 = new Person("pham manh hieu", "631 kim ma", 23);
            nguoi2.HienThi();

            var hs1 = new Student();
            hs1.Di();
            hs1.Di(100);

            var hs2 = new Student
            {
                Ten = "pham manh hieu",
                Tuoi = 23,
                DiaChi = "631 kim ma"
            };
            hs2.Di();
            hs2.Di(200);
        }
    }

    class Person
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public int Tuoi { get; set; }

        public Person() { }

        public Person(string ten, string diachi, int tuoi)
        {
            Ten = ten;
            DiaChi = diachi;
            Tuoi = tuoi;
        }

        public void Nhap()
        {
            Console.Write("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Tuoi = Convert.ToInt16(Console.ReadLine());
        }

        public void HienThi()
        {
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Tuoi: " + Tuoi);
        }
    }

    class Student : Person
    {
        public void Di()
        {
            Console.WriteLine("Hoc sinh di");
        }

        public void Di(int speed)
        {
            Console.WriteLine("Hoc sinh di voi toc do: " + speed);
        }
    }
}
