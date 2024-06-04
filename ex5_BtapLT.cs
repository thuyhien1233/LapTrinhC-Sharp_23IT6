// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Tạo số bí mật ngẫu nhiên từ 1 đến 100

        Console.WriteLine("Chao mung ban den voi tro choi doan so!");
        Console.WriteLine("Chon mot so tu 1 den 100. Hay doan so dung.");

        int guess;
        while (true)
        {
            Console.Write("Nhap so ban doan: ");
            guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Chuc mung! Ban da doan dung.");
                break;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("So ban doan nho hon so bi mat. Hay thu lai.");
            }
            else
            {
                Console.WriteLine("So ban doan lon hon so bi mat. Hay thu lai.");
            }
        }
    }
}

