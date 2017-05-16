using ExampleCodeLibrary.Model;
using System.Collections.Generic;

namespace ExampleCodeLibrary.Repository
{
    public interface IGarageRepository
    {
        List<Vehicle> StoredVehicles();
        List<Vehicle> StoredVehicles(VehicleType vehicleType);
        void ParkVehicle(Vehicle vehicle);
        Vehicle TakeVehicle(VehicleType vehicleType);
    }
}
