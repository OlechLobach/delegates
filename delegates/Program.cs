using PracticalTaskApp;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticalTaskExecutor executor = new PracticalTaskExecutor();

            Action<string> displayAction = executor.DisplayMessage;
            Func<double[], double> averageFunc = executor.CalculateAverage;
            Func<double[], double> maxFunc = executor.FindMax;

            double[] numbers = { 1.5, 2.7, 3.8, 4.1, 5.3 };

            displayAction.Invoke("Current date:");
            executor.DisplayCurrentDate.Invoke();
            displayAction.Invoke("");

            displayAction.Invoke("Current time:");
            executor.DisplayCurrentTime.Invoke();
            displayAction.Invoke("");

            displayAction.Invoke("Average:");
            double average = averageFunc.Invoke(numbers);
            displayAction.Invoke(average.ToString());

            displayAction.Invoke("");

            displayAction.Invoke("Maximum:");
            double max = maxFunc.Invoke(numbers);
            displayAction.Invoke(max.ToString());

            Console.ReadLine();
        }
    }
}