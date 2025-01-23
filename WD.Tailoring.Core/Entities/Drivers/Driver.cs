
namespace WD.Tailoring.Core.Entities.Drivers
{
    public class Driver : BaseEntity
    {
        public required string Name { get; set; }
        public required string Adress { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string Country { get; set; }
        public int Pincode { get; set; }
        public required string PhoneNumber { get; set; }
        public string? AlternatePhoneNumber { get; set; }
        public required string LicenseNumber { get; set; }
        public string? AadharNumber { get; set; }

        //Bank Details

        public bool Status { get; set; }
        /// <summary>
        /// Describe Created on date
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Nullable since it's only updated on modifications
        /// </summary>
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// Describe Created by details
        /// </summary>
        public int CreatedBy { get; set; }
        /// <summary>
        /// // Nullable since it's only updated on modifications
        /// </summary>
        public int? UpdatedBy { get; set; }

    }
}
