namespace AutoResolvingFactory.Cars
{
    public class TruckCar : ICar
    {
        public TruckCar()
        {
            Type = CarType.Truck;
            Model = "Jelcz";
            MaxSpeed = 120;
            Color = "Blue";
        }
        
        public CarType Type { get; }
        public string Model { get; }
        public int MaxSpeed { get; }
        public string Color { get; }
    }
}