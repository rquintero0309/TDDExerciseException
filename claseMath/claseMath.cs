﻿using System;
using System.Collections.Generic;

namespace claseMath
{
    public class claseMath
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subs(int a, int b)
        {
            return a - b;
        }

        public int Divide(int a, int b)
        {
            //if (b == 0) throw new InvalidOperationException() ;
            return a / b;
        }

        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i;
        }


    }
}
