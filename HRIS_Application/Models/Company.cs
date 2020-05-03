using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRIS_Application.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [Required]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        
        [Column(TypeName = "nvarchar(10)")]
        [Required]
        [DisplayName("Company Code")]
        public string CompanyCode { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [Required]
        [DisplayName("Company Type")]
        public string CompanyType { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Company Address")]
        public string CompanyAddress { get; set; }
    }
}
