using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperationsApp
{
    public class ArithmeticChecker
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public bool IsFibonacci(int number)
        {
            return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
        }

        private bool IsPerfectSquare(int number)
        {
            int squareRoot = (int)Math.Sqrt(number);
            return squareRoot * squareRoot == number;
        }
    }
}
