using DesignPatterns.Factory.Product;

namespace DesignPatterns.Factory.ConcreteProduct
{
    class RacingBike : Bike
    {
        private int _wheelSize;
        private int _price;

        public RacingBike(int wheelSize, int price)
        {
            BikeType = "Racing Bike";
            _wheelSize = wheelSize;
            _price = price;
        }

        public override string BikeType { get; }

        public override int WheelSize
        {
            get { return _wheelSize; }
            set { _wheelSize = value; }
        }

        public override int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
