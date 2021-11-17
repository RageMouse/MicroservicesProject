using PaymentAPI.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models
{
    public class Table : BaseObject
    {
        [DisplayName("Locatie")]
        [Required(ErrorMessage = "'Locatie' is verplicht")]
        public string LocationId { get; set; }

        [DisplayName("Nummer")]
        [Required(ErrorMessage = "'Nummer' is verplicht")]
        public string Number { get; set; }

        [DisplayName("Naam")]
        public string Name { get; set; }

        [DisplayName("Volgorde in menu")]
        public int SortOrder { get; set; }

        [DisplayName("Aantal personen")]
        [Required(ErrorMessage = "'Aantal personen' is verplicht")]
        public int Pax { get; set; }

        [DisplayName("Locatie")]
        public Location Location { get; set; }

        public string ShortLink { get; set; }

        public Table()
        {
        }
    }
}
