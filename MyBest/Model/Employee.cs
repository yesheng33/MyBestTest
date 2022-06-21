namespace MyBest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string ClinicCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string UserNo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string UserName { get; set; }

        [StringLength(10)]
        public string ArrDate { get; set; }

        [StringLength(10)]
        public string LeaveDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string Birth { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(9)]
        public string CBirth { get; set; }

        [StringLength(6)]
        public string Zip1 { get; set; }

        [StringLength(6)]
        public string Zip2 { get; set; }

        [StringLength(60)]
        public string Addr1 { get; set; }

        [StringLength(60)]
        public string Addr2 { get; set; }

        [StringLength(25)]
        public string Tel1 { get; set; }

        [StringLength(25)]
        public string Tel2 { get; set; }

        [StringLength(15)]
        public string Moble1 { get; set; }

        [StringLength(15)]
        public string Moble2 { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(15)]
        public string Pass { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(3)]
        public string Role { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoginCount { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool LoginMark { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(19)]
        public string CreateDate { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(20)]
        public string CreateUser { get; set; }

        [StringLength(19)]
        public string UpdateDate { get; set; }

        [StringLength(20)]
        public string UpdateUser { get; set; }

        [StringLength(19)]
        public string DeleteDate { get; set; }

        [StringLength(20)]
        public string DeleteUser { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool Enable { get; set; }
    }
}
