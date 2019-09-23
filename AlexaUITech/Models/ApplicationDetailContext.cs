using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AlexaUITech.Models
{
    public class ApplicationDetailContext : DbContext
    {
        public ApplicationDetailContext() : base()
        {

        }

        public DbSet<ApplicationDetail> ApplicationDetails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}