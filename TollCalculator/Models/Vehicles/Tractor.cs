using TollCalculator.Interface;

namespace TollCalculator.Vehicles
{
    public class Tractor : Interface.IVehicle
    {
        public string GetVehicleType() => nameof(Tractor);

        public bool IsTollFree() => true;
    }
}