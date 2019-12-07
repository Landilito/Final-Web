using FinalWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FinalWeb.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("FinalWeb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Socios> Socios { get; set; }
        public DbSet<Administrador> Administrador { get; set; }
    }
}