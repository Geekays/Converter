using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Converter.Controllers
{
    [Produces("application/json")]
    [Route("api/CtoF")]
    public class CtoFController : Controller
    {
        // GET: api/CtoF
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "This is a converter from C to F" };
        }

        // GET api/values/5
        [HttpGet("{c}")]
        public string Get(int c)
        {
            return (((9 * c) / 5) + 32).ToString();
        }

    }
}