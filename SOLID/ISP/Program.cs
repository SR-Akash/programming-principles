using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            FlyingCar flyingCar = new FlyingCar();
            Console.WriteLine(car.Drive());

            Console.WriteLine(flyingCar.Drive());
            Console.WriteLine(flyingCar.Fly());
        }
    }
}
