using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    // the concept is- class should not be forced to implement interfaces that does not use.
    public interface IDrive
    {
         string Drive();
    }
    public interface IFly
    {
         string Fly();
    }

    public class Car : IDrive // Car class does not need to implement Fly method. so that we separate the interface
    {
        public string Drive()
        {
            return "Driving.";
        }
    }

    public class FlyingCar : IDrive, IFly
    {
        public string Drive()
        {
            return "Driving.";
        }

        public string Fly()
        {
            return "Flying.";
        }
    }
}
