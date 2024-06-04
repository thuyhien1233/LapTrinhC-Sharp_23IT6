// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot loat cac so (nhap 0 de ket thuc):");

        int sum = 0;
        while (true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            if (number < 0)
            {
                continue;
            }

            sum += number;
        }

        Console.WriteLine($"Tong cua cac so duong da nhap la: {sum}");
    }
}

