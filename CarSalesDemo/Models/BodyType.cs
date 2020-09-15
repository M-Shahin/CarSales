using System.Collections.Generic;

namespace CarSalesDemo.Models
{
    public class BodyType
    {
        public List<BodyType> BodyTypes { get; set; }
        public int Id { get; set; }
        public string BodyTypeName { get; set; }
    }
}