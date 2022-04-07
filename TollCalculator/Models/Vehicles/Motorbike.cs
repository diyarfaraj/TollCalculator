using TollCalculator.Interface;

namespace TollCalculator.Vehicles
{
    public class Motorbike : Interface.IVehicle
    {
        public string GetVehicleType() => nameof(Motorbike);

        public bool IsTollFree() => true;
    }
}
