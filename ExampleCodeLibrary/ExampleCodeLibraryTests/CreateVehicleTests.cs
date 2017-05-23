using ExampleCodeLibrary.Model;
using ExampleCodeLibraryTests.TestLists;
using System;
using Xunit;

namespace xUnitTests
{
    public class CreateVehicleTests
    {
        [Fact]
        public void Car_Brakes_And_Accelerates_Correctly()
        {
            var car1 = new Car(166);
            var speed1 = car1.Accelarate(100);
            var speed2 = car1.Brake(200);

            Assert.Equal(100m, speed1);
            Assert.Equal(76m, speed2);
        }

        [Theory]
        [ClassData(typeof(VehicleAccelerateExceptionsList))]
        public void Accelerate_Throws_Correct_Errors(decimal testSpeed, string error)
        {
            var car = new Car(200);

            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => car.Accelarate(testSpeed));

            Assert.StartsWith(error, exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-120)]
        [InlineData(int.MinValue)]
        public void Car_Accelerates_Throws_Exceptions(int topspeed)
        {
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Car(topspeed));
            Assert.StartsWith("Topspeed should be positive", ex.Message);
        }
    }
}
