using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Strategies
{
    class SpaceshipTransportStrategy : ITransportStrategy
    {
        private readonly decimal _costPerKilometer;

        public SpaceshipTransportStrategy()
        {
            _costPerKilometer = 99999m;
        }
        public decimal CalculateCost(decimal distance)
        {
            Console.WriteLine("You decided to use SpaceShip transport! hope u will enjoy, its not cheap thing!");
            var result = distance * _costPerKilometer;

            return result;
        }
    }
}
