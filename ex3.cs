using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Vui long nhap ki tu: ");

        
        string userInput = Console.ReadLine();

        
        if (!string.IsNullOrEmpty(userInput) && userInput.Length == 1)
        {
            
            char character = userInput[0];

            
            int asciiCode = (int)character;

            
            Console.WriteLine($"Ky tu ban nhap la '{character}', ma ASCII cua no la {asciiCode}");
        }
        else
        {
            Console.WriteLine("Dau vao khong hop le. Vui long nhap mot ki tu");
        }
    }
}
