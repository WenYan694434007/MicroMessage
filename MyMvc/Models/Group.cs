using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMvc.Models
{
    public enum GroupName
    {
        Friend,Family,Colleague,Schoolmate,Stranger
    }

    public class Group
    {
        public int GroupId { get; set; }
        public GroupName? GroupName { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; } 
    }
}