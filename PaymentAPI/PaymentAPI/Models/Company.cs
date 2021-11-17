using PaymentAPI.Common;

namespace PaymentAPI.Models
{
    public class Company : BaseObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}
