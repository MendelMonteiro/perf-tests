﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perf_tests_csharp.Challenge3
{
    public class Right
    {
        private static readonly List<decimal> _items;

        static Right()
        {
            _items = Enumerable.Repeat(42m, 50).ToList();
        }

        public static void Run()
        {
            _items.Sum();
        }
    }
}