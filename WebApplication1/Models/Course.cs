using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Course
    {
        //public Course()
        //{
        //    Registation = new HashSet<Registation>();
        //    Schedule = new HashSet<Schedule>();
        //    Syllabus = new HashSet<Syllabus>();
        //}

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int? Credits { get; set; }
        public int? TopicsId { get; set; }
        public int? ProfessorsId { get; set; }
        public bool? Status { get; set; }

        //public virtual Professors Professors { get; set; }
        //public virtual Topics Topics { get; set; }
        //public virtual ICollection<Registation> Registation { get; set; }
        //public virtual ICollection<Schedule> Schedule { get; set; }
        //public virtual ICollection<Syllabus> Syllabus { get; set; }
    }
}
