using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyMvc.Models;

namespace MyMvc.DAL
{
    public class CommunicationInitializer:DropCreateDatabaseIfModelChanges<CommunicationContext>
    {
        protected override void Seed(CommunicationContext context)
        {
            var contacts=new List<Contact>
            {
                new Contact{Name = "路飞",EnrollmentDate = DateTime.Parse("2001-01-01")},
                new Contact{Name = "索隆",EnrollmentDate = DateTime.Parse("2002-01-01")},
                new Contact{Name = "山治",EnrollmentDate = DateTime.Parse("2003-01-01")},
                new Contact{Name = "乌索普",EnrollmentDate = DateTime.Parse("2004-01-01")},
                new Contact{Name = "娜美",EnrollmentDate = DateTime.Parse("2005-01-01")},
            };
            contacts.ForEach(c=>context.Contacts.Add(c));
            context.SaveChanges();

            var groups=new List<Group>
            {
                new Group{GroupName = GroupName.Colleague},
                new Group{GroupName = GroupName.Family},
                new Group{GroupName = GroupName.Friend},
                new Group{GroupName = GroupName.Schoolmate},
                new Group{GroupName = GroupName.Stranger},
            };
            groups.ForEach(g=>context.Groups.Add(g));
            context.SaveChanges();

            var enrollments=new List<Enrollment>
            {
                new Enrollment{ContactId = 1,GroupId = 1024},
                new Enrollment{ContactId = 2,GroupId = 1025},
                new Enrollment{ContactId = 3,GroupId = 1026},
                new Enrollment{ContactId = 4,GroupId = 1027},
                new Enrollment{ContactId = 5,GroupId = 1028},
            };
            enrollments.ForEach(e=>context.Enrollments.Add(e));
            context.SaveChanges();

        }
    }
}