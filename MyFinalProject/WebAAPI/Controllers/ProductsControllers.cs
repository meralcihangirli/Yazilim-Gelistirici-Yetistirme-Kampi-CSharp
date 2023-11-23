using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //attribute
    public class ProductsControllers : ControllerBase
    {
        [HttpGet] 
        public string Get()

        {
            return "Merhaba";
        }
    }
}
