using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Strategies
{
    class TaxiTransportStrategy : ITransportStrategy
    {
        private readonly decimal _costPerKilometer;

        public TaxiTransportStrategy()
        {
            _costPerKilometer = 2.6m;
        }

        public decimal CalculateCost(decimal distance)
        {
            Console.WriteLine("You decided to travel by a taxi!");
            var result = distance * _costPerKilometer;

            return result;
        }
    }
}
