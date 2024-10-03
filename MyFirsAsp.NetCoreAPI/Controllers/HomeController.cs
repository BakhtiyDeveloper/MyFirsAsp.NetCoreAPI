using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirsAsp.NetCoreAPI.Controllers
{
    [Route("api/[controller]")]      //https://localhost:7174/api/Home 
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string SayHello() =>
            "Hello World from Controller"; 



    }
}
 