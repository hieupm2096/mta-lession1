using System;

namespace TinhTienDienThoai
{
    class Program
    {
        private const double tienThueBao = 27000;

        public double Length { get; set; }

        static void Main(string[] args)
        {

        }

        static double TienGoi(double soPhutGoi)
        {
            if (soPhutGoi <= 200)
            {
                return soPhutGoi * 120;
            }
            else if (soPhutGoi <= 400)
            {
                return (soPhutGoi - 200) * 80 + 200 * 120;
            }
            else
            {
                return (soPhutGoi - 400) * 40 + 200 * 80 + 200 * 120;
            }
        }
    }
}
