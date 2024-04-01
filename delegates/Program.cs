using ArithmeticApp;

namespace MainProject{
    public delegate int ArithmeticOperationDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            ArithmeticOperationDelegate addDelegate = new ArithmeticOperationDelegate(calculator.Add);
            ArithmeticOperationDelegate subtractDelegate = new ArithmeticOperationDelegate(calculator.Subtract);
            ArithmeticOperationDelegate multiplyDelegate = new ArithmeticOperationDelegate(calculator.Multiply);

            int x = 10;
            int y = 5;

            Console.WriteLine($"{x} + {y} = {addDelegate(x, y)}");
            Console.WriteLine($"{x} - {y} = {subtractDelegate(x, y)}");
            Console.WriteLine($"{x} * {y} = {multiplyDelegate(x, y)}");

            Console.ReadLine();
        }
    }
}