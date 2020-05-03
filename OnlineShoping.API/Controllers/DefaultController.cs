using Microsoft.AspNetCore.Mvc;

namespace OnlineShoping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        // GET api/Default
        [HttpGet]
        public IActionResult Get()
        {
            return Content("Hello World! CP Here..");
        }
    }
}