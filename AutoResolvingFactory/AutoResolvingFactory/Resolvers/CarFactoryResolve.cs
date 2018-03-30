using System.Collections.Generic;
using System.Linq;
using AutoResolvingFactory.Cars;
using AutoResolvingFactory.Factories;

namespace AutoResolvingFactory.Resolvers
{
    public class CarFactoryResolve : ICarFactoryResolve
    {
        private readonly IEnumerable<ICarFactory> _carFactories;
        
        public CarFactoryResolve(IEnumerable<ICarFactory> carFactories)
        {
            _carFactories = carFactories;
        }
        
        public ICarFactory Resolve(CarType type)
        {
            var result = _carFactories.SingleOrDefault(x => x.Type == type);

            return result;
        }
    }
}