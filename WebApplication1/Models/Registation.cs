using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Registation
    {
        public int RegId { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public string RegDate { get; set; }
        public string StatusReg { get; set; }
        public bool? Status { get; set; }

        //public virtual Course Course { get; set; }
        //public virtual Students Student { get; set; }
    }
}
