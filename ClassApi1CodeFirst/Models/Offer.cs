﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BroadwaysApiApplication.Models
{
    public partial class Offer
    {
        [Key]
        public int OfferId { get; set; }
        public string OfferName { get; set; }

    }
}
