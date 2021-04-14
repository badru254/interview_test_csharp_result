using System;

namespace InterviewTest
{
    public class FizzBuzzService
    {
        /// <summary>
        /// Returns the FizzBuzz output for the specified integer number
        /// It should output the number itself except for the following cases
        /// 1. If the number if a multiple of 3 then it should output Fizz
        /// 2. If the number is a multiple of 5 then it should output Buzz
        /// 3. If the number is a multiple of both 3 and 5 then it should output FizzBuzz
        /// Example run from 1 to 15: [1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz]
        /// </summary>
        public string PrintForNumber(int number)
        {
            return number.ToString();
        }

        /// <summary>
        /// Writes to console FizzBuzz from one until the specified number until parameter (defaults to 100).
        /// </summary>
        public void ToConsole(int numberUntil = 100)
        {
            for (int i = 1; i <= numberUntil; i++)
            {
                Console.WriteLine(PrintForNumber(i));
            }
        }
    }
}
