using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Common
{
    public enum PaymentTypes
    {
        Cash,
        iDeal,
        Mastercard,
        Visa,
        AmericanExpress,
        Payconiq,
        Bancontact,
        Sofort
    }

    public enum PaymentStatuses
    {
        [Display(Name = "Aangemaakt")]
        Created,
        [Display(Name = "Aangevraagd")]
        Requested,
        [Display(Name = "In afwachting")]
        Pending,
        [Display(Name = "Betaald")]
        Paid,
        [Display(Name = "Geannuleerd")]
        Canceled,
        [Display(Name = "Mislukt")]
        Failed,
        [Display(Name = "Verlopen")]
        Expired,
        [Display(Name = "Concept")]
        Draft
    }
}
