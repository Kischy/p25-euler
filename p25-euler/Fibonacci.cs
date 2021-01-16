using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace p25_euler
{
    public class Fibonacci
    {
        private BigInteger Fn_m1;
        private BigInteger Fn_m2;


        public int Index
        {
            get;
        }

        public Fibonacci()
        {
            Fn_m1 = 1;
            Fn_m2 = 1;
            Index = 2;
        }

        public BigInteger getNextFibonacci()
        {
            return 0;
        }


    }
}
