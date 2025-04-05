namespace price_by_other_price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = 0.8 * first;
            double third = (second + first) * 1.15;
            double all = first + second + third;
            Console.WriteLine($"{all:f3}");
        }
    }
}
//For the furnishing of the office purchased 3 cabinets. One cabinet cost $n, the second
//was 20% cheaper than the first, and the third cost 15% more than the other two
//combined. From the console read the cost of the first cabinet – a real number.
//The output must be rounded to the third decimal point.