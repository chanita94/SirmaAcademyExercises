namespace Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a console program that reads a mark (real number) entered by the user and prints Excellent! if the mark is 5.50 or higher.
            double mark = double.Parse(Console.ReadLine());
            if(mark >=5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}