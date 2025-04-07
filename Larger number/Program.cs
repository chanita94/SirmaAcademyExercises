namespace Larger_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a function that reads accepts two integers and prints the larger of the two.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}