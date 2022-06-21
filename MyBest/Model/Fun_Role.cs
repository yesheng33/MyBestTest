namespace MyBest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fun_Role
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
        [StringLength(4)]
        public string FunID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string RoleN { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string FunN { get; set; }
    }
}
