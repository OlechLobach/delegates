using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    public delegate void ArrayOperationEventHandler(object sender, List<int> result);

    public class ArrayOperations
    {
        private int[] _array;

        public event ArrayOperationEventHandler EvenNumbersFound;
        public event ArrayOperationEventHandler OddNumbersFound;
        public event ArrayOperationEventHandler PrimeNumbersFound;
        public event ArrayOperationEventHandler FibonacciNumbersFound;

        public ArrayOperations(int[] array)
        {
            _array = array;
        }

        public void GetEvenNumbers()
        {
            List<int> result = new List<int>();
            foreach (var num in _array)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }
            }
            EvenNumbersFound?.Invoke(this, result);
        }

        public void GetOddNumbers()
        {
            List<int> result = new List<int>();
            foreach (var num in _array)
            {
                if (num % 2 != 0)
                {
                    result.Add(num);
                }
            }
            OddNumbersFound?.Invoke(this, result);
        }

        public void GetPrimeNumbers()
        {
            List<int> result = new List<int>();
            foreach (var num in _array)
            {
                if (IsPrime(num))
                {
                    result.Add(num);
                }
            }
            PrimeNumbersFound?.Invoke(this, result);
        }

        private bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void GetFibonacciNumbers()
        {
            List<int> result = new List<int>();
            int a = 0, b = 1;
            while (b <= _array[_array.Length - 1])
            {
                if (Array.IndexOf(_array, b) != -1)
                {
                    result.Add(b);
                }
                int temp = a;
                a = b;
                b = temp + b;
            }
            FibonacciNumbersFound?.Invoke(this, result);
        }
    }
}
