using System.ComponentModel.DataAnnotations;

namespace CarSalesDemo.Models
{
    public class Car : Vehicle
    {
        [Display(Name = "Number of doors") ]
        public byte NumberOfDoors { get; set; }

        [Display(Name ="Number of wheels")]
        public byte NumberOfWheels { get; set; }
        
        public BodyType BodyType { get; set; }

        [Display(Name = "Body type")]
        public byte BodyTypeId { get; set; }
    }
}