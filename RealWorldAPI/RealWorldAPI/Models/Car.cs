using System;
using System.Collections.Generic;

namespace RealWorldAPI.Models
{
    public class Car : BaseModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public ICollection<Feature> Features { get; set; }
        public bool IsRegistered { get; set; }
        public ContactInfo Contact { get; set; }
        public Car()
        {
            Features = new List<Feature>();
        }
    }
    public class Feature : BaseModel
    {
        public bool IsAvailable { get; set; }
        public string Name { get; set; }
    }
}
