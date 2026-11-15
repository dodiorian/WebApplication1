using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Topics
    {
        //public Topics()
        //{
        //    Course = new HashSet<Course>();
        //}

        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }

        //public virtual ICollection<Course> Course { get; set; }
    }
}
