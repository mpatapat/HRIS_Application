using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HRIS_Application.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the HRIS_ApplicationUser class
    public class HRIS_ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(75)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(75)")]
        public string LastName { get; set; }
    }
}
