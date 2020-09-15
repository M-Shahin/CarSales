namespace CarSalesDemo.Models
{
    public class Car : Vehicle
    {
        public byte NumberOfDoors { get; set; }
        public byte NumberOfWheels { get; set; }
        public BodyType BodyType { get; set; }
        public byte BodyTypeId { get; set; }
    }
}