using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace p25_euler
{
    static public class DigitCounter
    {
        static public int GetNumberOfDigitsPosNum(BigInteger num)
        {
            return num.ToString().Length;
        }


    }
}
