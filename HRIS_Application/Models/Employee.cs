using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS_Application.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        [Required]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [Required]
        [DisplayName("Emp. Code")]
        public string EmpCode { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        [Required]
        
        public string Position { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        [DisplayName("Office Branch")]
        public string BranchLocation { get; set; }

    }
}
