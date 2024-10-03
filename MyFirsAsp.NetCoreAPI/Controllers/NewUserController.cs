using Microsoft.AspNetCore.Mvc;

namespace MyFirsAsp.NetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewUserController : ControllerBase
    {
        [HttpGet("{userName}")]
        public string SayHelloWithName(string userName) 
        {
            if (userName == "Baxtiyor") 
            {
                return $"Hello {userName}";
            }
            else
            {
                return "Hello new user"; 
            }
        }


    }
}
