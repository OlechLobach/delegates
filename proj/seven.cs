using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTaskApp
{
    public class PracticalTaskExecutor
    {
        public Action DisplayCurrentDate = () => Console.WriteLine(DateTime.Now.ToShortDateString());
        public Action DisplayCurrentTime = () => Console.WriteLine(DateTime.Now.ToShortTimeString());

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public double CalculateAverage(double[] numbers)
        {
            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        public double FindMax(double[] numbers)
        {
            double max = double.MinValue;
            foreach (var num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}