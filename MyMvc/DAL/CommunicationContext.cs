using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MyMvc.Models;

namespace MyMvc.DAL
{
    public class CommunicationContext:DbContext
    {
        public CommunicationContext()
            : base("CommunicationContext")
        {
            
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}