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
        public string Make { get; set; }
        public byte Model { get; set; }
        public string Engine { get; set; }
    }
}