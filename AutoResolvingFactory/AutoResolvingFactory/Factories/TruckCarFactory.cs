using AutoResolvingFactory.Cars;

namespace AutoResolvingFactory.Factories
{
    public class TruckCarFactory : ICarFactory
    {
        public TruckCarFactory()
        {
            Type = CarType.Truck;
        }
        
        public CarType Type { get; }
        public ICar CreateCar()
        {
            return new TruckCar();
        }
    }
}