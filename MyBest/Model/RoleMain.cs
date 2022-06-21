namespace MyBest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleMain")]
    public partial class RoleMain
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string ClinicCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string RoleID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string RoleName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Salary { get; set; }

        public int? Sort { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Enable { get; set; }
    }
}
