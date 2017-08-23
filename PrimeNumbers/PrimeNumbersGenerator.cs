using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    public class PrimeNumbersGenerator
    {
        public List<int> GetNumbers(int numbersLessThan)
        {
            if (numbersLessThan < 3)
                throw new ArgumentException();
            var sequence = new List<int>();
            for(int i = 2; i < numbersLessThan; i++)
            {
                bool isPrime = true;
                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    sequence.Add(i); 
            }
            return sequence;
        }
    }
}
