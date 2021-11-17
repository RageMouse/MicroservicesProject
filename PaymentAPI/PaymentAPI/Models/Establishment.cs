using PaymentAPI.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models
{
    public class Establishment : BaseObject
    {
        public string CompanyId { get; set; }
        public Company Company { get; set; }
        public string ShortName { get; set; }

        [DisplayName("Naam")]
        public string Name { get; set; }

        [DisplayName("Omschrijving")]
        public string Description { get; set; }

        [DisplayName("Straat")]
        [Required(ErrorMessage = "'Straat' is verplicht")]
        public string Street { get; set; }

        [DisplayName("Huisnummer")]
        [Required(ErrorMessage = "'Huisnummer' is verplicht")]
        public string HouseNumber { get; set; }

        [DisplayName("Huisnummer toevoeging")]
        public string HouseNumberExtension { get; set; }

        [DisplayName("Stad")]
        [Required(ErrorMessage = "'Stad' is verplicht")]
        public string City { get; set; }

        [DisplayName("Land")]
        [Required(ErrorMessage = "'Land' is verplicht")]
        public string Country { get; set; }

        [DisplayName("Postcode")]
        [Required(ErrorMessage = "'Postcode' is verplicht")]
        public string PostalCode { get; set; }

        [DisplayName("Email vestiging")]
        public string Email { get; set; }

        [DisplayName("Website")]
        public string Website { get; set; }

        [DisplayName("Telefoonnummer")]
        public string Phone { get; set; }

        public string Lat { get; set; }
        public string Lon { get; set; }

        [DisplayName("Logo")]
        public string PhotoUrl { get; set; }

        [DisplayName("Banner")]
        public string BannerUrl { get; set; }

        [DisplayName("Restaurant heeft een centrale afhaalplek")]
        public bool HasPickupPoint { get; set; }

        public string Iban { get; set; }

        public string VatCode { get; set; }

        [DisplayName("Afhalen mogelijk?")]
        public bool TakeAwayEnabled { get; set; }

        [DisplayName("QR bestellen mogelijk?")]
        public bool QrEnabled { get; set; }

        public Establishment()
        {
        }
    }
}
