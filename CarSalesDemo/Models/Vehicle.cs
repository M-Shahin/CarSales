using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarSalesDemo.Models
{
    public class Vehicle
    {        
        public int Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public byte VehicleTypeId { get; set; }

        [Required]
        [Display(Name = "Make")]
        public string Make { get; set; }

        [Required]
        [Display(Name = "Model")]
        public int Model { get; set; }

        [Required]
        [Display(Name = "Engine")]
        public string Engine { get; set; }
    }
}