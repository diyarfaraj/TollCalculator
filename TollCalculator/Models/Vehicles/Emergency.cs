using TollCalculator.Interface;

namespace TollCalculator.Vehicles
{
    public class Emergency : Interface.IVehicle
    {
        public string GetVehicleType() => nameof(Emergency);

        public bool IsTollFree() => true;
    }
}