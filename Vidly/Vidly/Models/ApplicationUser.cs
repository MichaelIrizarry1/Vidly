using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Vidly.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int DriverLicense { get; set; }

    }
}
