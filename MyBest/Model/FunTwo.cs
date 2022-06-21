namespace MyBest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FunTwo")]
    public partial class FunTwo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string ClinicCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string FunTwoID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string FunTowName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NodeType { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(4)]
        public string PatentID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(19)]
        public string CreateDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(4)]
        public string NodeOneID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(4)]
        public string NodeTwoID { get; set; }

        [StringLength(350)]
        public string URL { get; set; }

        [StringLength(50)]
        public string ICONName { get; set; }

        public int? Sort { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Enable { get; set; }
    }
}
