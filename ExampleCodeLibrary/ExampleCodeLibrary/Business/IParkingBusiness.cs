using ExampleCodeLibrary.Model;

namespace ExampleCodeLibrary.Business
{
    public interface IParkingBusiness
    {
        int AmountOfVehicles();
        int AmountOfVehicles(VehicleType vehicleType);
    }
}
