﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day_of_the_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a function that receives an integer and prints a day of the week (in English), within the limits[1...7] or prints Error in case the entered number is invalid.
            int day = int.Parse(Console.ReadLine());
            switch (day) 
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}