using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMvc.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int ContactId { get; set; }
        public int GroupId { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Group Group { get; set; }
    }
}