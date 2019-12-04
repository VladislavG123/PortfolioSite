using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }

        public virtual List<Education> Educations { get; set; } = new List<Education>();
        public virtual List<Project> Projects { get; set; } = new List<Project>();
        public virtual List<Skill> Skills { get; set; } = new List<Skill>();
        public virtual List<Work> Work { get; set; } = new List<Work>();
    }
}
