using System;

namespace LopNguoi
{
    class Program
    {
        static void Main(string[] args)
        {
            var nguoi1 = new Nguoi();
            nguoi1.Nhap();
            nguoi1.HienThi();

            var nguoi2 = new Nguoi("pham manh hieu", "631 kim ma", 23);
            nguoi2.HienThi();
            var nguoi3 = new Nguoi
            {
                Ten = "pham manh hieu",
                DiaChi = "631 kim ma",
                Tuoi = 23
            };
            nguoi3.HienThi();
        }
    }

    class Nguoi
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public int Tuoi { get; set; }

        public Nguoi() { }

        public Nguoi(string ten, string diachi, int tuoi)
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
}
