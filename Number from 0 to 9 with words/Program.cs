using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Number_from_0_to_9_with_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a function that gets an integer in the range [0... 9] and spells it out in words in English.If the number is out of range, it spells out too big.
            int number = int.Parse(Console.ReadLine()); ;
            switch (number)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eigth");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("too big");
                    break;
            }
        }
    }
}