using ExampleCodeLibrary.Business;
using ExampleCodeLibrary.Business.Implementations;
using ExampleCodeLibrary.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Xunit;
using ExampleCodeLibrary.Model;
using Ploeh.AutoFixture.Kernel;
using ExampleCodeLibraryTests.SpecBuilders;

namespace ExampleCodeLibraryTests
{
    public class ParkingBusinessTests
    {
        private readonly IParkingBusiness _parkingBusiness;
        private readonly Mock<IGarageRepository> _garageRepository;
        private readonly Fixture fixture;

        public ParkingBusinessTests()
        {
            fixture = new Fixture();
            fixture.Customizations.Add(new RandomVehicleListBuilder());
            _garageRepository = new Mock<IGarageRepository>();
            _parkingBusiness = new ParkingBusiness(_garageRepository.Object);
        }

        [Fact]
        public void Test_AmountOfVehicles()
        {
            List<Vehicle> vehicles = fixture.Create<List<Vehicle>>();
            _garageRepository.Setup(g => g.StoredVehicles()).Returns(vehicles);

            var result = _parkingBusiness.AmountOfVehicles();

            Assert.Equal(vehicles.Count, result);
        }

        [Fact]
        public void Test_AmountOfCars()
        {
            List<Vehicle> vehicles = fixture.Create<List<Vehicle>>();
            _garageRepository.Setup(g => g.StoredVehicles(VehicleType.Car)).Returns(vehicles.Where(v => v.GetType() == typeof(Car)).ToList());

            var result = _parkingBusiness.AmountOfVehicles(VehicleType.Car);

            Assert.Equal(vehicles.Count(v => v.GetType() == typeof(Car)), result);
        }
    }
}
