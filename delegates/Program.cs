using System;
using ArrayOperations;
namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            ArrayOperations operations = new ArrayOperations(array);

            operations.EvenNumbersFound += (sender, result) =>
            {
                Console.WriteLine("Even numbers:");
                foreach (var num in result)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            };
            operations.GetEvenNumbers();

            operations.OddNumbersFound += (sender, result) =>
            {
                Console.WriteLine("Odd numbers:");
                foreach (var num in result)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            };
            operations.GetOddNumbers();

            operations.PrimeNumbersFound += (sender, result) =>
            {
                Console.WriteLine("Prime numbers:");
                foreach (var num in result)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            };
            operations.GetPrimeNumbers();

            operations.FibonacciNumbersFound += (sender, result) =>
            {
                Console.WriteLine("Fibonacci numbers:");
                foreach (var num in result)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            };
            operations.GetFibonacciNumbers();

            Console.ReadKey();
        }
    }
}