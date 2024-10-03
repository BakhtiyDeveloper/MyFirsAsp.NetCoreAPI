using Microsoft.AspNetCore.Mvc;

namespace MyFirsAsp.NetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutController : ControllerBase
    {
        [HttpGet("{pageName}")]
        public string GetAboutDescription(string pageName) 
        {
            if (pageName == "User")
            {
                return "This is user page";
            }
            else 
            {
                return "This is about page"; 
            } 
        }
    }
}
