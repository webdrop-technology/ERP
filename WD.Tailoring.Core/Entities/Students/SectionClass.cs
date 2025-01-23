using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WD.Tailoring.Core.Entities.Students
{
    public class SectionClass : BaseEntity
    {
        public int ClassId { get; set; }
        public virtual Class? Class { get; set; }
        public int SectionId { get; set; }
        public virtual Section? Section { get; set; }
    }
}
