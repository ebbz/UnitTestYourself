using AwesomeCodeLibrary.Repository;
using AwesomeCodeLibrary.Model;

namespace AwesomeCodeLibrary.Business.Implementations
{
    public class ParkingBusiness : IParkingBusiness
    {
        private readonly IGarageRepository _garageRepository;
        public ParkingBusiness(IGarageRepository garageRepo)
        {
            _garageRepository = garageRepo;
        }

        public int AmountOfVehicles()
        {
            return _garageRepository.StoredVehicles().Count;
        }

        public int AmountOfVehicles(VehicleType vehicleType)
        {
            return _garageRepository.StoredVehicles(vehicleType).Count;
        }
    }
}
