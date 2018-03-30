using AutoResolvingFactory.Cars;

namespace AutoResolvingFactory.Factories
{
    public interface ICarFactory
    {
        CarType Type { get; }
        ICar CreateCar();
    }
}