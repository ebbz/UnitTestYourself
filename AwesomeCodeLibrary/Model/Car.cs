namespace AwesomeCodeLibrary.Model
{
    public class Car : Vehicle
    {
        public Car(int topSpeed) : base (topSpeed)
        {
            SpeedLimit = 130;
            BrakeSpeedInMeterPerSecond = 12;
        }
    }
}
