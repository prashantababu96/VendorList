using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BroadwaysApiApplication.Models;
using ClassApi1CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassApi1CodeFirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendorController : ControllerBase
    {

        //OnlineShopDBContext db = new OnlineShopDBContext();
        [HttpGet]
        public IEnumerable<Vendor> Get()
        {
            using (OnlineShopDBContext db = new OnlineShopDBContext())
            {
                return db.Vendors.ToList();

            }




        }
    }
}