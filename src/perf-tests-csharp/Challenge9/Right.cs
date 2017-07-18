﻿using System;
using System.Linq;

namespace perf_tests_csharp.Challenge9
{
    public class Right
    {
        public static void Run(int count)
        {
            var primes = Enumerable.Range(0, count)
                                   .Where(IsPrime)
                                   .ToList();
        }

        private static bool IsPrime(int number)
        {
            if (number == 0 || number == 1) return false;
            if (number == 2) return true;

            for (var divisor = 2; divisor <= (int)Math.Floor(Math.Sqrt(number)); divisor++)
            {
                if (number % divisor == 0) return false;
            }
            return true;
        }
    }
}