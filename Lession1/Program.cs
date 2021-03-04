using System;

namespace Lession1
{
    class Program
    {
        static void Main(string[] args)
        {
            //KiemTraLuong();
            //XetDiem();
            //TinhTienDien();
            //Tong100So();
            //ChiaHetCho3();
            //ChiaHetCho7();
            //InTamGiac1();
            InTamGiac2();
        }

        static void KiemTraLuong()
        {
            Console.Write("Luong cua nhan vien: ");
            var luongStr = Console.ReadLine();
            int luong = Convert.ToInt32(luongStr);
            if (luong < 500)
            {
                Console.WriteLine("Ban khong phai nop thue");
            }
            else
            {
                Console.WriteLine("So thue ma ban phai nop: " + luong * 0.1);
            }
        }

        static void XetDiem()
        {
            Console.Write("Diem cua hoc vien: ");
            var diemStr = Console.ReadLine();
            var diem = Convert.ToInt16(diemStr);
            if (diem < 50)
            {
                Console.WriteLine("Xep loai yeu");
            }
            else if (diem < 60)
            {
                Console.WriteLine("Xep loai TB");
            }
            else if (diem < 70)
            {
                Console.WriteLine("Xep loai TB kha");
            }
            else if (diem < 80)
            {
                Console.WriteLine("Xep loai kha");
            }
            else
            {
                Console.WriteLine("Xep loai gioi");
            }
        }

        static void TinhTienDien()
        {
            Console.Write("So KW tieu thu dien: ");
            var tieuhuStr = Console.ReadLine();
            var tieuthu = Convert.ToInt16(tieuhuStr);
            var giatien = TinhTienDienMethod(tieuthu);
            Console.WriteLine("Tong so tien dien truoc thue: " + giatien);
            Console.WriteLine("Tong so tien dien sau thue: " + giatien * 0.1);
        }

        static int TinhTienDienMethod(int tieuthu)
        {
            if (tieuthu <= 100)
            {
                return tieuthu * 450;
            }
            else if (tieuthu <= 200)
            {
                return (tieuthu - 100) * 600 + 450 * 100;
            }
            else if (tieuthu <= 300)
            {
                return (tieuthu - 200) * 750 + 600 * 100 + 450 * 100;
            }
            else if (tieuthu <= 500)
            {
                return (tieuthu - 300) * 900 + 100 * 750 + 600 * 100 + 450 * 100;
            }
            else if (tieuthu <= 1000)
            {
                return (tieuthu - 500) * 1000 + 200 * 900 + 100 * 750 + 600 * 100 + 450 * 100;
            }
            else if (tieuthu > 1000)
            {
                return (tieuthu - 1000) * 1200 + 500 * 1000 + 200 * 900 + 100 * 750 + 600 * 100 + 450 * 100;
            }

            return 0;
        }

        static void Tong100So()
        {
            var i = 1;
            var sum = 0;
            while (i <= 100)
            {
                sum += ++i;
            }
            Console.WriteLine("Tong: " + sum);
        }

        static void ChiaHetCho3()
        {
            int i = 20;
            Console.WriteLine("Cac so chia het cho 3: ");
            var temp = "";
            do
            {
                if (i % 3 == 0)
                {
                    temp += $"{i} ";
                }
                i++;
            } while (i <= 50);
            Console.WriteLine(temp);
        }

        static void ChiaHetCho7()
        {
            int i = 10;
            Console.WriteLine("Cac so chia het cho 7: ");
            var temp = "";
            do
            {
                if (i % 7 == 0)
                {
                    temp += $"{i} ";
                }
                i++;
            } while (i <= 70);
            Console.WriteLine(temp);
        }

        static void InTamGiac1()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        static void InTamGiac2()
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + j * i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
