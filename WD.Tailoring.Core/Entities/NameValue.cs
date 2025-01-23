
namespace WD.Tailoring.Core.Entities
{
    public class NameValue:BaseEntity
    {
        public required string Name { get; set; }
        public required string GroupName {  get; set; }
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
