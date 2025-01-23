using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WD.Tailoring.Core.Entities.Students
{
    public class Department : BaseEntity
    {
        /// <summary>
        /// Science, Commerce, Art
        /// </summary>
        public string? Name { get; set; }
    }
}
