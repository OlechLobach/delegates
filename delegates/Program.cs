using Helpers;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeHelper.DisplayCurrentTime();
            TimeHelper.DisplayCurrentDate();
            TimeHelper.DisplayCurrentDayOfWeek();

            Tuple<double, double, double> triangleSides = new Tuple<double, double, double>(3, 4, 5);
            if (GeometryHelper.IsTriangleValid(triangleSides))
            {
                double triangleArea = GeometryHelper.CalculateTriangleArea(triangleSides);
                Console.WriteLine($"Triangle area: {triangleArea}");
            }
            else
            {
                Console.WriteLine("Invalid triangle sides.");
            }

            Tuple<double, double> rectangleSides = new Tuple<double, double>(4, 5);
            double rectangleArea = GeometryHelper.CalculateRectangleArea(rectangleSides);
            Console.WriteLine($"Rectangle area: {rectangleArea}");

            Console.ReadKey();
        }
    }
}