namespace MyBest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FunThree")]
    public partial class FunThree
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string ClinicCode { get; set; }

        [Key]
        [Column("FunThree", Order = 1)]
        [StringLength(4)]
        public string FunThree1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string FunThreeName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NodeType { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(4)]
        public string PatentID { get; set; }

        [StringLength(19)]
        public string CreateDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(4)]
        public string NodeOneID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(4)]
        public string NodeTwoID { get; set; }

        public int? Sort { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Enable { get; set; }
    }
}
