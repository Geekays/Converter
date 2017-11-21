using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Converter.Controllers
{
    [Produces("application/json")]
    [Route("api/FtoC")]
    public class FtoCController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "This is a converter for F to C" };
        }

        // GET api/values/5
        [HttpGet("{f}")]
        public string Get(int f)
        {
            return ((f - 32) * 5 / 9).ToString();
        }
    }
}