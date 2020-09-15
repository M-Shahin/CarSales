using CarSalesDemo.Models;
using System.Collections.Generic;

namespace CarSalesDemo.ViewModel
{
    public class VehicleFormViewModel
    {
        public IEnumerable<VehicleType> VehicleTypes { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}