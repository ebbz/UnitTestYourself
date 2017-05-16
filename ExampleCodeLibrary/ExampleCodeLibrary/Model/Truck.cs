namespace AwesomeCodeLibrary.Model
{
    public class Truck : Vehicle
    {
        public Truck(int topSpeed) : base(topSpeed)
        {
            SpeedLimit = 80;
        }
    }
}
