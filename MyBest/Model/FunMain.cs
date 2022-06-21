namespace MyBest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FunMain")]
    public partial class FunMain
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string ClinicCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string FunID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string FunName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NodeType { get; set; }

        [StringLength(19)]
        public string CreateDate { get; set; }

        [StringLength(50)]
        public string ICONName { get; set; }

        public int? Sort { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Enable { get; set; }
    }
}
