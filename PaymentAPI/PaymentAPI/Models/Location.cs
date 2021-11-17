using PaymentAPI.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models
{
    public class Location : BaseObject
    {
        public string EstablishmentId { get; set; }

        [DisplayName("Volgorde in menu")]
        public int SortOrder { get; set; }

        [DisplayName("Naam")]
        [Required(ErrorMessage = "'Naam' is verplicht")]
        public string Name { get; set; }

        [DisplayName("Omschrijving")]
        public string Description { get; set; }

        [DisplayName("Toon checklist")]
        public bool ShouldPresentCheckList { get; set; }

        [DisplayName("Afbeelding")]
        public string ImageUrl { get; set; }

        public Establishment Establishment { get; set; }

        public Location()
        {
        }
    }
}
