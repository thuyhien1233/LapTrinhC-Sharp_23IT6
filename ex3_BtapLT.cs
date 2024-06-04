// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so hang:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap so cot:");
        int columns = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
