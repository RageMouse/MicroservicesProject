using System.ComponentModel.DataAnnotations;

namespace OrderAPI.Common
{
    public enum TakeawayTypes
    {
        [Display(Name = "Ophalen")]
        Pickup,
        [Display(Name = "Bezorgen")]
        Delivery
    }
}
