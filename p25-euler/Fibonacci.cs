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
        private int index;


        public int Index
        {
            get
            {
                return index;
            }
        }

        public Fibonacci()
        {
            Fn_m1 = 1;
            Fn_m2 = 1;
            index = 2;
        }

        public BigInteger GetNextFibonacci()
        {
            index++;

            BigInteger nextFibonacci = Fn_m2 + Fn_m1;

            Fn_m2 = Fn_m1;
            Fn_m1 = nextFibonacci;

            return nextFibonacci;
        }


    }
}
