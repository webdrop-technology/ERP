using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WD.Tailoring.Core.Entities
{
    public class Documents:BaseEntity
    {
        public required string Name { get; set; }
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
