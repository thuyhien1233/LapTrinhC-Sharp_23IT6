// See https://aka.ms/new-console-template for more information
using System;

namespace DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yêu cầu người dùng nhập một số nguyên
            Console.Write("Nhap mot so nguyen: ");
            string input = Console.ReadLine();

            // Chuyển đổi chuỗi nhập vào thành số nguyên
            int number;
            if (int.TryParse(input, out number))
            {
                // Ép kiểu số nguyên sang số thực (double)
                double doubleNumber = (double)number;

                // Xuất kết quả ra màn hình
                Console.WriteLine($"So ban da nhap la {number} va o dang kep la {doubleNumber}");
            }
            else
            {
                // Xử lý trường hợp nhập không phải là số nguyên hợp lệ
                Console.WriteLine("Ban da nhap khong phai la mot so nguyen hop le.");
            }
        }
    }
}

