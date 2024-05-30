// See https://aka.ms/new-console-template for more information
using System;

namespace DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yêu cầu người dùng nhập một số thực
            Console.Write("Nhap mot so thuc: ");
            string input = Console.ReadLine();

            // Chuyển đổi chuỗi nhập vào thành số thực
            double number;
            if (double.TryParse(input, out number))
            {
                // Ép kiểu số thực sang số nguyên (int)
                int intNumber = (int)number;

                // Ép kiểu số thực sang số dài (long)
                long longNumber = (long)number;

                // Xuất kết quả ra màn hình
                Console.WriteLine($"So ban da nhap la {number}, so nguyen la {intNumber} va so dai la {longNumber}");
            }
            else
            {
                // Xử lý trường hợp nhập không phải là số thực
                Console.WriteLine("Ban da nhap khong phai la mot so thuc hop le.");
            }
        }
    }
}

