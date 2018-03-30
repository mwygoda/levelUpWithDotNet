namespace AutoResolvingFactory.Cars
{
    public interface ICar
    {
        CarType Type { get; }
        string Model { get; }
        int MaxSpeed { get; }
        string Color { get; }
    }
}