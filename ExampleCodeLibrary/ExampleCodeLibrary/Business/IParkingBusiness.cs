using AwesomeCodeLibrary.Model;

namespace AwesomeCodeLibrary.Business
{
    public interface IParkingBusiness
    {
        int AmountOfVehicles();
        int AmountOfVehicles(VehicleType vehicleType);
    }
}
