using System;

namespace NewVsOverride
{
    public class Program
    {
        public static void Main()
        {
            BaseClass toBeOverrided = new DerivedOverridingClass();
            BaseClass toBeHiden = new DerivedHidingClass();

            Console.WriteLine("Base class object pointing on child class using override will say:");
            toBeOverrided.Greet();

            Console.WriteLine("Base class object pointing on child class using new (hiding) will say:");
            toBeHiden.Greet();

            Console.ReadLine();
        }
    }

    public class BaseClass
    {
        public virtual void Greet()
        {
            Console.WriteLine("Hello from BaseClass");
        }
    }

    public class DerivedOverridingClass : BaseClass
    {
        public override void Greet()
        {
            Console.WriteLine("Hello from DerviedOverridingClass");
        }
    }

    public class DerivedHidingClass : BaseClass
    {
        public new void Greet()
        {
            Console.WriteLine("Hello From DerivedHidingClass");
        }
    }
}