using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Schedule
    {
        public int ScheduleId { get; set; }
        public int? CourseId { get; set; }
        public string Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Classroom { get; set; }
        public bool? Status { get; set; }

        //public virtual Course Course { get; set; }
    }
}
