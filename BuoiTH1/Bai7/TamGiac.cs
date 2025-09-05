using System;

namespace Bai7
{
    public class TamGiac
    {
        // Thuộc tính
        private int canh1;
        private int canh2;
        private int canh3;
        private float dienTich;
        private int chuVi;
        private string loaiTamGiac;

        // Property
        public int Canh1
        {
            get => canh1;
            set => canh1 = value;
        }
        public int Canh2
        {
            get => canh2;
            set => canh2 = value;
        }
        public int Canh3
        {
            get => canh3;
            set => canh3 = value;
        }
        public float DienTich => dienTich;
        public int ChuVi => chuVi;
        public string LoaiTamGiac => loaiTamGiac;

        // Constructor không tham số
        public TamGiac()
        {
            canh1 = 2;
            canh2 = 3;
            canh3 = -5;
            TinhChuVi();
            TinhDienTich();
            XacDinhLoai();
        }

        // Constructor có tham số
        public TamGiac(int a, int b, int c)
        {
            canh1 = a;
            canh2 = b;
            canh3 = c;
            TinhChuVi();
            TinhDienTich();
            XacDinhLoai();
        }

        // Phương thức tính chu vi
        public void TinhChuVi()
        {
            chuVi = canh1 + canh2 + canh3;
        }

        // Phương thức tính diện tích
        public void TinhDienTich()
        {
            float p = chuVi / 2.0f;
            if (canh1 > 0 && canh2 > 0 && canh3 > 0 && canh1 + canh2 > canh3 && canh1 + canh3 > canh2 && canh2 + canh3 > canh1)
            {
                dienTich = (float)Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
            }
            else
            {
                dienTich = 0;
            }
        }

        // Xác định loại tam giác
        public void XacDinhLoai()
        {
            if (canh1 <= 0 || canh2 <= 0 || canh3 <= 0 || canh1 + canh2 <= canh3 || canh1 + canh3 <= canh2 || canh2 + canh3 <= canh1)
            {
                loaiTamGiac = "Không hợp lệ";
            }
            else if (canh1 == canh2 && canh2 == canh3)
            {
                loaiTamGiac = "Tam giác đều";
            }
            else if (canh1 == canh2 || canh1 == canh3 || canh2 == canh3)
            {
                loaiTamGiac = "Tam giác cân";
            }
            else
            {
                loaiTamGiac = "Tam giác thường";
            }
        }

        // Phương thức hiển thị thông tin
        public void HienThi()
        {
            Console.WriteLine("Cạnh 1: {0}", canh1);
            Console.WriteLine("Cạnh 2: {0}", canh2);
            Console.WriteLine("Cạnh 3: {0}", canh3);
            Console.WriteLine("Chu vi: {0}", chuVi);
            Console.WriteLine("Diện tích: {0}", dienTich);
            Console.WriteLine("Loại tam giác: {0}", loaiTamGiac);
        }
    }
}