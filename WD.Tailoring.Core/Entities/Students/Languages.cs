using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WD.Tailoring.Core.Entities.Students
{
    public class Languages
    {
        public required int Id { get; set; }

        [MaxLength(50)]
        public required string Name { get; set; }
    }
}
