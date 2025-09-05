using System;

namespace Bai9
{
    public class PhuongTrinhBac2
    {
        // Thuộc tính
        private int soa;
        private int sob;
        private int soc;

        // Property
        public int Soa
        {
            get => soa;
            set => soa = value;
        }
        public int Sob
        {
            get => sob;
            set => sob = value;
        }
        public int Soc
        {
            get => soc;
            set => soc = value;
        }

        // Constructor không tham số
        public PhuongTrinhBac2()
        {
            soa = 1;
            sob = 1;
            soc = 1;
        }

        // Constructor có tham số
        public PhuongTrinhBac2(int a, int b, int c)
        {
            soa = a;
            sob = b;
            soc = c;
        }

        // Phương thức tính nghiệm
        public void TinhNghiem(out double? x1, out double? x2)
        {
            x1 = null;
            x2 = null;
            if (soa == 0)
            {
                if (sob == 0)
                {
                    // Phương trình vô nghiệm hoặc vô số nghiệm
                    return;
                }
                else
                {
                    x1 = -((double)soc / sob);
                    return;
                }
            }
            double delta = sob * sob - 4 * soa * soc;
            if (delta < 0)
            {
                // Vô nghiệm
                return;
            }
            else if (delta == 0)
            {
                x1 = x2 = -((double)sob) / (2 * soa);
            }
            else
            {
                x1 = (-sob + Math.Sqrt(delta)) / (2 * soa);
                x2 = (-sob - Math.Sqrt(delta)) / (2 * soa);
            }
        }

        // Phương thức hiện kết quả
        public void HienThiKetQua()
        {
            Console.WriteLine($"Phương trình: {soa}x^2 + {sob}x + {soc} = 0");
            TinhNghiem(out double? x1, out double? x2);
            if (soa == 0)
            {
                if (sob == 0)
                {
                    Console.WriteLine(soc == 0 ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.");
                }
                else
                {
                    Console.WriteLine($"Phương trình có một nghiệm: x = {x1}");
                }
                return;
            }
            double delta = sob * sob - 4 * soa * soc;
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {x1}");
            }
            else
            {
                Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
            }
        }
    }
}