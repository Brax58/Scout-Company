using Microsoft.AspNetCore.Mvc;

namespace Scout.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PostController : ControllerBase
    {
        [HttpPost]
        public void InsertPost()
        {

        }

        [HttpGet]
        public void GetPost()
        {

        }
    }
}
