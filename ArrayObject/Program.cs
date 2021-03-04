using System;

namespace ArrayObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int sosv = Convert.ToInt16(Console.ReadLine());

            var arraySinhVien = new SinhVien[sosv];

            for (int i = 0; i < sosv; i++)
            {
                var sinhVien = new SinhVien();
                Console.Write("Nhap MSSV: ");
                sinhVien.Id = Convert.ToInt16(Console.ReadLine());

                Console.Write("Nhap ho ten: ");
                sinhVien.Name = Console.ReadLine();

                Console.Write("Nhap tuoi: ");
                sinhVien.Age = Convert.ToInt16(Console.ReadLine());

                Console.Write("Nhap dia chi: ");
                sinhVien.Address = Console.ReadLine();

                arraySinhVien[i] = sinhVien;

                Console.WriteLine("===============");

            }

            var idChan = 0;
            var tuoiMax = arraySinhVien[0];
            var tongTuoi = 0;

            foreach (var item in arraySinhVien)
            {
                item.Display();

                if (item != tuoiMax && item.Age > tuoiMax.Age)
                {
                    tuoiMax = item;
                }

                tongTuoi += item.Age;

                if (item.Id % 2 == 0)
                {
                    idChan++;
                }
            }
            Console.WriteLine("Sinh vien co so tuoi lon nhat: ");
            tuoiMax.Display();
            Console.WriteLine("Tong so sinh vien co id chan: " + idChan);
            Console.WriteLine("Do tuoi trung binh cua sinh vien: " + Convert.ToDouble(tongTuoi) / Convert.ToDouble(arraySinhVien.Length));
            Console.WriteLine("Thong tin cac sinh vien co dia chi bat dau bang chu N: ");
            foreach (var item in arraySinhVien)
            {
                if (item.Address.StartsWith("N"))
                {
                    item.Display();
                }
            }
        }
           
    }

    class SinhVien
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public void Display()
        {
            Console.WriteLine("MSSV: " + Id);
            Console.WriteLine("TenSV: " + Name);
            Console.WriteLine("Tuoi: " + Age);
            Console.WriteLine("Dia chi: " + Address);
            Console.WriteLine("=========================================");
        }
    }
}

