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
    public partial class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string DeleveryStatus { get; set; }
        [Display(Name = "User")]
        public virtual int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User Users { get; set; }
        [Display(Name = "Cart")]
        public virtual int CartId { get; set; }
        [ForeignKey("CartId")]
        public virtual Cart Carts { get; set; }
        [Display(Name ="Payment")]
        public virtual int PaymentId { get; set; }
        [ForeignKey("PaymentId")]
        public virtual Payment Payments { get; set; }

    }
}
