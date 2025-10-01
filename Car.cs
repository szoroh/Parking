namespace Parking
{
    public class Car
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        public Car(string registrationNumber, string color, string model)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            Model = model;
        }
    }
}