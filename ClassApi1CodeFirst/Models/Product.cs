using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BroadwaysApiApplication.Models
{
    public partial class Product
    {
    
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "SubCategory")]
        public virtual int SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public virtual SubCategory SubCategories { get; set; }

        [Display(Name ="Vendor")]
        public virtual int VendorId { get; set; }
        [ForeignKey("VendorId")]
        public virtual Vendor Vendors { get; set; }

        public string ProductName { get; set; }
        public string Image { get; set; }
        public int? Quantity { get; set; }
        public int? Stock { get; set; }
        [Display(Name = "Offer")]
        public virtual int OfferId { get; set; }
        [ForeignKey("OfferId")]
        public virtual Offer Offers { get; set; }
        [Display(Name ="Brand")]
        public virtual int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brands { get; set; }
        public string Review { get; set; }
        public string Description { get; set; }
        public int? Discount { get; set; }


        //public virtual Brand Brand { get; set; }
        //public virtual Offer Offer { get; set; }
        //public virtual TblSubCategory SubCategory { get; set; }
        //public virtual TblVendor Vendor { get; set; }
        //public virtual ICollection<Cart> TblCart { get; set; }
    }
}
