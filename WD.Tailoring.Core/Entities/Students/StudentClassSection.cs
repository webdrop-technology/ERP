using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WD.Tailoring.Core.Entities.Students
{
    public class StudentClassSection : BaseEntity
    {
        public int StudentId { get; set; }
        public virtual Student? Student { get; set; }
        public int ClassId { get; set; }
        public virtual Class? Class { get; set; }
        public int SectionId { get; set; }
        public virtual Section? Section { get; set; }
    }
}
