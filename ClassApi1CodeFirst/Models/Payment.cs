using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BroadwaysApiApplication.Models
{
    public partial class Payment
    {

        [Key]
        public int PaymentId { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public int? Totalamount { get; set; }
        [Required]
        public DateTime? PaymentDate { get; set; }

    }
}
