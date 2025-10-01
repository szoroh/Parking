using System;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to P+R parking system!");
            Console.WriteLine("1. Park vehilce.");
            Console.WriteLine("2. Remove car from parking.");
            Console.WriteLine("3. Display all vehicles.");
            Console.WriteLine("4. Search by model name (ex. Ford, Honda...).");
            Console.WriteLine("5. Search by registration plate (ex. WD 11122).");
            Console.WriteLine("To exit press 'x'");

            Parking parking = new Parking();
            //preload database for easier interaction
            Car car1 = new Car("WX 11122", "green", "Mazda 2");
            Car car2 = new Car("WD 11133", "black", "Ford Focus");
            Car car3 = new Car("WB 99911", "white", "Volvo XC90");
            Car car4 = new Car("WD 11134", "black", "Volvo XC70");
            Car car5 = new Car("WD 11135", "yellow", "Volvo V60 CC");

            parking.ParkCarInParkingLot(car1);
            parking.ParkCarInParkingLot(car2);
            parking.ParkCarInParkingLot(car3);
            parking.ParkCarInParkingLot(car4);
            parking.ParkCarInParkingLot(car5);

            var userInput = Console.ReadLine();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Provide registration number (ex. WD 11122)");
                        var plate = Console.ReadLine();
                        Console.WriteLine("Provide car color.");
                        var color = Console.ReadLine();
                        Console.WriteLine("Provide car model (ex. Ford Escort).");
                        var model = Console.ReadLine();
                        parking.ParkCarInParkingLot(new Car(plate, color, model));
                        break;
                    case "2":
                        Console.WriteLine("Provide registration plate to remove (ex. WD 11122).");
                        var removePlate = Console.ReadLine();
                        var carToRemove = parking.ParkingList.FirstOrDefault(car1 => car1.RegistrationNumber == removePlate);
                        parking.RemoveParkedCarFromParking(carToRemove);
                        break;
                    case "3":
                        parking.DisplayAllParkedCars();
                        break;
                    case "4":
                        Console.WriteLine("Provide model name to search by:");
                        var searchModelPhrase = Console.ReadLine();
                        parking.DisplayAllModelsMatchingGivenPhrase(searchModelPhrase);
                        break;
                    case "5":
                        Console.WriteLine("Provide registration plate to search by:");
                        var searchPlatePhrase = Console.ReadLine();
                        parking.DisplayCarByRegistrationNumber(searchPlatePhrase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
        }
    }
}