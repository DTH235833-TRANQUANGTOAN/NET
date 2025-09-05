using Bai6;
using System.Text;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write(" Nhập lương cơ bản: ");
        double luongCoBan = double.Parse(Console.ReadLine());
        Employee.SetBasicSalary(luongCoBan);

        int n;
        Console.Write(" Nhập số lượng nhân viên: ");
        n = int.Parse(Console.ReadLine());
        Employee[] arrEmployee = new Employee[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(" Nhập thông tin nhân viên thứ: " + (i + 1).ToString());
            arrEmployee[i] = new Employee();
            arrEmployee[i].nhap();
        }
        Console.WriteLine(" Danh sách nhân viên: ");
        Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-15}{4,-15}", "ID", "Họ tên", "Năm sinh", "Lương cơ bản", "Thu nhập");
        for (int i = 0; i < n; i++)
        {
            arrEmployee[i].xuat();
        }
        Console.ReadLine();
    }
}