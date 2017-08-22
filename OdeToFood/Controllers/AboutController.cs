using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    // Attribute based routing
    [Route("about")]
    public class AboutController
    {
        // Default route if about/
        [Route("")] 
        public string Phone()
        {
            return "555555555";
        }

        // about/address
        [Route("address")]
        public string Address()
        {
            return "USA";
        }
    }
}
