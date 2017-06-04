﻿namespace perf_tests_csharp.Challenge2bis
{
    public class Left
    {
        public static unsafe void Run(int value, int[] items)
        {
            fixed (int* p = items)
            {
                for (var index = 0; index < items.Length; index++)
                {
                    if (p[index] == value)
                    {
                        break;
                    }
                }
            }
        }
    }
}