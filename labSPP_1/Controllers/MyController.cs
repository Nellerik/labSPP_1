using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace labSPP_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        [HttpGet("task1")]
        public string GetString()
        {
            return "Сообщение";
        }
    }
}
