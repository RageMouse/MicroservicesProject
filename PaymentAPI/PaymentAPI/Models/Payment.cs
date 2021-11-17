using PaymentAPI.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
    public class Payment : BaseObject
    {
        /// <summary>
        ///     Related table id
        /// </summary>
        /// <remarks>Can be null if the related order is created by the takeaway</remarks>
        public string TableId { get; set; }

        /// <summary>
        ///     Related table
        /// </summary>
        /// <remarks>Can be null if the related order is created by the takeaway</remarks>
        public Table Table { get; set; }

        /// <summary>
        ///     Order number
        /// </summary>
        public long? OrderNumber { get; set; }

        /// <summary>
        ///     Payment type
        /// </summary>
        public PaymentTypes PaymentType { get; set; }

        /// <summary>
        ///     Extra tip the costumer has given
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal Tip { get; set; }

        /// <summary>
        ///     Related Establishment id
        /// </summary>
        public string EstablishmentId { get; set; }

        /// <summary>
        ///     Related Establishment
        /// </summary>
        public Establishment Establishment { get; set; }

        /// <summary>
        ///     Current payment status
        /// </summary>
        public PaymentStatuses PaymentStatus { get; set; }

        /// <summary>
        ///     Payment Id provided by the external payment providers
        /// </summary>
        public string ExternalPaymentId { get; set; }

        /// <summary>
        ///     Total price of the payment order
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        public bool HasPaymentFailed()
        {
            switch (PaymentStatus)
            {
                case PaymentStatuses.Paid:
                case PaymentStatuses.Created:
                case PaymentStatuses.Draft:
                    return false;
                default:
                    return true;
            }
        }
    }
}
