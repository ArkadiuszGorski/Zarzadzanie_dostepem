namespace Zarzadzanie_dostepem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WorkersDBModel : DbContext
    {
        public WorkersDBModel()
            : base("name=WorkersEntity")
        {
        }

        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workers>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Workers>()
                .Property(e => e.Surname)
                .IsFixedLength();

            modelBuilder.Entity<Workers>()
                .Property(e => e.Position)
                .IsFixedLength();

            modelBuilder.Entity<Workers>()
                .Property(e => e.Money)
                .HasPrecision(19, 4);
        }
    }
}
