using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BroadwaysApiApplication.Models
{
    public partial class Cart
    {
        [Key]
        public int CartId { get; set; }
        [Display(Name = "Product")]
        public virtual int ProductId { get; set; }
        [ForeignKey("RoleId")]
        public virtual Product Products { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Date { get; set; }



    }
}
