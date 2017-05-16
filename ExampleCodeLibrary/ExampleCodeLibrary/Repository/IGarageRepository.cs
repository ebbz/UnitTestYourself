using AwesomeCodeLibrary.Model;
using System.Collections.Generic;

namespace AwesomeCodeLibrary.Repository
{
    public interface IGarageRepository
    {
        List<Vehicle> StoredVehicles();
        List<Vehicle> StoredVehicles(VehicleType vehicleType);
        void ParkVehicle(Vehicle vehicle);
        Vehicle TakeVehicle(VehicleType vehicleType);
    }
}
