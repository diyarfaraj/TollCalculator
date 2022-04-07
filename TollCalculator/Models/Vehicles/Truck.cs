using TollCalculator.Interface;

namespace TollCalculator.Vehicles
{
    public class Truck : Interface.IVehicle
    {
        public string GetVehicleType() => nameof(Truck);

        public bool IsTollFree() => true;
    }
}