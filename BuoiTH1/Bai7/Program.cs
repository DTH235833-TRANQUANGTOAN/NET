using Bai7;
using System.Text;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập 3 cạnh của tam giác:");
        Console.Write("Cạnh 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Cạnh 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Cạnh 3: ");
        int c = int.Parse(Console.ReadLine());

        TamGiac tg1 = new TamGiac(a, b, c);
        Console.WriteLine("\nThông tin tam giác bạn vừa nhập:");
        tg1.HienThi();

        Console.WriteLine("\nThông tin tam giác mặc định:");
        TamGiac tg2 = new TamGiac();
        tg2.HienThi();

        Console.ReadLine();
    }
}