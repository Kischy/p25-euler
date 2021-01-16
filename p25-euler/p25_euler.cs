using System;

namespace p25_euler
{
    class p25_euler
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculation started");


            Fibonacci fibonacci = new Fibonacci();


            while(DigitCounter.GetNumberOfDigitsPosNum(fibonacci.GetNextFibonacci()) != 1000)
            {
            }

            int answer_p25 = fibonacci.Index;

            Console.WriteLine("The answer to problem 24 of project Euler is " + answer_p25 + ".");
        }
    }
}
