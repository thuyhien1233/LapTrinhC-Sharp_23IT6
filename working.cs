using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Nhap chuoi cua ban: ");
        string userInput = Console.ReadLine();

        
        string reversedString = ReverseString(userInput);
        Console.WriteLine($"Chuoi dao nguoc: {reversedString}");

        
        Console.Write("Nhap chuoi tim kiem: ");
        string searchString = Console.ReadLine();

        
        int occurrences = CountOccurrences(userInput, searchString);
        Console.WriteLine($"So lan xuat hien cua '{searchString}': {occurrences}");

        
        Console.Write("Nhap chuoi con cu: ");
        string oldSubstring = Console.ReadLine();
        Console.Write("Nhap chuoi con moi: ");
        string newSubstring = Console.ReadLine();

        
        string modifiedString = ReplaceSubstring(userInput, oldSubstring, newSubstring);
        Console.WriteLine($"Chuoi da sua doi: {modifiedString}");

        string stringWithoutWhitespace = RemoveWhitespace(userInput);
        Console.WriteLine($"Chuoi khong co khoang trang: {stringWithoutWhitespace}");
    }

    static string ReverseString(string inputString)
    {
        char[] charArray = inputString.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static int CountOccurrences(string inputString, string searchString)
    {
        int count = 0;
        int startIndex = 0;

        while ((startIndex = inputString.IndexOf(searchString, startIndex, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            startIndex += searchString.Length;
        }

        return count;
    }

    static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
    {
        return inputString.Replace(oldSubstring, newSubstring);
    }

    static string RemoveWhitespace(string inputString)
    {
        return string.Concat(inputString.Where(c => !char.IsWhiteSpace(c)));
    }
}
