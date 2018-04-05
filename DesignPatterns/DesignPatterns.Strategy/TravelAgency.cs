using DesignPatterns.Strategy.Strategies;

namespace DesignPatterns.Strategy
{
    public class TravelAgency
    {
        public decimal Distance { private get; set; }


        private readonly ITransportStrategy CurrentStrategy;
        public TravelAgency(ITransportStrategy NewTransportStrategy)
        {
            CurrentStrategy = NewTransportStrategy;
        }

        public decimal GetFinalTransportCost()
        {
            return CurrentStrategy.CalculateCost(Distance);
        }
    }
}