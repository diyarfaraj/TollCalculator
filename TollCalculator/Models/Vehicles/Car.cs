using TollCalculator.Interface;

namespace TollCalculator.Vehicles
{
    public class Car : Interface.IVehicle
    {
        public string GetVehicleType() => nameof(Car);
        public bool IsTollFree() => false;
    }
}