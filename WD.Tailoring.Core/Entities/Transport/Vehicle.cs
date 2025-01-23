using WD.Tailoring.Core.Entities.Drivers;

namespace WD.Tailoring.Core.Entities.Transportation
{
    public class Vehicle : BaseEntity
    {
        /// <summary>
        /// Describe Vehicle Name like Ashok Leyland Bus, Tata Bus
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Describe Vehicle Number
        /// </summary>
        public required string Number { get; set; }
        /// <summary>
        /// Describe Insurance Start Date
        /// </summary>
        public DateTime? InsuranceFrom { get; set; }

        public int DriverId { get; set; }

        // Navigation property to Driver
        public virtual Driver? Driver{ get; set; }

        /// <summary>
        /// Describe Insurance Expiry Date
        /// </summary>
        public DateTime? InsuranceTo { get; set; }

        /// <summary>
        ///Type can be Bus, Van, E-Rikshaw
        /// </summary>
        public required string Type { get; set; }
        /// <summary>
        /// Other Information
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Describe Active/ In Active
        /// </summary>
        public bool? Status { get; set; }

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
