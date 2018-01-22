using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Strategies
{
    public interface ITransportStrategy
    {
        decimal CalculateCost(decimal distance);
    }
}
