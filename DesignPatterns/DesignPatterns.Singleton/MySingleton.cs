using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class MySingleton
    {
        private static int _counter = 0;
        private static MySingleton _instance = null;

        public static MySingleton GetInstance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new MySingleton();
                }
                return _instance;
            }
        }

        private MySingleton()
        {
            _counter++;
            Console.WriteLine("How many times i've been created? " + _counter.ToString());
        }
        public void SayHello(string message)
        {
            Console.WriteLine(message);
        }
    }
}
