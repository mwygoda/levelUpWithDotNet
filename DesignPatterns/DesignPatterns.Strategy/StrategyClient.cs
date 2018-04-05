using System;
using DesignPatterns.Strategy.Strategies;

namespace DesignPatterns.Strategy
{
    public class StrategyClient
    {
        public void StartApp()
        {
            var taxiTransport = new TravelAgency(new TaxiTransportStrategy()) {Distance = 50};
            var bikeTransport = new TravelAgency(new BiketransportStrategy()) {Distance = 120};
            var spaceshipTransport = new TravelAgency(new SpaceshipTransportStrategy()) {Distance = 60};

            var costByTaxi = taxiTransport.GetFinalTransportCost();
            Console.WriteLine("Cost of TaxiBy Transport: {0}", costByTaxi);

            var costByBike = bikeTransport.GetFinalTransportCost();
            Console.WriteLine("Cost of bike rental and transport: {0}", costByBike);

            var costBySpaceship = spaceshipTransport.GetFinalTransportCost();
            Console.WriteLine("OH, cool~! Cost of travel by spaceship is: {0}", costBySpaceship);
            
            spaceshipTransport.ChangeStrategy(new BiketransportStrategy());
            var costChangedFromSpaceshipToBike = spaceshipTransport.GetFinalTransportCost();
            Console.WriteLine("You changed from spaceship to bike? to expensive huh? cost will be: {0}", costChangedFromSpaceshipToBike);
            
            Console.ReadLine();
        }
    }
}
