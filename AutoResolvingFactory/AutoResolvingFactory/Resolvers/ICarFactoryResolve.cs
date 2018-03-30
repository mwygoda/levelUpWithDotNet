using AutoResolvingFactory.Cars;
using AutoResolvingFactory.Factories;

namespace AutoResolvingFactory.Resolvers
{
    public interface ICarFactoryResolve
    {
        ICarFactory Resolve(CarType type);
    }
}