using System;
using System.Collections.Generic;

namespace RealWorldAPI.Controllers.Resources
{
    public class CarResource : BaseResource
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public ICollection<string> Features { get; set; }
        public bool IsRegistered { get; set; }
        public ContactResource Contact { get; set; }
        public CarResource()
        {
            Features = new List<string>();
        }
    }
    public class FeatureResource : BaseResource
    {
        public bool IsAvailable { get; set; }
        public string Name { get; set; }
    }
}
