using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace p25_euler
{
    static public class DigitCounter
    {
        static public int GetNumberOfDigits(BigInteger num)
        {
            return (int)Math.Floor(Math.Log10(Math.Abs((double)num)))+1;
        }


    }
}
