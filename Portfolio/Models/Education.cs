using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Education
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Specialization { get; set; }
        public string EducationName { get; set; }

        public virtual User User { get; set; }
    }
}
