using HotelListingNew.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingNew.Controllers
{
    [ApiVersion("2.0", Deprecated = true)]
    [Route("api/{v:apiversion}/country")]
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {
        private DatabaseContext _context;

        public CountryV2Controller(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            return Ok(_context.Countries);
        }
    }
}
