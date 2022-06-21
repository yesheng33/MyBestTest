using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class DB : DbContext
    {
        public virtual DbSet<Clinic> Clinics { get; set; }
        public DB() : base("name=Model1")
        {
           
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clinic>()
              .Property(e => e.ClinicCode)
              .IsUnicode(false);

            modelBuilder.Entity<Clinic>()
                .Property(e => e.ZipCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Clinic>()
                .Property(e => e.Tel1)
                .IsUnicode(false);

            modelBuilder.Entity<Clinic>()
                .Property(e => e.Tel2)
                .IsUnicode(false);

            modelBuilder.Entity<Clinic>()
                .Property(e => e.Fax)
                .IsUnicode(false);
        }
    }
}
