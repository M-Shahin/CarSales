using CarSalesDemo.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarSalesDemo.ViewModel
{
    public class CarBodyTypeViewModel
    {
        public IEnumerable<BodyType> BodyTypes { get; set; }
        
        public Car Car { get; set; }

        public int? Id { get; set; }

        [Required]
        [Display(Name = "Make")]
        public string Make { get; set; }

        [Required]
        [Display(Name = "Model")]
        public int Model { get; set; }

        [Required]
        [Display(Name = "Engine")]
        public string Engine { get; set; }

        [Required]
        [Display(Name = "Body Type")]
        public byte BodyTypeId { get; set; }

        //public BodyType BodyType { get; set; }

        [Required]
        [Display(Name = "Number of Doors")]
        public int NumberOfDoors { get; set; }

        [Required]
        [Display(Name = "Number of Wheels")]
        public int NumberOfWheels { get; set; }

        public CarBodyTypeViewModel()
        {
            Id = 0;
        }

        public CarBodyTypeViewModel(Car car)
        {
            Id = car.Id;
            Make = car.Make;
            Model = car.Model;
            Engine = car.Engine;
            BodyTypeId = car.BodyTypeId;
            NumberOfDoors = car.NumberOfDoors;
            NumberOfWheels = car.NumberOfWheels;
        }
    }
}