using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        Console.Write("Nhap so phan tu trong mang: ");
        string sizeInput = Console.ReadLine();
        int size;

        
        if (!int.TryParse(sizeInput, out size) || size <= 0)
        {
            Console.WriteLine("Dau vao khong hop le. Vui long nhap so nguyen duong");
            return;
        }

        
        int[] numbers = new int[size];

       
        Console.WriteLine("Nhap cac phan tu cua mang:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Yeu to {i + 1}: ");
            string elementInput = Console.ReadLine();
            int element;

            
            if (!int.TryParse(elementInput, out element))
            {
                Console.WriteLine("Dau vao khong hop le. Vui long nhap mot so nguyen");
                i--; 
            }
            else
            {
                numbers[i] = element;
            }
        }

        
        int maxValue = numbers.Max();

        
        Console.WriteLine($"Gia tri lon nhat trong mang la {maxValue}");
    }
}
