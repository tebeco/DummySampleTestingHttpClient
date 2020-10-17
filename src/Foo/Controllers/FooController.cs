using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Foo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FooController : ControllerBase
    {
        private readonly IBarService _barService;

        public FooController(IBarService barService)
        {
            _barService = barService;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            return await _barService.GetBarAsync();
        }
    }
}
