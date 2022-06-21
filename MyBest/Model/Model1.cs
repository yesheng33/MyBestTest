namespace MyBest.Model
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

        public virtual DbSet<Clinics> Clinics { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Fun_Role> Fun_Role { get; set; }
        public virtual DbSet<FunMain> FunMain { get; set; }
        public virtual DbSet<FunThree> FunThree { get; set; }
        public virtual DbSet<FunTwo> FunTwo { get; set; }
        public virtual DbSet<RoleMain> RoleMain { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clinics>()
                .Property(e => e.ClinicCode)
                .IsUnicode(false);

            modelBuilder.Entity<Clinics>()
                .Property(e => e.ZipCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Clinics>()
                .Property(e => e.Tel1)
                .IsUnicode(false);

            modelBuilder.Entity<Clinics>()
                .Property(e => e.Tel2)
                .IsUnicode(false);

            modelBuilder.Entity<Clinics>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.ClinicCode)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserNo)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.ArrDate)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LeaveDate)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Birth)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.CBirth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Zip1)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Zip2)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Tel1)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Tel2)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Moble1)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Moble2)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.CreateDate)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UpdateDate)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UpdateUser)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.DeleteDate)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.DeleteUser)
                .IsUnicode(false);

            modelBuilder.Entity<Fun_Role>()
                .Property(e => e.ClinicCode)
                .IsUnicode(false);

            modelBuilder.Entity<Fun_Role>()
                .Property(e => e.RoleID)
                .IsUnicode(false);

            modelBuilder.Entity<Fun_Role>()
                .Property(e => e.FunID)
                .IsUnicode(false);

            modelBuilder.Entity<FunMain>()
                .Property(e => e.ClinicCode)
                .IsUnicode(false);

            modelBuilder.Entity<FunMain>()
                .Property(e => e.FunID)
                .IsUnicode(false);

            modelBuilder.Entity<FunMain>()
                .Property(e => e.CreateDate)
                .IsUnicode(false);

            modelBuilder.Entity<FunMain>()
                .Property(e => e.ICONName)
                .IsUnicode(false);

            modelBuilder.Entity<FunThree>()
                .Property(e => e.ClinicCode)
                .IsUnicode(false);

            modelBuilder.Entity<FunThree>()
                .Property(e => e.FunThree1)
                .IsUnicode(false);

            modelBuilder.Entity<FunThree>()
                .Property(e => e.PatentID)
                .IsUnicode(false);

            modelBuilder.Entity<FunThree>()
                .Property(e => e.CreateDate)
                .IsUnicode(false);

            modelBuilder.Entity<FunThree>()
                .Property(e => e.NodeOneID)
                .IsUnicode(false);

            modelBuilder.Entity<FunThree>()
                .Property(e => e.NodeTwoID)
                .IsUnicode(false);

            modelBuilder.Entity<FunTwo>()
                .Property(e => e.ClinicCode)
                .IsUnicode(false);

            modelBuilder.Entity<FunTwo>()
                .Property(e => e.FunTwoID)
                .IsUnicode(false);

            modelBuilder.Entity<FunTwo>()
                .Property(e => e.PatentID)
                .IsUnicode(false);

            modelBuilder.Entity<FunTwo>()
                .Property(e => e.CreateDate)
                .IsUnicode(false);

            modelBuilder.Entity<FunTwo>()
                .Property(e => e.NodeOneID)
                .IsUnicode(false);

            modelBuilder.Entity<FunTwo>()
                .Property(e => e.NodeTwoID)
                .IsUnicode(false);

            modelBuilder.Entity<FunTwo>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<FunTwo>()
                .Property(e => e.ICONName)
                .IsUnicode(false);

            modelBuilder.Entity<RoleMain>()
                .Property(e => e.ClinicCode)
                .IsUnicode(false);

            modelBuilder.Entity<RoleMain>()
                .Property(e => e.RoleID)
                .IsUnicode(false);
        }
    }
}
