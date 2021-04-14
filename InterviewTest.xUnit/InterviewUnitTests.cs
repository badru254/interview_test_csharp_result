using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InterviewTest.xUnit
{
    public class InterviewUnitTests
    {
        MixedService _mixedService;
        FizzBuzzService _fizzBuzzService;

        public InterviewUnitTests()
        {
            _mixedService = new MixedService();
            _fizzBuzzService = new FizzBuzzService();
        }

        [Fact]
        public void MixedService_HelloWorld_StringLongerThanZero()
        {
            string actual = _mixedService.HelloWorld();

            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void MixedService_HelloWorld_ReturnsHelloWorld()
        {
            string actual = _mixedService.HelloWorld();

            Assert.Equal("Hello World", actual);
        }

        [Theory]
        [MemberData(nameof(GetFizzBuzzTestData))]
        public void FizzBuzzService_CorrectOutput(int number, string expected)
        {
            string actual = _fizzBuzzService.PrintForNumber(number);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetFizzBuzzTestData()
        {
            int[] fizz = { 3, 6, 9, 12, 18, 21, 24, 27, 33, 36, 39, 42, 48, 51, 54, 57, 63, 66, 69, 72, 78, 81, 84, 87, 93, 96, 99 };
            int[] buzz = { 5, 10, 20, 25, 35, 40, 50, 55, 65, 70, 80, 85, 95, 100 };
            int[] fizzBuzz = { 15, 30, 45, 60, 75, 90 };

            return Enumerable.Range(1, 100).Select(number =>
            {
                if (fizz.Contains(number))
                {
                    return new object[] { number, "Fizz" };
                }
                else if (buzz.Contains(number))
                {
                    return new object[] { number, "Buzz" };
                }
                else if (fizzBuzz.Contains(number))
                {
                    return new object[] { number, "FizzBuzz" };
                }
                else
                {
                    return new object[] { number, number.ToString() };
                }
            });
        }
    }
}