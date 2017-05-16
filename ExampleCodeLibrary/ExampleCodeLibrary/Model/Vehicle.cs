using System;

namespace ExampleCodeLibrary.Model
{
    public abstract class Vehicle
    {
        private decimal _speedInKmsHr;        
        private int _topSpeed;
        protected decimal BrakeSpeedInMeterPerSecond = 10;
        protected int SpeedLimit = 80;

        private Vehicle() { }

        public Vehicle(int topSpeed)
        {
            if (topSpeed <= 0)
                throw new ArgumentOutOfRangeException(nameof(topSpeed), "Topspeed should be positive");
                        
            _topSpeed = topSpeed;
        }

        public decimal Accelarate(decimal kmsHr)
        {
            if (kmsHr == 0)
                throw new ArgumentOutOfRangeException(nameof(kmsHr), "Zero is not an accpeted value");
            if (kmsHr < 0)
                throw new ArgumentOutOfRangeException(nameof(kmsHr), "Only positive numbers are accepted");

            var newSpeed = _speedInKmsHr + kmsHr;

            if (newSpeed > _topSpeed)
                _speedInKmsHr = _topSpeed;
            else
                _speedInKmsHr = newSpeed;
            
            return _speedInKmsHr;
        }

        public decimal Brake(int timeInMiliSeconds)
        {
            if (timeInMiliSeconds < 0)
                throw new ArgumentOutOfRangeException(nameof(timeInMiliSeconds), "Only positive numbers are accepted");

            var kmsBrake = BrakeSpeedInMeterPerSecond * timeInMiliSeconds / 100;

            if (kmsBrake > _speedInKmsHr)
                _speedInKmsHr = 0;
            else
                _speedInKmsHr -= kmsBrake;

            return _speedInKmsHr;
        }
    }
}
