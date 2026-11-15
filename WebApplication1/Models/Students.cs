using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Students
    {
        //public Students()
        //{
        //    Registation = new HashSet<Registation>();
        //}

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Degree { get; set; }
        public bool? Status { get; set; }
        public int CodeStudent { get; set; }

        //public virtual ICollection<Registation> Registation { get; set; }
    }
}
