using System;
using DesignPatterns.Strategy.Strategies;

namespace DesignPatterns.Strategy
{
    public class StrategyClient
    {
        public void StartApp()
        {
            var distace = 30;
            var taxiTransport = new TaxiTransportStrategy();
            var bikeTransport = new BiketransportStrategy();
            var spaceshipTransport = new SpaceshipTransportStrategy();

            var costByTaxi = taxiTransport.CalculateCost(distace);
            Console.WriteLine("Cost of TaxiBy Transport: {0}", costByTaxi);

            var costByBike = bikeTransport.CalculateCost(distace);
            Console.WriteLine("Cost of bike rental and transport: {0}", costByBike);

            var costBySpaceship = spaceshipTransport.CalculateCost(distace);
            Console.WriteLine("OH, cool~! Cost of travel by spaceship is: {0}", costBySpaceship);

            Console.ReadLine();
        }
    }
}
