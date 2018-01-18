using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.ConcreteCreator;
using DesignPatterns.Factory.Creator;
using DesignPatterns.Factory.Product;

namespace DesignPatterns.Factory
{
    public class AbstractFactoryClient
    {
        public void StartApp()
        {
            BikeFactory factory = null;
            Console.WriteLine("Chose the type of bike u wanna order:");
            Console.WriteLine("1. Bmx \n 2. Racing bike \n 3. MTB");
            var bike = Console.ReadLine();

            switch (bike)
            {
                case "1":
                    factory = new BmxFactory(16, 2000);
                    break;
                case "2":
                    factory = new RacingFactory(28, 100000);
                    break;
                case "3":
                    factory = new MTFactory(26, 99999);
                    break;
                default:
                    Console.WriteLine("We dont have bike like this, so sorry!");
                    break;
            }

            var chosenBike = factory.CreateBike();

            Console.WriteLine("Your ordered bike is: \n");
            Console.WriteLine("Bike type: {0}\n Wheel size: {1} \n Price: {2}",
                chosenBike.BikeType, chosenBike.WheelSize, chosenBike.Price);
        }
    }
}
