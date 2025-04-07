using System.Drawing;

namespace Face_of_figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a function that takes the dimension of a geometric figure and calculates its face. The figures are of four types: square, rectangle, circle, and triangle.
            string figure = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double face = 0;
            if(figure == "square")
            {
                face = a * a;
            }
            else if (figure == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                face = a * b;
            }
            else if (figure== "circle")
            {
                face=Math.PI*a*a;
            }
            else
            {
                double heigth = double.Parse(Console.ReadLine());

                face = a*heigth/2;
            }

            Console.WriteLine($"{face:f2}");
        }
    }
}