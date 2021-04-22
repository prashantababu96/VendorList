using ClassApi1CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BroadwaysApiApplication.Models
{
    public partial class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }
        [Display(Name = "User")]
        public virtual int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User Users { get; set; }
        [Display(Name = "Role")]
        public virtual int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Roles { get; set; }
    }
}
