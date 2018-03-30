using AutoResolvingFactory.Cars;

namespace AutoResolvingFactory.Factories
{
    public class FamilyCarFactory : ICarFactory
    {
        public FamilyCarFactory()
        {
            Type = CarType.Family;
        }
        
        public CarType Type { get; }
        public ICar CreateCar()
        {
            return new FamilyCar();
        }
    }
}