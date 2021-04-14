using System;
using Xunit;

namespace InterviewTest.xUnit
{
    public class MixedServiceTests
    {
        MixedService _service;
        public MixedServiceTests()
        {
            _service = new MixedService();
        }

        [Fact]
        public void DummyService_HelloWorld_StringLongerThanZero()
        {
            string actual = _service.HelloWorld();

            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void DummyService_HelloWorld_ReturnsHelloWorld()
        {
            string actual = _service.HelloWorld();

            Assert.Same("Hello World", actual);
        }
    }
}
