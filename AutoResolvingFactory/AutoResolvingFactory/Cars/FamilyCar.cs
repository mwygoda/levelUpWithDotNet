namespace AutoResolvingFactory.Cars
{
    public class FamilyCar : ICar
    {
        public FamilyCar()
        {
            Type = CarType.Family;
            Model = "Ford Mondeo";
            MaxSpeed = 200;
            Color = "Black";
        }
        
        public CarType Type { get; }
        public string Model { get; }
        public int MaxSpeed { get; }
        public string Color { get; }
    }
}