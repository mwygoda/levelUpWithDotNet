using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Strategies
{
    class BiketransportStrategy : ITransportStrategy
    {
        private readonly decimal _costPerKilometer;

        public BiketransportStrategy()
        {
            _costPerKilometer = 0.01m;
        }

        public decimal CalculateCost(decimal distance)
        {
            Console.WriteLine("You decided to travel by bike, hoply weather will be great!");
            var result = distance * _costPerKilometer;

            return result;
        }
    }
}
