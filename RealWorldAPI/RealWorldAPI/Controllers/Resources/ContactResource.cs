using System;

namespace RealWorldAPI.Controllers.Resources
{
    public class ContactResource : BaseResource
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
