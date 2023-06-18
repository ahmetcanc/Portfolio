using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Portfolyom.Models
{
    public class Context:DbContext
    {
        public virtual DbSet<About> Abouts {get; set;}
        public virtual DbSet<CartInfo> CartInfos {get; set;}
        public virtual DbSet<Experience> Experiences {get; set;}
        public virtual DbSet<Project> Projects {get; set;}
        public virtual DbSet<Contact> Contacts {get; set;}
        public virtual DbSet<Admin> Admins {get; set;}
    }
}