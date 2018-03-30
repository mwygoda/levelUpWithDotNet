using AutoResolvingFactory.Cars;

namespace AutoResolvingFactory.Factories
{
    public class SportCarFactory : ICarFactory
    {
        public SportCarFactory()
        {
            Type = CarType.Sport;
        }
        public CarType Type { get; }
        public ICar CreateCar()
        {
            return new SportCar();
        }
    }
}