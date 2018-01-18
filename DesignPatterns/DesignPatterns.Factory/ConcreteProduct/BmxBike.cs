using DesignPatterns.Factory.Product;

namespace DesignPatterns.Factory.ConcreteProduct
{
    class BmxBike : Bike
    {
        private int _wheelSize;
        private int _price;

        public BmxBike(int wheelSize, int price)
        {
            BikeType = "Bmx bike";
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
