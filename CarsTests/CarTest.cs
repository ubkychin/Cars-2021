using System;
using Xunit;
using CarsLib;

namespace CarsTests
{
    public class CarTest
    {

        Car testCar;

        public CarTest() {
            testCar = new Car("ABC123", 0);
        }

        [Theory]
        [InlineData("ABC1AA", "ABC1")]
        [InlineData("ABC123", "ABC1231")]
        [InlineData("ZXC789", "ZXC789")]
        [InlineData("AAAAAA", "")]
        [InlineData("!@#$%^", "!@#$%^")]
        public void SetRegoTest(string expected, string input)
        {
            this.testCar.SetRego(input);
            Assert.Equal(expected, this.testCar.Rego);
        }

        [Theory]
        [InlineData(130, 140)]
        [InlineData(0, 0)]
        [InlineData(-10, -120)]
        [InlineData(130, 130)]
        [InlineData(-10, -10)]
        public void AddSpeedTest(int expected, int input)
        {
            this.testCar.AddSpeed(input);
            Assert.Equal(expected, this.testCar.Speed);
        }
    }
}
