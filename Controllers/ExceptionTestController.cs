using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleeareHandling_ExceptionAndLogging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExceptionTestController : ControllerBase
    {
        [HttpGet]
        public async Task<string> Get()
        {
            throw new System.Exception("GlobalException Test");
            return "Debug Sonucu Gelen HttpRequest Middleware Kontrolu";
        }  
    }
}
