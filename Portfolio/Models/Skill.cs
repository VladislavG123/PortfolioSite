using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Skill
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string SkillName { get; set; }
        public int Percentage { get; set; }

        public virtual User User { get; set; }
    }
}
