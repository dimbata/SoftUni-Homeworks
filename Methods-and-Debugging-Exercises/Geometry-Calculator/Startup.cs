namespace Longer_Line
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program that can calculate the area of four different geometry figures - triangle, square, rectangle and circle.
             * On the first line you will get the figure type.     
             * Next you will get parameters for the chosen figure, each on a different line:
             * •	Triangle - side and height
             * •	Square - side
             * •	Rectangle - width and height
             * •	Circle - radius
             * The output should be rounded to the second digit after the decimal point:
             */

            string figure = Console.ReadLine();

            double area = GetFigureArea(figure);

            Console.WriteLine($"{area:f2}");
        }

        public static double GetFigureArea(string figure)
        {
            switch (figure)
            {
                case "triangle":
                    return TriangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                case "square":
                    return SquareArea(double.Parse(Console.ReadLine()));
                case "rectangle":
                    return RectangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                case "circle":
                    return CircleArea(double.Parse(Console.ReadLine()));          
                default:
                    throw new ArgumentException("Wrong input!");
            }
        }

        public static double TriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }

        public static double SquareArea(double side)
        {
            return side * side;
        }

        public static double RectangleArea(double width, double height)
        {
            return width * height;
        }

        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}