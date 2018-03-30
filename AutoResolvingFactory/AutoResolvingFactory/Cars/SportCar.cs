namespace AutoResolvingFactory.Cars
{
    public class SportCar : ICar
    {
        public SportCar()
        {
            Type = CarType.Sport;
            Model = "Ferrari";
            MaxSpeed = 350;
            Color = "Red";
        }
        
        public CarType Type { get; }
        public string Model { get; }
        public int MaxSpeed { get; }
        public string Color { get; }
    }
}