internal class Program
{
    private static void Main(string[] args)
    {
        int min = int.Parse(Console.ReadLine());
        int hour = 0;
        if (min < 10 )
        {
            hour = 0;
            Console.WriteLine($"0{hour}:0{min}");
        }
        else if (min < 60)
        {
            hour = 0;
            Console.WriteLine($"0{hour}:{min}");
        }
        else if(min>=60&&min<600)
        {
            hour = min / 60;
            min = min % 60;
            if (min < 10)
            {
                Console.WriteLine($"0{hour}:0{min}");
            }
            else
            {
                Console.WriteLine($"0{hour}:{min}");

            }

        }
        else if (min >= 600)
        {
            hour = min / 60;
            min = min % 60;
            if (min < 10)
            {
                Console.WriteLine($"{hour}:0{min}");
            }
            else
            {
                Console.WriteLine($"{hour}:{min}");

            }

        }
    }
}
