using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp.Models
{
    public partial class ShoesDB : DbContext
    {
        public ShoesDB()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<MaterialInsole> MaterialInsole { get; set; }
        public virtual DbSet<MaterialLiner> MaterialLiner { get; set; }
        public virtual DbSet<MaterialSole> MaterialSole { get; set; }
        public virtual DbSet<MaterialTop> MaterialTop { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ShoesSize> ShoesSize { get; set; }
        public virtual DbSet<ShoesSubtype> ShoesSubtype { get; set; }
        public virtual DbSet<ShoesType> ShoesType { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Manufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaterialInsole>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.MaterialInsole)
                .HasForeignKey(e => e.ShoeInsole);

            modelBuilder.Entity<MaterialLiner>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.MaterialLiner)
                .HasForeignKey(e => e.ShoeLiner);

            modelBuilder.Entity<MaterialSole>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.MaterialSole)
                .HasForeignKey(e => e.ShoeSole);

            modelBuilder.Entity<MaterialTop>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.MaterialTop)
                .HasForeignKey(e => e.ShoeTop);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShoesSize>()
                .Property(e => e.PossibleSize)
                .HasPrecision(18, 1);

            modelBuilder.Entity<ShoesSize>()
                .Property(e => e.AvailableSize)
                .HasPrecision(18, 1);

            modelBuilder.Entity<ShoesSubtype>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.ShoesSubtype1)
                .HasForeignKey(e => e.ShoesSubtype)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShoesType>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.ShoesType1)
                .HasForeignKey(e => e.ShoesType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserRole>()
                .HasMany(e => e.User)
                .WithRequired(e => e.UserRole1)
                .HasForeignKey(e => e.UserRole)
                .WillCascadeOnDelete(false);
        }
    }
}
