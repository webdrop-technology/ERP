using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WD.Tailoring.Core.Entities.Drivers;

namespace WD.Tailoring.Core.Entities.Students
{
    public class Section : BaseEntity
    {
        // XII Commerce A
        // XII Commerce B
        // XII Science Biology A
        // X


        public required string Name { get; set; }
        public int ClassId { get; set; }
        public virtual Class? Class { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
    }
}
