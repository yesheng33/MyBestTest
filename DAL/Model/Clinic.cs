using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DAL.Model
{
    public class Clinic
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string ClinicCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(48)]
        public string ClinicName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string ClinicOwner { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string ClinicType { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string ZipCode { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(60)]
        public string AddressN { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(25)]
        public string Tel1 { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(25)]
        public string Tel2 { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(25)]
        public string Fax { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "date")]
        public DateTime OpenDate { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime SysCreateDate { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool Enable { get; set; }
    }
}
