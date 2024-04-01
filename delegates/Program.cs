using ArithmeticOperationsApp;

namespace MainProject {
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticChecker arithmeticChecker = new ArithmeticChecker();

            Predicate<int> isEvenPredicate = new Predicate<int>(arithmeticChecker.IsEven);
            Predicate<int> isOddPredicate = new Predicate<int>(arithmeticChecker.IsOdd);
            Predicate<int> isPrimePredicate = new Predicate<int>(arithmeticChecker.IsPrime);
            Predicate<int> isFibonacciPredicate = new Predicate<int>(arithmeticChecker.IsFibonacci);

            int number = 7;

            Console.WriteLine($"{number} is even: {isEvenPredicate(number)}");
            Console.WriteLine($"{number} is odd: {isOddPredicate(number)}");
            Console.WriteLine($"{number} is prime: {isPrimePredicate(number)}");
            Console.WriteLine($"{number} is Fibonacci: {isFibonacciPredicate(number)}");

            Console.ReadLine();
        }
    }
}