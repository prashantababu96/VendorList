using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassApi1CodeFirst.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        public int Roles { get; set; }
    }
}
