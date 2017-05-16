using ExampleCodeLibrary.Model;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Kernel;
using System;
using System.Collections.Generic;

namespace ExampleCodeLibraryTests.SpecBuilders
{
    internal class RandomVehicleListBuilder : ISpecimenBuilder
    {
        private readonly Random _random;
        private readonly Fixture _fixture;

        internal RandomVehicleListBuilder()
        {
            _random = new Random();
            _fixture = new Fixture();
        }
        public object Create(object request, ISpecimenContext context)
        {
            var sRequest = request as SeededRequest;
            if (sRequest != null)
            {
                var type2 = sRequest.Request as Type;
                return this.CreateRandom(type2);
            }
                

            var type = request as Type;
            if (type == null)
                return new NoSpecimen();

            return this.CreateRandom(type);
        }

        private object CreateRandom(Type type)
        {
            if (type == typeof(List<Vehicle>))
            {
                var list = new List<Vehicle>();
                var amount = _random.Next(1, 50);
                for (var i = 0; i < amount; i++)
                {                    
                    switch (_random.Next(1, 3))
                    {
                        case 1:
                            list.Add(_fixture.Create<Car>());
                            break;
                        case 2:
                            list.Add(_fixture.Create<Truck>());
                            break;
                    }
                }
                return list;
            }
            return new NoSpecimen();
        }
    }
}
