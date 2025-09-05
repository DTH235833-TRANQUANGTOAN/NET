using Bai9;
using System.Text;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập các hệ số của phương trình bậc hai:");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());

        PhuongTrinhBac2 pt = new PhuongTrinhBac2(a, b, c);
        pt.HienThiKetQua();

        Console.WriteLine("\nPhương trình mặc định:");
        PhuongTrinhBac2 ptDefault = new PhuongTrinhBac2();
        ptDefault.HienThiKetQua();

        Console.ReadLine();
    }
}