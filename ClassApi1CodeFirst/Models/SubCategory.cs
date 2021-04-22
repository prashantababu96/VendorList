using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BroadwaysApiApplication.Models
{
    public partial class SubCategory
    {

        [Key]
        public int SubCategoryId { get; set; }
        //public int /*CategoryId*/ { get; set; }
        [Required]
        public string SubCategoryName { get; set; }
        [Display(Name = "Category")]
        public virtual int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Categories { get; set; }
    }
}
