namespace DesignPatterns.Factory.Product
{
    abstract class Bike
    {
        public abstract string BikeType { get; }
        public abstract int WheelSize { get; set; }
        public abstract int Price{ get; set; }
    }
}
