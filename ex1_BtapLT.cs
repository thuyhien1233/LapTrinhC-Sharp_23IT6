// See https://aka.ms/new-console-template for more information
using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number > 0)
                {
                    Console.WriteLine($"{number} la so duong.");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"{number} la so am.");
                }
                else
                {
                    Console.WriteLine("So bang 0.");
                }
            }
            else
            {
                Console.WriteLine("Dau vao khong hop le. Vui long nhap mot so hop le.");
            }
        }
    }
}