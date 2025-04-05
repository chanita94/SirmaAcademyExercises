namespace sirma_academy_homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Distance = int.Parse(Console.ReadLine());   
            int Hours = int.Parse(Console.ReadLine());   
            int Minutes = int.Parse(Console.ReadLine());   
            int Seconds = int.Parse(Console.ReadLine());
            double time = Seconds + Minutes * 60 + Hours * 60 * 60;
            double speed = Distance/ time;
            Console.WriteLine(time);
            Console.WriteLine(speed);
        }
    }
}