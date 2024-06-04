// See https://aka.ms/new-console-template for more information
using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of the day of the week (1-7): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int dayNumber))
            {
                if (dayNumber >= 1 && dayNumber <= 7)
                {
                    string dayName;
                    switch (dayNumber)
                    {
                        case 1:
                            dayName = "Monday";
                            break;
                        case 2:
                            dayName = "Tuesday";
                            break;
                        case 3:
                            dayName = "Wednesday";
                            break;
                        case 4:
                            dayName = "Thursday";
                            break;
                        case 5:
                            dayName = "Friday";
                            break;
                        case 6:
                            dayName = "Saturday";
                            break;
                        case 7:
                            dayName = "Sunday";
                            break;
                        default:
                            dayName = "Invalid input";
                            break;
                    }

                    Console.WriteLine($"The day of the week is: {dayName}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}