using TollCalculator.Interface;

namespace TollCalculator.Vehicles
{
    public class Diplomat : Interface.IVehicle
    {
        public string GetVehicleType() => nameof(Diplomat);

        public bool IsTollFree() => true;
    }
}