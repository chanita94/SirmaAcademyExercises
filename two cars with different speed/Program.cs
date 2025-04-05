namespace two_cars_with_different_speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int car1Speed=int.Parse(Console.ReadLine());
            int car2Speed=int.Parse(Console.ReadLine());
            double distanceTwoHours = car1Speed * 2;
            double timeOfStartCar2 = distanceTwoHours / car2Speed;
            double timeToTheEnd = 3 - timeOfStartCar2;
            double car2Position = timeToTheEnd * car2Speed;
            double car1Position = timeToTheEnd * car1Speed;
            double distance = car2Position - car1Position;
            Console.WriteLine(distance);
        }
    }
}
//A car started from the city of Sofia to the city of Berlin at a speed of x km / h, and 2
//hours later another car went to the same destination at a speed y km / h. How many
//kilometers will be the distance between the two cars 3 hours after the departure of the
//second car?

