using OrderAPI.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderAPI.Models
{
    public class TakeAwayOrder : BaseObject
    {
        [DisplayName("Voornaam")]
        [Required(ErrorMessage = "Vul je voornaam in")]
        public string FirstName { get; set; }

        [DisplayName("Achternaam")]
        [Required(ErrorMessage = "Vul je achternaam in")]
        public string LastName { get; set; }

        [DisplayName("Tijdstip")]
        [Required(ErrorMessage = "Vul een tijdstip in")]
        public DateTime PickupTime { get; set; }

        [DisplayName("Telefoonnummer")]
        [Required(ErrorMessage = "Vul je telefoonnumer in")]
        [Phone(ErrorMessage = "Geen geldig telefoonnummer")]
        public string Phone { get; set; }

        [DisplayName("E-mailadres")]
        [Required(ErrorMessage = "Vul je e-mailadres in")]
        [EmailAddress(ErrorMessage = "Geen geldig e-mailadres")]
        public string Email { get; set; }

        [DisplayName("Ophalen of laten bezorgen")]
        [Required(ErrorMessage = "Kies ophalen of laten bezorgen")]
        public TakeawayTypes TakeawayType { get; set; }

        /// Properties for delivery
        [DisplayName("Straat")]
        public string Street { get; set; }

        [DisplayName("Huisnummer")]
        public string HouseNumber { get; set; }

        [DisplayName("Huisnummer toevoeging")]
        public string HouseNumberExtension { get; set; }

        [DisplayName("Stad")]
        public string City { get; set; }

        [DisplayName("Land")]
        public string Country { get; set; }

        [DisplayName("Postcode")]
        public string PostalCode { get; set; }

        public TakeAwayOrder()
        {
        }
    }
}
