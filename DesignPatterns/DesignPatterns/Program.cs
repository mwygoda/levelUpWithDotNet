using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var abstractFactory = new AbstractFactoryClient();
            abstractFactory.StartApp();

            var strategyExample = new StrategyClient();
            strategyExample.StartApp();
        }
    }
}
