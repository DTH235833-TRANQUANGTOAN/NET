using System;

namespace Bai6
{
    public class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private static double basicSalary;

        public int GetId() => id;
        public string GetName() => name;
        public int GetYearOfBirth() => yearOfBirth;
        public double GetIncome() => salaryLevel * basicSalary;

        public void SetSalaryLevel(double bacLuong) => salaryLevel = bacLuong;
        public static void SetBasicSalary(double luongCoBan) => basicSalary = luongCoBan;

        public void nhap()
        {
            Console.Write(" Nhập định danh: ");
            id = int.Parse(Console.ReadLine());
            Console.Write(" Nhập họ tên: ");
            name = Console.ReadLine();
            Console.Write(" Nhập năm sinh: ");
            yearOfBirth = int.Parse(Console.ReadLine());
            Console.Write(" Nhập bậc lương: ");
            salaryLevel = double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-15}{4,-15}", id, name, yearOfBirth, basicSalary, GetIncome());
        }
    }
}