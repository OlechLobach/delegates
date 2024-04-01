using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class TimeHelper
    {
        public static void DisplayCurrentTime()
        {
            Console.WriteLine($"Current time: {DateTime.Now.ToShortTimeString()}");
        }

        public static void DisplayCurrentDate()
        {
            Console.WriteLine($"Current date: {DateTime.Now.ToShortDateString()}");
        }

        public static void DisplayCurrentDayOfWeek()
        {
            Console.WriteLine($"Current day of week: {DateTime.Now.DayOfWeek}");
        }
    }

    public static class GeometryHelper
    {
        public static bool IsTriangleValid(Tuple<double, double, double> sides)
        {
            double a = sides.Item1;
            double b = sides.Item2;
            double c = sides.Item3;
            return a + b > c && a + c > b && b + c > a;
        }

        public static double CalculateTriangleArea(Tuple<double, double, double> sides)
        {
            double a = sides.Item1;
            double b = sides.Item2;
            double c = sides.Item3;
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double CalculateRectangleArea(Tuple<double, double> sides)
        {
            double a = sides.Item1;
            double b = sides.Item2;
            return a * b;
        }
    }
}