namespace ConsoleApplication3
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CITY> CITies { get; set; }
        public virtual DbSet<DELIVERY> DELIVERies { get; set; }
        public virtual DbSet<DELIVERY_STRING> DELIVERY_STRING { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENTs { get; set; }
        public virtual DbSet<DETAIL> DETAILs { get; set; }
        public virtual DbSet<MATERIAL> MATERIALs { get; set; }
        public virtual DbSet<ORGANIZATION> ORGANIZATIONs { get; set; }
        public virtual DbSet<OWNERSHIP> OWNERSHIPs { get; set; }
        public virtual DbSet<PACKING> PACKINGs { get; set; }
        public virtual DbSet<PERSON> People { get; set; }
        public virtual DbSet<SUPPLIER> SUPPLIERs { get; set; }
        public virtual DbSet<SUPPLY> SUPPLies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TRANSPORTATION> TRANSPORTATIONs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CITY>()
                .Property(e => e.CITY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DELIVERY>()
                .HasMany(e => e.DELIVERY_STRING)
                .WithRequired(e => e.DELIVERY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DETAIL>()
                .Property(e => e.DETAIL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DETAIL>()
                .Property(e => e.WEIGHT)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MATERIAL>()
                .Property(e => e.MATERIAL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORGANIZATION>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<OWNERSHIP>()
                .Property(e => e.OWNERSHIP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PACKING>()
                .Property(e => e.PACKING_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER>()
                .Property(e => e.SUPPLIER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER>()
                .HasOptional(e => e.ORGANIZATION)
                .WithRequired(e => e.SUPPLIER)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SUPPLIER>()
                .HasOptional(e => e.PERSON)
                .WithRequired(e => e.SUPPLIER)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SUPPLY>()
                .Property(e => e.SUPPLY_COST)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SUPPLY>()
                .HasMany(e => e.TRANSPORTATIONs)
                .WithMany(e => e.SUPPLies)
                .Map(m => m.ToTable("SUPPLY_TRANSPORTATION").MapLeftKey("SUPPLY_ID").MapRightKey("TRANSPORTATION_ID"));

            modelBuilder.Entity<TRANSPORTATION>()
                .Property(e => e.TRANSPORTATION_NAME)
                .IsUnicode(false);
        }
    }
}
