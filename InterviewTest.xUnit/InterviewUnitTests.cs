using InterviewTest.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InterviewTest.xUnit
{
    public class InterviewUnitTests
    {
        private readonly MixedService _mixedService;
        private readonly FizzBuzzService _fizzBuzzService;
        private readonly Person[] _people;

        public InterviewUnitTests()
        {
            _mixedService = new MixedService();
            _fizzBuzzService = new FizzBuzzService();
            _people = new Person[]
            {
                new Person
                {
                    Name = "Javier",
                    Age = 37,
                    PhoneNumber = "(123)-456-7890"
                },
                new Person
                {
                    Name = "Peter",
                    Age = 22,
                    PhoneNumber = "(302)169-4921"
                },
                new Person
                {
                    Name = "Jacob",
                    Age = 65,
                    PhoneNumber = "(416)593-8273"
                },
                new Person
                {
                    Name = "Peter",
                    Age = 58,
                    PhoneNumber = "(650)321-3212"
                }
            };
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

        [Fact]
        public void MixedService_GetAlphabeticalArray_Test1()
        {
            string[] input = new string[] { "Romeo", "Alpha", "Omega", "John" };
            string[] sortedOutput = _mixedService.GetAlphabeticalArray(input);

            Assert.Collection(sortedOutput,
                item => Assert.Equal("Alpha", item),
                item => Assert.Equal("John", item),
                item => Assert.Equal("Omega", item),
                item => Assert.Equal("Romeo", item)
            );
        }

        [Fact]
        public void MixedService_GetAlphabeticalArray_Test2()
        {
            string[] input = new string[] { "private", "Apple", "Orange", "Banana", "10 people" };
            string[] sortedOutput = _mixedService.GetAlphabeticalArray(input);

            Assert.Collection(sortedOutput,
                item => Assert.Equal("10 people", item),
                item => Assert.Equal("Apple", item),
                item => Assert.Equal("Banana", item),
                item => Assert.Equal("Orange", item),
                item => Assert.Equal("private", item)
            );
        }

        [Fact]
        public void MixedService_FindPersonByName_FoundOne_ReturnsFound()
        {
            Person person = _mixedService.FindPersonByName("Javier", _people);

            Assert.Same(person, _people[0]);
        }

        [Fact]
        public void MixedService_FindPersonByName_NonExisting_ReturnNull()
        {
            Person person = _mixedService.FindPersonByName("Guillermo", _people);

            Assert.Null(person);
        }

        [Fact]
        public void MixedService_FindPersonByName_CaseDifferent_ReturnsMatch()
        {
            Person person = _mixedService.FindPersonByName("jacob", _people);

            Assert.Same(person, _people[2]);
        }

        [Fact]
        public void MixedService_FindPersonByName_FoundMultiple_ReturnNull()
        {
            Person person = _mixedService.FindPersonByName("Peter", _people);

            Assert.Null(person);
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
