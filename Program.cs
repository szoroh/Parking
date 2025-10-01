using System;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("WX 11122", "green", "Mazda 2");
            Car car2 = new Car("WD 11133", "black", "Ford Focus");
            Car car3 = new Car("WB 99911", "white", "Volvo XC90");
            Car car4 = new Car("WD 11134", "black", "Volvo XC70");
            Car car5 = new Car("WD 11135", "yellow", "Volvo V60 CC");

            Parking parking = new Parking();
            parking.ParkCarInParkingLot(car1);
            parking.ParkCarInParkingLot(car2);
            parking.ParkCarInParkingLot(car3);
            parking.ParkCarInParkingLot(car4);
            parking.ParkCarInParkingLot(car5);

            Console.WriteLine("All parked cars:");
            parking.DisplayAllParkedCars();

            Console.WriteLine("Search by registration (WX 11122)");
            parking.DisplayCarByRegistrationNumber("WX 11122");

            Console.WriteLine("Search by phrase: Volvo");
            parking.DisplayAllModelsMatchingGivenPhrase("Volvo");
        }
    }
}