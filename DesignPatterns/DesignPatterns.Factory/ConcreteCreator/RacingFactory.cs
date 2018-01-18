using DesignPatterns.Factory.ConcreteProduct;
using DesignPatterns.Factory.Creator;
using DesignPatterns.Factory.Product;

namespace DesignPatterns.Factory.ConcreteCreator
{
    class RacingFactory : BikeFactory
    {
        private readonly int _wheelSize;
        private readonly int _price;

        public RacingFactory(int wheelSize, int pice)
        {
            _wheelSize = wheelSize;
            _price = wheelSize;
        }

        public override Bike CreateBike()
        {
            return new RacingBike(_wheelSize, _price);
        }
    }
}
