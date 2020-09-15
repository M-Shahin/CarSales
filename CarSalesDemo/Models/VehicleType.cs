using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarSalesDemo.Models
{
    public class VehicleType
    {
        public List<VehicleType> VehicleTypes { get; set; }

        [Display(Name = "Select a vehicle type you want to build")]
        public int Id { get; set; }
        public string VehicleTypeName { get; set; }
    }
}