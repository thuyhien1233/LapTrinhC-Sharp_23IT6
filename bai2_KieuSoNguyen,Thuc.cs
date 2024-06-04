using System;

namespace NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bài 2a: Viết một chương trình nhận vào một dãy số nguyên có dấu kích thước 1 byte từ người dùng và tìm số lớn nhất và nhỏ nhất trong dãy số đó. In kết quả lên màn hình.
            sbyte[] numbers;
            sbyte n, max, min;
            while (true)
            {
                try
                {
                    Console.Write("Nhap so luong phan tu trong mang: ");
                    n = sbyte.Parse(Console.ReadLine());
                    if (n > 0)
                        break;
                    else
                        Console.WriteLine("So luong phan tu phai lon hon 0.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Loi: vui long nhap so nguyen co dau hop le.");
                }
            }

            numbers = new sbyte[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Nhap so nguyen co dau thu {i + 1} (1 byte): ");
                        numbers[i] = sbyte.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Loi: vui long nhap so nguyen co dau hop le.");
                    }
                }
            }
            max = min = numbers[0];
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
            }
            Console.WriteLine();
            Console.WriteLine($"So lon nhat trong mang: {max}");
            Console.WriteLine($"So nho nhat trong mang: {min}");

            // Bài 2b: Viết một chương trình nhận vào một dãy số nguyên có dấu kích thước 1 byte từ người dùng và tính tổng các số chẵn trong dãy số đó. In kết quả lên màn hình.
            sbyte[] numbers2;
            sbyte n2, sum = 0;
            while (true)
            {
                try
                {
                    Console.Write("Nhap so luong phan tu trong mang: ");
                    n2 = sbyte.Parse(Console.ReadLine());
                    if (n2 > 0)
                        break;
                    else
                        Console.WriteLine("So luong phan tu phai lon hon 0.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Loi: vui long nhap so nguyen co dau hop le.");
                }
            }
            numbers2 = new sbyte[n2];
            for (int i = 0; i < n2; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Nhap so nguyen co dau thu {i + 1} (1 byte): ");
                        numbers2[i] = sbyte.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Loi: vui long nhap so nguyen co dau hop le.");
                    }
                }
                if (numbers2[i] % 2 == 0)
                    sum += numbers2[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua cac so chan trong mang: {sum}");

            // Bài 2c: Viết một chương trình nhận vào một số nguyên n không dấu kích thước 1 byte từ người dùng và tính tổng của các số từ 1 đến n. In kết quả lên màn hình.
            byte n3;
            uint sum3 = 0;
            while (true)
            {
                try
                {
                    Console.Write("Nhap so nguyen khong dau (1 byte): ");
                    n3 = byte.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Loi: vui long nhap so nguyen khong dau hop le.");
                }
            }
            for (byte i = 1; i <= n3; i++)
            {
                sum3 += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua cac so tu 1 den {n3}: {sum3}");

            // Bài 2d: Viết một chương trình nhận vào một số nguyên không dấu kiểu byte từ người dùng và tính tổng của các chữ số trong số đó. In kết quả lên màn hình.
            byte n4, sum4 = 0;
            while (true)
            {
                try
                {
                    Console.Write("Nhap so nguyen khong dau (1 byte): ");
                    n4 = byte.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Loi: vui long nhap so nguyen khong dau hop le.");
                }
            }
            while (n4 > 0)
            {
                sum4 += (byte)(n4 % 10);
                n4 /= 10;
            }

            Console.WriteLine();
            Console.WriteLine($"Tong cua cac so vua nhap la: {sum4}");
        }
    }
}