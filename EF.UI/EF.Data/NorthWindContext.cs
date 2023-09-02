using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using EF.Entities;


namespace EF.Entities
{
    public partial class NorthWindContext : DbContext
    {
        public NorthWindContext()
            : base("name=NorthWindConecction")
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
                .Property(e => e.CustomerID)
                .IsFixedLength();
        }
    }
}
