using System;
using System.Linq;
using System.Collections.Generic;

namespace Parking
{
    public class Parking
    {
        public List<Car> ParkingList { get; set; } = new List<Car>();
        public void ParkCarInParkingLot(Car car)
        {
            ParkingList.Add(car);
        }

        public void FullInformation(Car car)
        {
            Console.WriteLine($"Car details: {car.RegistrationNumber}, {car.Color}, {car.Model}");
        }

        public void DisplayCarByRegistrationNumber(string registrationNumber)
        {
            var car = ParkingList.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
            if (car == null)
            {
                Console.WriteLine("Car not found.");
            }
            else
            {
                FullInformation(car);
            }
        }

        public void DisplayAllParkedCars()
        {
            foreach (var car in ParkingList)
            {
                FullInformation(car);
            }
        }

        public void DisplayAllModelsMatchingGivenPhrase(string phrase)
        {
            var matchingPhrase = ParkingList.Where(x => x.Model.Contains(phrase)).ToList();
            foreach (var car in matchingPhrase)
            {
                FullInformation(car);
            }
        }
        
        public void RemoveParkedCarFromParking(Car car)
        {
            if (car == null || !ParkingList.Contains(car))
            {
                Console.WriteLine("Car not found or invalid.");
            }
            else
            {
               ParkingList.Remove(car); 
            }
        }
    }
}