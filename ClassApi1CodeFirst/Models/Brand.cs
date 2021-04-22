﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BroadwaysApiApplication.Models
{
    public  class Brand
    {
        [Key]
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandModel { get; set; }

    }
}
