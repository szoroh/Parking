using System;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("WX 11122", "green", "Mazda 2");
            car1.FullInformation();
        }
    }
}