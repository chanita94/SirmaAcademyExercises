﻿namespace Even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a function that receives an integer and prints on the console, whether even or odd.
            int n = int.Parse(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}