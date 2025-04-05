namespace yellow_red_and_white_paint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paint = int.Parse(Console.ReadLine());
            double yellow = paint/13*4;
            double red = paint/13*1;
            double white = paint/13*8;
            
            Console.WriteLine($"Red:{red:f4}");
            Console.WriteLine($"Yellow:{yellow:f4}");
            Console.WriteLine($"White:{white:f4}");
        }
    }
}
//To get the desired color, they mixed yellow, red and white paint. The yellow paint was 4 times more
//than the red and 2 times less than the white. How many kilograms of each color did they
//spend on painting a room?